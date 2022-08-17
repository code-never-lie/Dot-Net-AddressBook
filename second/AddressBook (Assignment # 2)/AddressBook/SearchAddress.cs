using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class SearchAddress : Form
    {
        public SearchAddress()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;


            var text = tbSearchBox.Text;

            System.IO.StreamReader file =
                new System.IO.StreamReader("data.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(text))
                {
                    String s = line;
                    string[] str = s.Split(',');
                    tbName.Text = str[0];
                    tbFatherName.Text = str[1];
                    tbMotherName.Text = str[2];
                    tbAddress.Text = str[3];
                    tbAge.Text = str[4];
                    tbDOB.Text = str[5];
                    tbMobileNumber.Text = str[6];
                    break;
                }

                counter++;
            }

            Console.WriteLine("Line number: {0}", counter);

            file.Close();
        }
    }
}
