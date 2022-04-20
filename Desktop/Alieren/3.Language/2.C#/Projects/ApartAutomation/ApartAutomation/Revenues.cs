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

namespace ApartAutomation
{
    public partial class Revenues : Form
    {
        public Revenues()
        {
            InitializeComponent();
        }

        SqlHelper sqlHelper = new SqlHelper();

        private void btn_Register_Click(object sender, EventArgs e)
        {
            int daireNo = Convert.ToInt32(ComboBox_FloorNo.Text);
            int Money = Convert.ToInt32(nUD_Price.Value);
            DateTime date = dTP_Date.Value;

            //PARAMETRE OLUŞTUR
            SqlParameter p1 = new SqlParameter("Daireno", daireNo);
            SqlParameter p2 = new SqlParameter("Para", Money);
            SqlParameter p3 = new SqlParameter("Tarih", date);

            sqlHelper.ExecuteProc("odeme_al",p1,p2,p3);


          


        }

        private void Revenues_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.GetTable("Select * From AidatOdemesi");

            foreach (DataRow herhangi in dt.Rows) //dt'nin içindeki ROw'larda gez.
            {
                listBox1.Items.Add(herhangi["DaireNo"]).ToString();
                listBox2.Items.Add(herhangi["Para"]).ToString();
                listBox3.Items.Add(herhangi["Tarih"]).ToString();
            }
        }
    }
}
