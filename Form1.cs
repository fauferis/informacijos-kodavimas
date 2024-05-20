using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Uzrasu_knygele
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=knyga;User ID=sa;Password=sa";
        private SecurityController _security;
        public Form1()
        {
            InitializeComponent();
            _security = new SecurityController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    MessageBox.Show("Prisijungta!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaþkas negerai: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO dbo.info (vardas, pavarde, numeris, adresas) VALUES (@vardas, @pavarde, @numeris, @adresas)";
                    using (SqlCommand insertSQL = new SqlCommand(query, cnn))
                    {
                        insertSQL.Parameters.Add("@vardas", SqlDbType.NVarChar).Value = textBox1.Text;
                        insertSQL.Parameters.Add("@pavarde", SqlDbType.NVarChar).Value = textBox2.Text;
                        insertSQL.Parameters.Add("@numeris", SqlDbType.NVarChar).Value = textBox3.Text;
                        insertSQL.Parameters.Add("@adresas", SqlDbType.NVarChar).Value = textBox4.Text;

                        cnn.Open();
                        insertSQL.ExecuteNonQuery();
                        button3.PerformClick();
                    }
                }

                MessageBox.Show("Duomenys sekmingai irasyti!", "Pavyko", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaþkas negerai: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM info";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "info");
                    dataGridView1.DataSource = ds.Tables["info"].DefaultView;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM info WHERE pavarde like '%" + textBox5.Text + "%'";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "info");
                    dataGridView1.DataSource = ds.Tables["info"].DefaultView;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM info WHERE id = @id";
                    using (SqlCommand deleteSQL = new SqlCommand(query, cnn))
                    {
                        deleteSQL.Parameters.Add("@id", SqlDbType.NChar).Value = textBox6.Text;

                        cnn.Open();
                        deleteSQL.ExecuteNonQuery();
                        button3.PerformClick();
                    }
                }

                MessageBox.Show("Duomenys sekmingai istrinti!", "Pavyko", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaþkas negerai: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE info SET numeris = @numeris WHERE id = @id";
                    using (SqlCommand updateSQL = new SqlCommand(query, cnn))
                    {
                        updateSQL.Parameters.Add("@numeris", SqlDbType.VarChar).Value = textBox8.Text;
                        updateSQL.Parameters.Add("@id", SqlDbType.NChar).Value = textBox7.Text;
                        cnn.Open();
                        updateSQL.ExecuteNonQuery();
                        button3.PerformClick();
                    }
                }
                MessageBox.Show("Duomenys sekmingai readaguoti!", "Pavyko", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaþkas negerai: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string password = textBox10.Text;
            string notEncryptedText = textBox9.Text;
            string encryptedText = _security.Encrypt(password, notEncryptedText);

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO dbo.kodavimas (encryptedText) VALUES (@encryptedText)";
                    using (SqlCommand insertSQL = new SqlCommand(query, cnn))
                    {
                        insertSQL.Parameters.Add("@encryptedText", SqlDbType.NVarChar).Value = encryptedText;

                        cnn.Open();
                        insertSQL.ExecuteNonQuery();

                    }
                }

                MessageBox.Show("Duomenys sekmingai irasyti!", "Pavyko", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaþkas negerai: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string password = textBox12.Text;
            string encryptedText = textBox11.Text;
            string notEncryptedText = _security.Decrypt(password, encryptedText);
            MessageBox.Show(notEncryptedText, "Pavyko", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM kodavimas";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "kodavimas");
                    dataGridView1.DataSource = ds.Tables["kodavimas"].DefaultView;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
