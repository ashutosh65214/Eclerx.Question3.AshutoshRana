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
                using(cmd=new SqlCommand("usp_Fetch", obj))
                {
                    cmd.CommandType=CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountNo", TxtAccountNo.Text);
                    cmd.Parameters.AddWithValue("@Amount", TxtAmount.Text);
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
                using(cmd=new SqlCommand("Select Amount from AccountDetails where AccountNo=@AccountNo", obj))
                {
                    
                    using (adapter=new SqlDataAdapter())
                    {
                       
                        SqlCommandBuilder cbd = new SqlCommandBuilder();
                        cmd.Parameters.AddWithValue("@AccountNo", TxtAccountNo.Text);

                        obj.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        string amt = "";
                        if (reader.Read())
                        {
                            amt = reader["Amount"].ToString();
                            LblShowBalanceAmount.Text = amt;
                        }
                        reader.Close();
                        using (cmd = new SqlCommand("Update AccountDetails set Amount=@Amount where AccountNo=@AccountNo ", obj))
                        {
                            double amount = 0;
                            if (ComboTransactionType.SelectedItem != null)
                            {
                                if (ComboTransactionType.SelectedItem.Equals("Debit"))
                                {
                                    if (ds != null)
                                    {
                                        amount = Convert.ToDouble(amt) - Convert.ToDouble(TxtAmount.Text);
                                        LblShowBalanceAmount.Text = Convert.ToString(amount);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Account doesnt exist");
                                    }

                                }
                                else if (ComboTransactionType.SelectedItem.Equals("Credit"))
                                {
                                    if(ds != null)
                                    {
                                        amount = Convert.ToDouble(amt) + Convert.ToDouble(TxtAmount.Text);
                                        LblShowBalanceAmount.Text = Convert.ToString(amount);
                                    }

                                }
                                

                            }
                            else
                            {
                                MessageBox.Show("Please enter some value");
                            }
                            cmd.Parameters.AddWithValue("@AccountNo", TxtAccountNo.Text);
                            cmd.Parameters.AddWithValue("@Amount", Convert.ToString(amount));
                            DataTable dt = new DataTable();
                            cmd.Connection = obj;
                            adapter.SelectCommand = cmd;

                            ds = new DataSet();
                            adapter.Fill(ds, "Account");




                        }
                        

                    }



                    if (obj.State == ConnectionState.Closed)
                    {
                        obj.Open();
                    }
                    cmd.ExecuteNonQuery();


                }
            }


        }
    }
}
