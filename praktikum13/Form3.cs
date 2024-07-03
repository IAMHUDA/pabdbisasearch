using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum13
{
    public partial class Form3 : Form
    {
        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
            "Initial Catalog = informasiMhs;; " +
            "Integrated Security = True;MultipleActiveResultSets=true";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strKoneksi);
            connection.Open();
            string query = "select mhs.Nama as 'Nama Mahasiswa', m.namaMK as 'Mata Kuliah', " +
                "k.totalpembayaran as 'Biaya KRS'," +
                "k.totalsks as 'Total SKS', k.buktipembayaran as 'Bukti Pembayaran' from KRS k " +
                "join MK m on k.kdMK = m.kdMK join InfoMahasiswa mhs on k.NIM = mhs.NIM";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            foreach(DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Biaya KRS"].DefaultCellStyle.Format = "C";
                dataGridView1.Columns["Biaya KRS"].DefaultCellStyle.FormatProvider
                     = CultureInfo.GetCultureInfo("id-ID");
            }
        }
    }
}
