using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class AddressesList : Form
    {
        public AddressesList()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Address a = new Add_Address();
            this.Close();
            a.Show();

        }

        private void AddressesList_Load(object sender, EventArgs e)
        {
           
            //var file = File.OpenText("data.txt");
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Father Name");
            dataTable.Columns.Add("Mother Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Age");
            dataTable.Columns.Add("DOB");
            dataTable.Columns.Add("Mobile Number");


            string[] lines = File.ReadAllLines("data.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataTable.Rows.Add(row);
            }
            dataGridView.DataSource = dataTable;
           
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView.Rows.Remove(row);



                    System.IO.StreamWriter file = new System.IO.StreamWriter("data.txt");
                    try
                    {
                        string sLine = "";

                        //This for loop loops through each row in the table
                        for (int r = 0; r <= dataGridView.Rows.Count - 1; r++)
                        {
                            //This for loop loops through each column, and the row number
                            //is passed from the for loop above.
                            for (int c = 0; c <= dataGridView.Columns.Count - 1; c++)
                            {
                                sLine = sLine + dataGridView.Rows[r].Cells[c].Value;
                                if (c != dataGridView.Columns.Count - 1)
                                {
                                    //A comma is added as a text delimiter in order
                                    //to separate each field in the text file.
                                    //You can choose another character as a delimiter.
                                    sLine = sLine + ",";
                                }
                            }
                            //The exported text is written to the text file, one line at a time.
                            file.WriteLine(sLine);
                            sLine = "";
                        }

                        file.Close();
                        System.Windows.Forms.MessageBox.Show("Record of Selected Row Deleted Successfully", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Exception err)
                    {
                        System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        file.Close();
                    }




                }
            }
        }
        



    }
}
