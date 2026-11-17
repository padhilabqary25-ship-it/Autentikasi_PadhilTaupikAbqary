namespace SchoolAppLoginandRegister3
{
    partial class FormRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSubmitRegister = new System.Windows.Forms.Button();
            this.btnNavToLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Register";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(222, 84);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(316, 39);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Text = "Full Name....";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(222, 129);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(316, 39);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username....";
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSubmitRegister
            // 
            this.btnSubmitRegister.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRegister.Location = new System.Drawing.Point(222, 235);
            this.btnSubmitRegister.Name = "btnSubmitRegister";
            this.btnSubmitRegister.Size = new System.Drawing.Size(316, 42);
            this.btnSubmitRegister.TabIndex = 3;
            this.btnSubmitRegister.Text = "Register";
            this.btnSubmitRegister.UseVisualStyleBackColor = true;
            this.btnSubmitRegister.Click += new System.EventHandler(this.btnSubmitRegister_Click);
            // 
            // btnNavToLogin
            // 
            this.btnNavToLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavToLogin.Location = new System.Drawing.Point(222, 283);
            this.btnNavToLogin.Name = "btnNavToLogin";
            this.btnNavToLogin.Size = new System.Drawing.Size(316, 42);
            this.btnNavToLogin.TabIndex = 4;
            this.btnNavToLogin.Text = "to Login";
            this.btnNavToLogin.UseVisualStyleBackColor = true;
            this.btnNavToLogin.Click += new System.EventHandler(this.btnNavToLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(222, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(316, 39);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password....";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnNavToLogin);
            this.Controls.Add(this.btnSubmitRegister);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Name = "FormRegister";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSubmitRegister;
        private System.Windows.Forms.Button btnNavToLogin;
        private System.Windows.Forms.TextBox txtPassword;
    }
}