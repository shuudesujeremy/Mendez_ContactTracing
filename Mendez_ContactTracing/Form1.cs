﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mendez_ContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtboxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("Contact.txt");
            outputFile.WriteLine(" ");
            outputFile.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void NewForm()
        {
            txtboxFname.Text = "";
            txtboxLname.Text = "";
            txtboxAge.Text = "";
            txtboxAddress.Text = "";
            txtboxContact.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("Contact.txt");
            outputFile.Write(txtboxFname.Text + " ");
            outputFile.WriteLine(txtboxLname.Text);
            outputFile.WriteLine(txtboxAge.Text);
            outputFile.WriteLine(txtboxAddress.Text);
            outputFile.WriteLine(txtboxContact);
            outputFile.WriteLine("================");
            outputFile.WriteLine(" ");
            outputFile.Close();
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = File.OpenText("Contact.txt");
            MessageBox.Show(inputFile.ReadToEnd());
        }

      
    }
}
