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
        //program for converting windows addresses - shall run with git hub - shall be of slight slight use...
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            string myWinAdd = "";
            try
            {
                myWinAdd = Clipboard.GetText();
                myWinAdd = textClean(myWinAdd);
                txtAddress.Text = myWinAdd;
            }
            catch(Exception x)
            {
                txtAddress.Text = x.Message;
            }
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

        private void lblInstructions_Click(object sender, EventArgs e)
        {
            lblInstructions.Text = "ok";
            System.Threading.Thread.Sleep(1000);
            MessageBox.Show("Double click form to change cliboard of windows address" 
            + " to unix friendly address for GitBash. It will be automatically changed on your cliboard..");
            lblInstructions.Text = "help";
        }
       
    }
}