using MongoDB.Driver;

namespace ITDictionary
{
    public partial class LoginForm : Form
    {
        public string LoggedInUsername { get; private set; } = "";

        public LoginForm()
        {
            InitializeComponent();

            chkShowPassword.CheckedChanged += (s, e) =>
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;

            btnLogin.Click += (s, e) => Login();
            btnBack.Click += (s, e) => Close();
            lnkCreateAccount.LinkClicked += (s, e) => OpenRegister();

            AcceptButton = btnLogin;
        }

        private void Login()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.", "Admin Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var admin = Database.Admins.Find(a => a.Username == username).FirstOrDefault();

            if (admin == null || !PasswordHelper.Verify(password, admin.Salt, admin.PasswordHash))
            {
                MessageBox.Show("Invalid username or password.", "Admin Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            LoggedInUsername = admin.Username;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OpenRegister()
        {
            using var register = new RegisterForm();
            register.ShowDialog(this);
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}