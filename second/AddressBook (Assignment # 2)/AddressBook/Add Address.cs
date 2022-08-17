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
    public partial class Add_Address : Form
    {
        public Add_Address()
        {
            InitializeComponent();
        }

        private void Add_Address_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //TextWriter txt = new StreamWriter("data.txt");

           // txt.WriteLine(tbName.Text);
           // txt.WriteLine(tbFatherName.Text);
           // txt.WriteLine(tbMotherName.Text);
           // txt.WriteLine(tbAddress.Text);
           // txt.WriteLine(tbAge.Text);
           // txt.WriteLine(tbDOB.Text);
            //txt.WriteLine(tbName.Text + "," + tbFatherName.Text + "," + tbMotherName.Text + "," + tbAddress.Text + "," + tbAge.Text + "," + tbDOB.Text + "," + tbMobileNumber.Text);
            //txt.Close();

 
            FileInfo file = new FileInfo("data.txt");  
            //// write the line using streamwriter   
            using(StreamWriter sw = file.AppendText()) {
                sw.WriteLine(tbName.Text + "," + tbFatherName.Text + "," + tbMotherName.Text + "," + tbAddress.Text + "," + tbAge.Text + "," + tbDOB.Text + "," + tbMobileNumber.Text);
                System.Windows.Forms.MessageBox.Show("Record Added Successfully", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }  
           




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            AddressesList a = new AddressesList();
            this.Hide();
            a.Show();
        }

        private void Add_Address_Load(object sender, EventArgs e)
        {

        }
    }
}
