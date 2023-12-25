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

namespace lab9
{
    public partial class Goods : Form
    {
        SqlConnection conn = null;
        public Goods()
        {
            InitializeComponent();
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delivery_OchirmaDataSet.Поставлено". При необходимости она может быть перемещена или удалена.
            this.поставленоTableAdapter.Fill(this.delivery_OchirmaDataSet.Поставлено);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delivery_OchirmaDataSet.View_4". При необходимости она может быть перемещена или удалена.
            this.view_4TableAdapter.Fill(this.delivery_OchirmaDataSet.View_4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delivery_OchirmaDataSet.Договоры". При необходимости она может быть перемещена или удалена.
            this.договорыTableAdapter.Fill(this.delivery_OchirmaDataSet.Договоры);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = NewDgvr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int codeSupplier = int.Parse(this.comboBox1.SelectedValue.ToString());
                DateTime datedgvr = Convert.ToDateTime(this.dateTimePicker1.Text);
                string dgvrComment = Convert.ToString(this.textBox1.Text);
                conn = new SqlConnection();

                try
                {
                    conn.ConnectionString = "integrated security=SSPI;data source=\".\"; persist security info=False; initial catalog=Delivery_Ochirma";
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO Договоры (КодПоставщика, ДатаДоговора, Комментарий) VALUES (@codeSupplier, @datedgvr, @dgvrComment)";
                    cmd.Parameters.Add("@codeSupplier", SqlDbType.Int, 4);
                    cmd.Parameters["@codeSupplier"].Value = codeSupplier;
                    cmd.Parameters.Add("@datedgvr", SqlDbType.DateTime, 8);
                    cmd.Parameters["@datedgvr"].Value = datedgvr;
                    cmd.Parameters.Add("@dgvrComment", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@dgvrComment"].Value = dgvrComment;

                    int SucceedChange = cmd.ExecuteNonQuery();
                    if (SucceedChange != 0)
                    {
                        MessageBox.Show("Изменения внесены", "Изменение записи");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось внести изменения ", "Изменение записи");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            this.договорыTableAdapter.Fill(this.delivery_OchirmaDataSet.Договоры);
            tabControl1.SelectedTab = Dgvrs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = Dgvrs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dgvrNumber = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["номерДоговораDatagridViewTextBoxColumn"].Value.ToString());
            DialogResult result = MessageBox.Show("Удалить договор №" + Convert.ToString(dgvrNumber) + "?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            conn = new SqlConnection();
                            conn.ConnectionString = "integrated security=SSPI;data source=\".\"; persist security info=False; initial catalog=Delivery_Ochirma";
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM Договоры WHERE НомерДоговора = @dgvrNumber";
                            cmd.Parameters.Add("@dgvrNumber", SqlDbType.Int, 4);
                            cmd.Parameters["@dgvrNumber"].Value = dgvrNumber;

                            int SucceedChange = cmd.ExecuteNonQuery();
                            if (SucceedChange != 0)
                            {
                                MessageBox.Show("Изменения внесены", "Изменение записи");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось внести изменения ", "Изменение записи");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();
                        }
                        this.договорыTableAdapter.Fill(this.delivery_OchirmaDataSet.Договоры);
                        break;
                    }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int dgvrNumber = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["номерДоговораDatagridViewTextBoxColumn"].Value.ToString());
                string tovar = textBox2.Text;
                int tovar_col = int.Parse(textBox3.Text);
                decimal tovar_cena = Convert.ToDecimal(textBox4.Text);
                conn = new SqlConnection();
                conn.ConnectionString = "integrated security=SSPI;data source=\".\"; persist security info=False; initial catalog=Delivery_Ochirma";
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Поставлено (НомерДоговора, Товар,Количество, Цена)" +
                     "VALUES(@dgvrNumber, @tovar, @tovar_col, @tovar_cena)";

                cmd.Parameters.Add("@dgvrNumber", SqlDbType.Int, 4);
                cmd.Parameters["@dgvrNumber"].Value = dgvrNumber;

                cmd.Parameters.Add("@tovar", SqlDbType.NVarChar, 20);
                cmd.Parameters["@tovar"].Value = tovar;

                cmd.Parameters.Add("@tovar_col", SqlDbType.Int, 8);
                cmd.Parameters["@tovar_col"].Value = tovar_col;

                cmd.Parameters.Add("@tovar_cena", SqlDbType.Decimal, 8);
                cmd.Parameters["@tovar_cena"].Value = tovar_cena;

                int SucceedChange = cmd.ExecuteNonQuery();
                if (SucceedChange != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                }
                else
                {
                    MessageBox.Show("Не удалось внести изменения ", "Изменение записи");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            this.поставленоTableAdapter.Fill(delivery_OchirmaDataSet.Поставлено);
            tabControl2.SelectedTab = tabPage3;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedTab = tabPage3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int dgvrNumber = int.Parse(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["номерДоговораDatagridViewTextBoxColumn1"].Value.ToString());
            string dgvrTovar = Convert.ToString(dataGridView2["товарDatagridViewTextBoxColumn", dataGridView2.CurrentCell.RowIndex].Value);

            DialogResult result = MessageBox.Show("Удалить из договора №" + dgvrNumber.ToString() + " товар " + dgvrTovar + "?",
                "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = "integrated security=SSPI;data source=\".\"; persist security info=False; initial catalog=Delivery_Ochirma";
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM Поставлено WHERE " +
                        "НомерДоговора = @dgvrNumber AND Товар = @dgvrtovar";
                    cmd.Parameters.Add("@dgvrNumber", SqlDbType.Int, 4);
                    cmd.Parameters["@dgvrNumber"].Value = dgvrNumber;

                    cmd.Parameters.Add("@dgvrtovar", SqlDbType.NVarChar, 20);
                    cmd.Parameters["@dgvrtovar"].Value = dgvrTovar;

                    int SucceedChange = cmd.ExecuteNonQuery();
                    if (SucceedChange != 0)
                    {
                        MessageBox.Show("Изменения внесены", "Изменение записи");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось внести изменения ", "Изменение записи");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
                this.поставленоTableAdapter.Fill(this.delivery_OchirmaDataSet.Поставлено);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dgvrNumber = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["номерДоговораDatagridViewTextBoxColumn"].Value.ToString());
                conn = new SqlConnection();
                conn.ConnectionString = "integrated security=SSPI;data source=\".\"; persist security info=False; initial catalog=Delivery_Ochirma";
             
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[sp_sum_dgvr]";
                cmd.Parameters.Add("@dgvrNumber", SqlDbType.Int, 4);
                cmd.Parameters["@dgvrNumber"].Value = dgvrNumber;
                cmd.Parameters["@dgvrNumber"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add("@sum_kolvo", SqlDbType.Int, 4);
                cmd.Parameters["@sum_kolvo"].Direction = ParameterDirection.Output;
                
                cmd.Parameters.Add("@sum_summa", SqlDbType.Money);
                cmd.Parameters["@sum_summa"].Direction = ParameterDirection.Output;


                conn.Open();

                cmd.ExecuteScalar();
                textBox5.Text = Convert.ToString(cmd.Parameters["@sum_kolvo"].Value);
                textBox6.Text = Convert.ToString(cmd.Parameters["@sum_summa"].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
