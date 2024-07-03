using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum13
{
    public partial class Form1 : Form
    {
        Image curImage;
        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
            "Initial Catalog = informasiMhs;; " +
            "Integrated Security = True;MultipleActiveResultSets=true";
        string namaKar = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void uName_TextChanged(object sender, EventArgs e)
        {
            Pass.Enabled = true;
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            if (Pass.Text.Length >= 3)
            {
                byte[] imageData = new byte[0];
                string sql = "SELECT * FROM Karyawan WHERE username = @username " +
                    "AND password = @password";
                SqlConnection connection = new SqlConnection(strKoneksi);
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@username", uName.Text);
                cmd.Parameters.AddWithValue("@password", Pass.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    namaKar = dr["Nama"].ToString();
                    imageData = (byte[])dr["Photo"];
                    try
                    {
                        curImage = Image.FromStream(new MemoryStream(imageData));
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Image = curImage;
                        btnLogin.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading the image: " + ex.Message,
                            "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    btnLogin.Enabled = false;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dashboard fm = new dashboard(namaKar);
            fm.Show();
            this.Hide();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            uName.Text = "";
            Pass.Text = "";
            Pass.Enabled = false;
            btnLogin.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
