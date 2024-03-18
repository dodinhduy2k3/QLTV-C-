using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLTV
{
    public partial class tacgia : Form
    {
        private string connectionString = "Data Source=xe;User ID=QL-Thu-Vien;Password=123456;Unicode=True";
        public tacgia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            admin1 ad = new admin1();
            ad.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tacgia_Load(object sender, EventArgs e)
        {
            nguonTacGia();
        }
        public void nguonTacGia()
        {
            string sql1 = "select * from tacgia";
            using (SqlConnection connn = new SqlConnection(connectionString))
            {
                try
                {
                    connn.Open();
                    SqlCommand command = new SqlCommand(sql1, connn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            
        }
    }
}
