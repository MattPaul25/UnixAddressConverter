using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnixAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblInstructions.Text = "Paste Your windows address in here and it will convert it to unix (for GitBash)";
        }
        private string textClean(string addressTxt)
        {
            string newAddress = "";

            if (addressTxt != "")
            {
                newAddress = addressTxt.Replace(@"\", "/");
                newAddress = newAddress.Replace(" ", @"\ ");
                txtAddress.Text = newAddress;
                Clipboard.SetText(newAddress);
            }
            return newAddress;
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            string myWinAdd = Clipboard.GetText();
            txtAddress.Text = textClean(myWinAdd);
        }
    }
}