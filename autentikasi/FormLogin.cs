using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolAppLoginandRegister3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnNavToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister frmRegidter = new FormRegister();
            frmRegidter.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Login gagal! Username dan password wajib diisi!");
                return;
            }

            Connection conn = new Connection();

            using (MySqlConnection connection = conn.ConnectionToSQL())
            {
                connection.Open();

                string query = "SELECT password FROM users WHERE username = @user";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Login gagal! Username tidak ditemukan!");
                        return;
                    }

                    string passwordHashed = SecurityHelper.HashingPassword(txtPassword.Text);

                    if (passwordHashed != result.ToString())
                    {
                        MessageBox.Show("Login gagal! Password salah!");
                        return;
                    }
                }
            }

            MessageBox.Show("Login berhasil!");

            this.Hide();

            FormLogin frm = new FormLogin();
            frm.Show();
        }
    }
}
