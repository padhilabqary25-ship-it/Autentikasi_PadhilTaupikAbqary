namespace SchoolAppLoginandRegister3
{
    partial class FormLogin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSubmitLogin = new System.Windows.Forms.Button();
            this.btnNavToRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(218, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(302, 39);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username....";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(218, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(302, 39);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password....";
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitLogin.Location = new System.Drawing.Point(218, 225);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new System.Drawing.Size(302, 37);
            this.btnSubmitLogin.TabIndex = 2;
            this.btnSubmitLogin.Text = "Login";
            this.btnSubmitLogin.UseVisualStyleBackColor = true;
            this.btnSubmitLogin.Click += new System.EventHandler(this.btnSubmitLogin_Click);
            // 
            // btnNavToRegister
            // 
            this.btnNavToRegister.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavToRegister.Location = new System.Drawing.Point(218, 268);
            this.btnNavToRegister.Name = "btnNavToRegister";
            this.btnNavToRegister.Size = new System.Drawing.Size(302, 37);
            this.btnNavToRegister.TabIndex = 3;
            this.btnNavToRegister.Text = "to Register";
            this.btnNavToRegister.UseVisualStyleBackColor = true;
            this.btnNavToRegister.Click += new System.EventHandler(this.btnNavToRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "From Login";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNavToRegister);
            this.Controls.Add(this.btnSubmitLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSubmitLogin;
        private System.Windows.Forms.Button btnNavToRegister;
        private System.Windows.Forms.Label label1;
    }
}

