using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.RegularExpressions;

namespace ITDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCategory.Items.Add("All");
            cmbCategory.Items.AddRange(SeedData.Categories);
            cmbCategory.SelectedIndex = 0;

            txtSearch.TextChanged += (s, e) => LoadTerms();
            cmbCategory.SelectedIndexChanged += (s, e) => LoadTerms();
            lstTerms.SelectedIndexChanged += (s, e) => ShowDetails();
            btnAdmin.Click += (s, e) => OpenAdminLogin();

            SeedData.Run();
            LoadTerms();
        }

        private void LoadTerms()
        {
            var f = Builders<Term>.Filter;
            var filter = f.Empty;

            string keyword = txtSearch.Text.Trim();
            if (keyword != "")
                filter &= f.Regex(t => t.Word, new BsonRegularExpression(Regex.Escape(keyword), "i"));

            string category = cmbCategory.SelectedItem?.ToString() ?? "All";
            if (category != "All")
                filter &= f.Eq(t => t.Category, category);

            var terms = Database.Terms.Find(filter).SortBy(t => t.Word).ToList();
            lstTerms.DataSource = terms;
            lstTerms.DisplayMember = "Word";

            if (terms.Count == 0)
                txtDetails.Text = "No terms found. Try another keyword or category.";
        }

        private void ShowDetails()
        {
            if (lstTerms.SelectedItem is Term t)
            {
                string nl = Environment.NewLine;
                txtDetails.Text =
                    $"{t.Word.ToUpper()}{nl}" +
                    $"Category: {t.Category}{nl}{nl}" +
                    $"What is {t.Word}?{nl}" +
                    $"{t.Definition}{nl}{nl}" +
                    $"Example:{nl}" +
                    $"{t.Example}";
            }
        }

        private void OpenAdminLogin()
        {
            using var login = new LoginForm();
            if (login.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show($"Welcome, {login.LoggedInUsername}!", "Admin Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTerms();
            }
        }
    }
}