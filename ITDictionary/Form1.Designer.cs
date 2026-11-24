namespace ITDictionary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            cmbCategory = new ComboBox();
            lstTerms = new ListBox();
            txtDetails = new TextBox();
            btnAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(982, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 130);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 1;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(100, 127);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 30);
            txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(410, 130);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 3;
            label2.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(510, 127);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 31);
            cmbCategory.TabIndex = 4;
            // 
            // lstTerms
            // 
            lstTerms.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstTerms.FormattingEnabled = true;
            lstTerms.Location = new Point(20, 175);
            lstTerms.Name = "lstTerms";
            lstTerms.Size = new Size(280, 429);
            lstTerms.TabIndex = 5;
            // 
            // txtDetails
            // 
            txtDetails.BackColor = Color.White;
            txtDetails.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetails.Location = new Point(320, 175);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(640, 450);
            txtDetails.TabIndex = 6;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.RoyalBlue;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(800, 125);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(150, 32);
            btnAdmin.TabIndex = 7;
            btnAdmin.Text = "Admin Login";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(btnAdmin);
            Controls.Add(txtDetails);
            Controls.Add(lstTerms);
            Controls.Add(cmbCategory);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IT Dictionary";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private ComboBox cmbCategory;
        private ListBox lstTerms;
        private TextBox txtDetails;
        private Button btnAdmin;
    }
}
