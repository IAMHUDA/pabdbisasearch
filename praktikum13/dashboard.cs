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
using System.Windows.Forms.DataVisualization.Charting;

namespace praktikum13
{
    public partial class dashboard : Form
    {
        string strKoneksi = "Data Source = LAPTOP-E2NL0H6I\\MIFTAHUL_HUDA; " +
             "Initial Catalog = informasiMhs; " +
             "Integrated Security = True;MultipleActiveResultSets=true";
        string nmKar = "";
        public dashboard(string nmaKar)
        {
            InitializeComponent();
            nmKar = nmaKar;
            display();
        }

        string Sn { get; set; }

        private void display()
        {
            string hasil = "";
            double hs;
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();
            string str = "select CONCAT(Semester,' ', ThAjar) as TahunAjaraan, " +
                "sum(sisaPembayaran) as TotalPendapatan from KRS group by Semester, ThAjar";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> hasil_arr = new List<string>();
            List<double> hasil_arrs = new List<double>();
            while (dr.Read())
            {
                hasil = dr["TahunAjaraan"].ToString();
                hasil_arr.Add(hasil);
            }
            dr.Close();

            for (int i = 0; i < hasil_arr.Count; i++)
            {
                string js = hasil_arr[i];
                string strs = "select sum(sisaPembayaran) as TotalPendapatan From KRS " +
                    "where CONCAT(Semester, ' ', ThAjar) = '" + js + "' group by Semester, ThAjar";
                SqlCommand cm = new SqlCommand(strs, koneksi);
                object res = cm.ExecuteScalar();
                hs = Convert.ToDouble(res);
                hasil_arrs.Add(hs);
            }

            string query = "select CONCAT(Semester,' ', ThAjar) as TahunAjaraan, " +
                "sum(sisaPembayaran) as TotalPendapatan from KRS group by Semester, ThAjar";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, koneksi);
            sda.Fill(dt);

            string[] x = (from p in dt.AsEnumerable()
                          select p.Field<string>("TahunAjaraan")).ToArray();
            decimal[] y = (from q in dt.AsEnumerable()
                          select q.Field<decimal>("TotalPendapatan")).ToArray();

            for (int i = 0; i < (hasil_arr.Count); i++)
            {
                string js = hasil_arr[i];
                string strs = "select sum(sisaPembayaran) as TotalPendapatan from KRS " +
                    "group by Semester, ThAjar";
                SqlCommand cm = new SqlCommand(strs, koneksi);
                object res = cm.ExecuteScalar();
                hs = Convert.ToDouble(res);
                hasil_arrs.Add(hs);
                y[i] = (decimal)hasil_arrs[i];
            }

            koneksi.Close();

            if (hasil_arr.Count != 0)
            {
                SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string Sname = "Data Pendapatan";
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Sname = row["TahunAjaraan"].ToString();
                    chart1.Series.Add(Sname);
                    chart1.Series[Sname].ChartType = SeriesChartType.Pie;
                    chart1.Series[Sname].IsValueShownAsLabel = true;
                    break;
                }

                chart1.Series[Sname].Points.DataBindXY(x, y);
                chart1.Legends[0].Enabled = true;
            }
            else
            {
                MessageBox.Show("Data Tidak Ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2(nmKar);
            fm.Show();
            this.Hide();
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void KHS_Click(object sender, EventArgs e)
        {
            printData pd = new printData(nmKar);
            pd.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
