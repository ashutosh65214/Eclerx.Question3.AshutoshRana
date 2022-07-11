using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclerx.Question3.AshutoshRana
{
    public partial class Form1 : Form
    {
        private SqlConnection obj = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            using (obj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString))
            {
                using(cmd=new SqlCommand("usp_AddBank", obj))
                {
                    cmd.CommandType=CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountN0", TxtAccountNo.Text);
                    cmd.Parameters.AddWithValue("@TransactionType",ComboTransactionType.Text);
                    cmd.Parameters.AddWithValue("@Amount",TxtAmount.Text);
                    if (obj.State == ConnectionState.Closed)
                    {
                        obj.Open();
                    }
                    cmd.ExecuteNonQuery();

                }

            }
            MessageBox.Show("Update to the table");


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (obj = new SqlConnection(ConfigurationManager.ConnectionStrings["HRCon"].ConnectionString))
            {
                using(adapter=new SqlDataAdapter("Select * from AccountDetails", obj))
                {
                    ds=new DataSet();
                    adapter.Fill(ds, "AccountDetails");
                    DataRow dr = ds.Tables["AccountDetails"].NewRow();

                    if (ComboTransactionType.SelectedItem.ToString() == "Debit")
                    {
                        dr["AccountNo"]=TxtAccountNo.Text;
                        dr["TransactionType"]=ComboTransactionType.SelectedItem.ToString();
                        dr["Amount"] = int.Parse(dr["Amount"].ToString()) - int.Parse(TxtAmount.Text);
                    }
                    else if(ComboTransactionType.SelectedItem.ToString() == "Credit")
                    {
                        dr["AccountNo"] = TxtAccountNo.Text;
                        dr["TransactionType"] = ComboTransactionType.SelectedItem.ToString();
                        dr["Amount"] = int.Parse(dr["Amount"].ToString()) + int.Parse(TxtAmount.Text);


                    }
                    LblBalanceAmount=dr
                }
            }


        }
    }
}
