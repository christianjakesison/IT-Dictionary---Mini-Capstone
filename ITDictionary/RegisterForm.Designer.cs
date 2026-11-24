namespace ITDictionary
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNewUsername = new TextBox();
            label5 = new Label();
            txtNewPassword = new TextBox();
            lblStrengthTitle = new Label();
            lblStrength = new Label();
            pnlStrengthBar = new Panel();
            pnlStrengthFill = new Panel();
            lblRequirements = new Label();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            lblMatch = new Label();
            chkShowPassword = new CheckBox();
            chkAccept = new CheckBox();
            lnkTerms = new LinkLabel();
            btnCreate = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlStrengthBar.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 673);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(520, 25);
            label1.Name = "label1";
            label1.Size = new Size(232, 41);
            label1.TabIndex = 1;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(522, 65);
            label2.Name = "label2";
            label2.Size = new Size(240, 23);
            label2.TabIndex = 2;
            label2.Text = "Register a new admin account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(520, 105);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewUsername.Location = new Point(520, 128);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(380, 31);
            txtNewUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(520, 173);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(520, 196);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(380, 31);
            txtNewPassword.TabIndex = 7;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblStrengthTitle
            // 
            lblStrengthTitle.AutoSize = true;
            lblStrengthTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStrengthTitle.ForeColor = Color.Navy;
            lblStrengthTitle.Location = new Point(520, 238);
            lblStrengthTitle.Name = "lblStrengthTitle";
            lblStrengthTitle.Size = new Size(74, 20);
            lblStrengthTitle.TabIndex = 8;
            lblStrengthTitle.Text = "Strength:";
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStrength.ForeColor = Color.Red;
            lblStrength.Location = new Point(830, 238);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(48, 20);
            lblStrength.TabIndex = 9;
            lblStrength.Text = "Weak";
            // 
            // pnlStrengthBar
            // 
            pnlStrengthBar.BackColor = Color.Gainsboro;
            pnlStrengthBar.Controls.Add(pnlStrengthFill);
            pnlStrengthBar.Location = new Point(600, 242);
            pnlStrengthBar.Name = "pnlStrengthBar";
            pnlStrengthBar.Size = new Size(220, 10);
            pnlStrengthBar.TabIndex = 10;
            // 
            // pnlStrengthFill
            // 
            pnlStrengthFill.BackColor = Color.Red;
            pnlStrengthFill.Location = new Point(0, 0);
            pnlStrengthFill.Name = "pnlStrengthFill";
            pnlStrengthFill.Size = new Size(1, 10);
            pnlStrengthFill.TabIndex = 0;
            // 
            // lblRequirements
            // 
            lblRequirements.AutoSize = true;
            lblRequirements.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRequirements.ForeColor = Color.DimGray;
            lblRequirements.Location = new Point(520, 262);
            lblRequirements.Name = "lblRequirements";
            lblRequirements.Size = new Size(100, 20);
            lblRequirements.TabIndex = 11;
            lblRequirements.Text = "Requirements";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(520, 375);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 12;
            label4.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(520, 398);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(380, 31);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblMatch
            // 
            lblMatch.AutoSize = true;
            lblMatch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMatch.ForeColor = Color.Red;
            lblMatch.Location = new Point(520, 434);
            lblMatch.Name = "lblMatch";
            lblMatch.Size = new Size(52, 20);
            lblMatch.TabIndex = 14;
            lblMatch.Text = "Match";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(520, 465);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(149, 27);
            chkShowPassword.TabIndex = 15;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // chkAccept
            // 
            chkAccept.AutoSize = true;
            chkAccept.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAccept.Location = new Point(520, 495);
            chkAccept.Name = "chkAccept";
            chkAccept.Size = new Size(122, 27);
            chkAccept.TabIndex = 16;
            chkAccept.Text = "I accept the";
            chkAccept.UseVisualStyleBackColor = true;
            // 
            // lnkTerms
            // 
            lnkTerms.AutoSize = true;
            lnkTerms.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkTerms.ForeColor = Color.RoyalBlue;
            lnkTerms.Location = new Point(635, 497);
            lnkTerms.Name = "lnkTerms";
            lnkTerms.Size = new Size(176, 23);
            lnkTerms.TabIndex = 17;
            lnkTerms.TabStop = true;
            lnkTerms.Text = "Terms and Condition";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.SeaGreen;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(520, 540);
            btnCreate.Name = "btnCreate";
            btnCreate.RightToLeft = RightToLeft.Yes;
            btnCreate.Size = new Size(185, 42);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "CREATE ACCOUNT";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SlateGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(715, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(185, 42);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(942, 673);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(lnkTerms);
            Controls.Add(chkAccept);
            Controls.Add(chkShowPassword);
            Controls.Add(lblMatch);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(lblRequirements);
            Controls.Add(pnlStrengthBar);
            Controls.Add(lblStrength);
            Controls.Add(lblStrengthTitle);
            Controls.Add(txtNewPassword);
            Controls.Add(label5);
            Controls.Add(txtNewUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Admin Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlStrengthBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNewUsername;
        private Label label5;
        private TextBox txtNewPassword;
        private Label lblStrengthTitle;
        private Label lblStrength;
        private Panel pnlStrengthBar;
        private Panel pnlStrengthFill;
        private Label lblRequirements;
        private Label label4;
        private TextBox txtConfirmPassword;
        private Label lblMatch;
        private CheckBox chkShowPassword;
        private CheckBox chkAccept;
        private LinkLabel lnkTerms;
        private Button btnCreate;
        private Button btnCancel;
    }
}