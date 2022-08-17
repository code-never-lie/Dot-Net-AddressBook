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
    public partial class PrintData : Form
    {
        public PrintData()
        {
            InitializeComponent();
        }

        private void PrintData_Load(object sender, EventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics,
                                new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dataGridView, myPaintArgs);
        }
    }
}
