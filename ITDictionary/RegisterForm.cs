using MongoDB.Driver;

namespace ITDictionary
{
    public partial class RegisterForm : Form
    {
        public string CreatedUsername { get; private set; } = "";

        public RegisterForm()
        {
            InitializeComponent();

            txtNewPassword.TextChanged += (s, e) => UpdatePasswordChecks();
            txtConfirmPassword.TextChanged += (s, e) => UpdatePasswordChecks();
            txtNewUsername.TextChanged += (s, e) => UpdateCreateButton();
            chkAccept.CheckedChanged += (s, e) => UpdateCreateButton();

            chkShowPassword.CheckedChanged += (s, e) =>
            {
                bool hide = !chkShowPassword.Checked;
                txtNewPassword.UseSystemPasswordChar = hide;
                txtConfirmPassword.UseSystemPasswordChar = hide;
            };

            lnkTerms.LinkClicked += (s, e) => ShowTerms();
            btnCreate.Click += (s, e) => CreateAccount();
            btnCancel.Click += (s, e) => Close();

            UpdatePasswordChecks();
        }

        private void UpdatePasswordChecks()
        {
            string p = txtNewPassword.Text;
            string nl = Environment.NewLine;

            bool typing = p != "";
            lblStrengthTitle.Visible = typing;
            pnlStrengthBar.Visible = typing;
            lblStrength.Visible = typing;
            lblRequirements.Visible = typing;

            lblRequirements.Text =
                Check(PasswordHelper.HasMinLength(p)) + "At least 8 characters" + nl +
                Check(PasswordHelper.HasUpper(p)) + "Uppercase letter (A-Z)" + nl +
                Check(PasswordHelper.HasLower(p)) + "Lowercase letter (a-z)" + nl +
                Check(PasswordHelper.HasNumber(p)) + "Number (0-9)" + nl +
                Check(PasswordHelper.HasSpecial(p)) + "Special character (!@#$%)";

            int score = PasswordHelper.Score(p);
            Color color;

            if (score == 5)
            {
                lblStrength.Text = "Strong";
                color = Color.SeaGreen;
            }
            else if (score >= 3)
            {
                lblStrength.Text = "Medium";
                color = Color.Orange;
            }
            else
            {
                lblStrength.Text = "Weak";
                color = Color.Red;
            }

            lblStrength.ForeColor = color;
            pnlStrengthFill.BackColor = color;
            pnlStrengthFill.Width = Math.Max(1, pnlStrengthBar.Width * score / 5);
            lblRequirements.ForeColor = score == 5 ? Color.SeaGreen : Color.DimGray;

            if (txtConfirmPassword.Text == "")
            {
                lblMatch.Text = "";
            }
            else if (txtConfirmPassword.Text == p)
            {
                lblMatch.Text = "✔ Passwords match";
                lblMatch.ForeColor = Color.SeaGreen;
            }
            else
            {
                lblMatch.Text = "✖ Passwords do not match";
                lblMatch.ForeColor = Color.Red;
            }

            UpdateCreateButton();
        }

        private static string Check(bool ok) => ok ? "✔  " : "✖  ";

        private void UpdateCreateButton()
        {
            bool ready = txtNewUsername.Text.Trim() != ""
                && PasswordHelper.IsStrong(txtNewPassword.Text)
                && txtNewPassword.Text == txtConfirmPassword.Text
                && chkAccept.Checked;

            btnCreate.Enabled = ready;
            btnCreate.BackColor = ready ? Color.SeaGreen : Color.DarkGray;
        }

        private void ShowTerms()
        {
            MessageBox.Show(
                "IT Dictionary - Terms and Conditions\n\n" +
                "1. This admin account is for managing IT terms only.\n" +
                "2. Do not share your username and password with others.\n" +
                "3. Add, edit, or delete terms responsibly and make sure the information is correct.\n" +
                "4. Your password is stored securely in hashed form.\n" +
                "5. The developers may remove accounts that misuse the system.",
                "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateAccount()
        {
            string username = txtNewUsername.Text.Trim();
            string password = txtNewPassword.Text;

            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters.", "Create Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Database.Admins.Find(a => a.Username == username).Any())
            {
                MessageBox.Show("This username is already taken. Please choose another one.", "Create Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string salt = PasswordHelper.CreateSalt();
            Database.Admins.InsertOne(new Admin
            {
                Username = username,
                Salt = salt,
                PasswordHash = PasswordHelper.Hash(password, salt)
            });

            CreatedUsername = username;
            MessageBox.Show("Account created successfully! You can now log in.", "Create Account",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}