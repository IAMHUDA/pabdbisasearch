using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum13
{
    public partial class printData : Form
    {
        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
            "Initial Catalog = informasiMhs;; " +
            "Integrated Security = True;MultipleActiveResultSets=true";
        CrystalReport2 cr = new CrystalReport2();
        string nmKar = "";

        public printData(string nmaKar)
        {
            InitializeComponent();
            nmKar = nmaKar;
            crystalReportViewer1.ReportSource = null;
        }

        private void NIM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (NIM.Text.Length == 7)
                {
                    string sql = "SELECT Nama FROM InfoMahasiswa WHERE NIM = @nim";
                    SqlConnection connection = new SqlConnection(strKoneksi);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@nim", NIM.Text);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        cbSmst.Enabled = true;
                        if (cbSmst.Items.Count.Equals(0))
                        {
                            cbSmst.Items.Add("GASAL");
                            cbSmst.Items.Add("GENAP");
                        }
                    }
                    else
                    {
                        cbSmst.Items.Clear();
                        cbSmst.Enabled = false;
                        MessageBox.Show("NIM tidak ada", "Kesalahan pada input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kesalahan Inpu Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         
        private void cbSmst_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTA.Enabled = true;
            int tahun = DateTime.Now.Year;
            if (cbTA.Items.Count.Equals(0))
            {
                for (int i = 2010; i <= tahun; i++)
                {
                    string item = Convert.ToString(i) + "/" + Convert.ToString(i + 1);
                    cbTA.Items.Add(item);
                    btnCari.Enabled = true;
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT k.NIM, mhs.Nama AS 'NamaMahasiswa', m.kdMK, m.namaMK AS 'MataKuliah', k.Semester, k.ThAjar, " +
                               "m.sks AS 'SKS', k.totalsks AS 'TotalSKS' " +
                               "FROM KRS k " +
                               "JOIN MK m ON k.kdMK = m.kdMK " +
                               "JOIN InfoMahasiswa mhs ON k.NIM = mhs.nim " +
                               "WHERE k.NIM = @NIM AND k.Semester = @Semester AND k.ThAjar = @ThAjar";

                using (SqlConnection koneksi = new SqlConnection(strKoneksi))
                {
                    using (SqlCommand cmd = new SqlCommand(query, koneksi))
                    {
                        cmd.Parameters.AddWithValue("@NIM", NIM.Text);
                        cmd.Parameters.AddWithValue("@Semester", cbSmst.Text);
                        cmd.Parameters.AddWithValue("@ThAjar", cbTA.Text);

                        koneksi.Open();

                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            DataTable ds = new DataTable();
                            ad.Fill(ds);

                            if (ds.Rows.Count > 0)
                            {
                                cr.SetDataSource(ds);
                                crystalReportViewer1.ReportSource = cr;
                                crystalReportViewer1.Refresh();
                                crystalReportViewer1.AllowedExportFormats = (int)(ViewerExportFormats.PdfFormat);
                            }
                            else
                            {
                                crystalReportViewer1.ReportSource = null;
                                MessageBox.Show("Data tidak ditemukan", "Kesalahan pada input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printData_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard dashboard = new dashboard(nmKar);
            dashboard.Show();
            this.Hide();
        }

        private void printData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'informasiMhsDataSet.KRS' table. You can move, or remove it, as needed.
            this.kRSTableAdapter.Fill(this.informasiMhsDataSet.KRS);

        }
    }
}
