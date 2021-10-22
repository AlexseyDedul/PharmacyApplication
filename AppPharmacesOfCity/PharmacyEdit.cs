using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPharmacesOfCity
{
    public partial class PharmacyEdit : Form
    {
        private bool flag;

        public PharmacyEdit()
        {
            Program.pharmacyEdit = this;
            InitializeComponent();
        }

        public PharmacyEdit(bool flag)
        {
            Program.pharmacyEdit = this;
            this.flag = flag;
            InitializeComponent();
        }

        private void PharmacyEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyofcityDataSet.Medicines);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.MedicinesExist' table. You can move, or remove it, as needed.
            this.medicinesExistTableAdapter.Fill(this.pharmacyofcityDataSet.MedicinesExist);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Pharmaces' table. You can move, or remove it, as needed.
            this.pharmacesTableAdapter.Fill(this.pharmacyofcityDataSet.Pharmaces);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Program.mainWindow = new MainWindow();
                if (nameTextBox.Text == "" || adressTextBox.Text == "" || phoneTextBox.Text == "")
                {
                    MessageBox.Show("Don`t saved.");
                }
                else
                {
                    Program.mainWindow.pharmacesTableAdapter.Insert(nameTextBox.Text, adressTextBox.Text, phoneTextBox.Text);
                    Program.mainWindow.pharmacesTableAdapter.Fill(Program.mainWindow.pharmacyofcityDataSet.Pharmaces);
                    this.Close();
                }
            }
            else
            {
                ((DataRowView)Program.mainWindow.pharmacesBindingSource.Current).Row["name"] = nameTextBox.Text;
                ((DataRowView)Program.mainWindow.pharmacesBindingSource.Current).Row["adress"] = adressTextBox.Text;
                ((DataRowView)Program.mainWindow.pharmacesBindingSource.Current).Row["phone"] = phoneTextBox.Text;

                Program.mainWindow.pharmacesTableAdapter.Update(Program.mainWindow.pharmacyofcityDataSet.Pharmaces);
                Program.mainWindow.pharmacesTableAdapter.Fill(Program.mainWindow.pharmacyofcityDataSet.Pharmaces);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
