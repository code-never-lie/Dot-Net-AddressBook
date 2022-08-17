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
    public partial class ManageOptions : Form
    {
        public ManageOptions()
        {
            InitializeComponent();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            AddressesList a = new AddressesList();
            //this.Close();
            a.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAddress s = new SearchAddress();
            s.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintData p = new PrintData();
            this.Hide();
            p.Show();
        }
    }
}
