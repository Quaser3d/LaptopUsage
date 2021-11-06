using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopManagement
{
    public partial class StudentsProfile : Form
    {
        string conString = @"Data Source=LAPTOP-3QN72BJD\SQLEXPRESS;Initial Catalog=LaptopActivity;Integrated Security=True";

        SqlDataAdapter dataAdapter; //Build the connection between the program and our Activity table
        DataTable table;
        SqlCommandBuilder commandBuilder;
        SqlConnection conn;

        string selectionStatement = "SELECT * FROM LaptopProfile";
        public StudentsProfile()
        {
            InitializeComponent();
        }

        private void StudentsProfile_Load(object sender, EventArgs e)
        {
            cboSearch.SelectedIndex = 0; //Loads the first item in the combobox control
            cboStudentsClass.SelectedIndex = 0; //Loads the first students class in the combobox

            dataGridView1.DataSource = bindingSource1;

            GetData(selectionStatement);
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, conString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.Columns[0].ReadOnly = true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "" || txtLastname.Text == "" || txtLaptopModel.Text == "" || txtSerialNo.Text == "" || txtUUID.Text == "" || txtOS.Text == "" || cboStudentsClass.SelectedIndex < 0 || cboLaptopBag.SelectedIndex < 0)
            {
                MessageBox.Show("Please, Fill in the data!");
            }
            else
            {
                SqlCommand command;
                string insert = @"INSERT INTO LaptopProfile(Firstname, Lastname, LaptopModel, SerialNo, UUID,
Class, StudOS, Image, Bag, DateSubmitted, Remark) VALUES (@Firstname, @Lastname, @LaptopModel, @SerialNo, @UUID,
@Class, @StudOS, @Image, @Bag, @DateSubmitted, @Remark)";

                using(conn = new SqlConnection(conString))
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"Firstname", txtFirstname.Text);
                        command.Parameters.AddWithValue(@"Lastname", txtLastname.Text);
                        command.Parameters.AddWithValue(@"LaptopModel", txtLaptopModel.Text);
                        command.Parameters.AddWithValue(@"SerialNo", txtSerialNo.Text);
                        command.Parameters.AddWithValue(@"UUID", txtUUID.Text);
                        command.Parameters.AddWithValue(@"Class", cboStudentsClass.SelectedItem.ToString());
                        command.Parameters.AddWithValue(@"StudOS", txtOS.Text);

                        if (dlgImportImage.FileName != "")
                            command.Parameters.AddWithValue(@"Image", File.ReadAllBytes(dlgImportImage.FileName));
                        else
                            command.Parameters.Add(@"Image", SqlDbType.VarBinary).Value = DBNull.Value;
                        command.Parameters.AddWithValue(@"Bag", cboLaptopBag.SelectedItem.ToString());
                        command.Parameters.AddWithValue(@"DateSubmitted", dtDateSubmitted.Value.Date);
                        command.Parameters.AddWithValue(@"Remark", txtRemarks.Text);
                        command.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                GetData(selectionStatement);
                dataGridView1.Update();
            }
        }

        private void btnImportImage_Click(object sender, EventArgs e)
        {
            dlgImportImage.ShowDialog();
            pic1.Load(dlgImportImage.FileName);
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.BackgroundImage = pic1.Image;
            frm.Size = pic1.Image.Size;
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                bindingSource1.EndEdit();
                dataAdapter.Update(table);
                MessageBox.Show("Update Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string value = row.Cells["StudentsId"].Value.ToString();
            string firstname = row.Cells["Firstname"].Value.ToString();
            string lastname = row.Cells["Lastname"].Value.ToString();
            string studentsclass = row.Cells["Class"].Value.ToString();

            DialogResult result = MessageBox.Show("Do you really want to delete " + firstname
                + " " + ", record " + value, "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string deleteStatement = @"DELETE FROM LaptopProfile WHERE StudentsId = '" + value + "'";

            if(result == DialogResult.Yes)
            {
                using (conn=new SqlConnection(conString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand comm = new SqlCommand(deleteStatement, conn);
                        comm.ExecuteNonQuery();
                        GetData(selectionStatement);
                        dataGridView1.Update();
                        MessageBox.Show("Data Successfully Deleted");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
