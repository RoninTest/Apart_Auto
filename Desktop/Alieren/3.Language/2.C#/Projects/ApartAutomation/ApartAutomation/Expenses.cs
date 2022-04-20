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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        SqlHelper sqlHelper = new SqlHelper();
        private void btn_Register_Click(object sender, EventArgs e)
        {
            int para = Convert.ToInt32(nUD_Price.Value);
            DateTime tarih = dTP_Date.Value;
            string giderler = "";
            foreach (Control herhangi in groupBox1.Controls)
            {
                if (herhangi is CheckBox && ((CheckBox)herhangi).Checked)
                {
                    giderler += ","+ herhangi.Text;
                }
            }
            giderler = giderler.Remove(0, 1); //virgül kısmını sildik.
           
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("tarih", tarih);
            SqlParameter p1 = new SqlParameter("Gider", giderler);

            sqlHelper.ExecuteProc("giderlerim",p1,p2,p3);



        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            
            DataTable dataTable = sqlHelper.GetTable("Select * From GiderTablosu");  //GetTable static olmadığı için newliyoruz. Gider talobusunu çektiğimiz sorguyu yazacağız. 
            foreach (DataRow item in dataTable.Rows)
            {
                //Sql deki ID,gider,para,tarih bir dizi olarak düşün
                listBox1.Items.Add(item[3]).ToString();
                listBox2.Items.Add(item[1]).ToString();
                listBox3.Items.Add(item[2]).ToString();


            }
        }
    }
}
