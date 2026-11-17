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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Register Gagal! full name, username dan wajib diisi!.");

                return;
            }

            bool validation = Validation.UniqueData("users", "username", txtUsername.Text);

            if (validation)
            {
                MessageBox.Show("Register Gagal! username suadah terdaftar!.");

                return;
            }
            string passwordHashed = SecurityHelper.HashingPassword(txtPassword.Text);

            Connection conn = new Connection();


            using (MySqlConnection connection = conn.ConnectionToSQL())
            {
                connection.Open();
                string query = "INSERT INTO users (full_name, username, password) VALUES (@full_name, @user, @pass)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", passwordHashed);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Register Berhasil! Silahkan Login.");
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();

        }

        private void btnNavToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
        }
    }
}
