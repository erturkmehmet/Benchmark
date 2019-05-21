using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenchMark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();

        Stopwatch watch = new Stopwatch();
        private void btnConnected_Click(object sender, EventArgs e)
        {
            //1.yol
            //watch.Start();
            //Conn.Open();
            //string SqlStmt = "SELECT ORDERID FROM ORDERS";
            //SqlCommand cmd = new SqlCommand(SqlStmt, Conn);
            //SqlDataReader dr = cmd.ExecuteReader();

            //while(dr.Read())
            //{
            //    lbConnected.Items.Add(dr["OrderID"]);
            //}
            //Conn.Close();

            //watch.Stop();

            //lblTime_Cnn.Text = watch.Elapsed.Milliseconds.ToString();
            //watch.Reset();

            //2.yol
            SqlConnection Conn = new SqlConnection("server=.;Database=Northwind;integrated security=True");

            DateTime baslangic = DateTime.Now;

            SqlCommand cmd = new SqlCommand("SELECT ORDERID FROM ORDERS", Conn);
            if (Conn.State == ConnectionState.Closed) Conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lbConnected.Items.Add(dr.GetInt32(0));
                }
            }
            dr.Close();
            Conn.Close();
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lblTime_Cnn.Text = ts.Milliseconds.ToString();

        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            //1.yol
            //watch.Start();

            //string SqlStmt = "SELECT ORDERID FROM ORDERS";
            //SqlDataAdapter da = new SqlDataAdapter(SqlStmt, Conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Order");

            //foreach (DataRow item in ds.Tables["Order"].Rows)
            //{
            //    lbDisconnected.Items.Add(item[0].ToString());
            //}
            //watch.Stop();        
            //lblTime_Disc.Text = watch.Elapsed.Milliseconds.ToString();
           //watch.Reset();



            //2.yol
            DateTime baslangic = DateTime.Now;
            SqlDataAdapter da = new SqlDataAdapter("SELECT ORDERID FROM ORDERS", "server =.; Database = Northwind; integrated security=True"); // kendisi açıp kapadığı için bağlantı open gerek yok
            DataTable dt = new DataTable();    //join olmadığı için dataset e gerek yok
            da.Fill(dt);
            lbDisconnected.DataSource = dt;
            lbDisconnected.DisplayMember = "OrderId"; // istediğimiz kolonu gösterir         
         
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lblTime_Disc.Text = ts.Milliseconds.ToString();
            
        }

        private void btnEntity_Click(object sender, EventArgs e)
        {
            //1.yol
            //watch.Start();

            //var orderid = db.Orders.Select(x => x.OrderID).ToList();
            //foreach (var item in orderid)
            //{
            //    lbEntity.Items.Add(item);

            //}
            //watch.Stop();
            //lblTime_Entity.Text = watch.Elapsed.Milliseconds.ToString();
            //watch.Reset();

            //2.yol
            DateTime baslangic = DateTime.Now;
            lbEntity.DataSource = db.Orders.Select(x => new
            {
              x.OrderID
            }).ToList();
            lbEntity.DisplayMember = "OrderId";
            DateTime bitis = DateTime.Now;
            TimeSpan ts = bitis - baslangic;
            lblTime_Entity.Text = ts.Milliseconds.ToString();


        }

    }
}
