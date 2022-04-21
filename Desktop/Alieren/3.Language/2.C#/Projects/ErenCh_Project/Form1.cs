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

namespace ErenCh_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=RONIN;Initial Catalog=ErenChannel;Integrated Security=True");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert Into TblVideo (VideoName,Category,Link) values (@p1,@p2,@p3)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@p1", txtVideoName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtCategory.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtLink.Text);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Video Added your list", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        void videos()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From TblVideo",sqlConnection);
            DataTable table = new DataTable(); //tablo yarattım şimdi de bu tablonun içini dolduracağım
            sqlDataAdapter.Fill(table); //sqlDataAdapter Fill table ' ı
            dataGridView1.DataSource = table;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videos();
            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[choosen].Cells[3].Value.ToString();//Link DB'de 3. Index'te
            System.Diagnostics.Process.Start(link);
            webBrowser3.Navigate(link);

            //webBrowser1.Navigate(link);



        }
    }
}
