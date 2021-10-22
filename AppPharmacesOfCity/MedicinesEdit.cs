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
    public partial class MedicinesEdit : Form
    {
        private bool flag;

        public MedicinesEdit()
        {
            Program.medicinesEdit = this;
            InitializeComponent();
        }

        public MedicinesEdit(bool flag)
        {
            Program.medicinesEdit = this;
            this.flag = flag;
            InitializeComponent();
        }

        private void medicinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyofcityDataSet);

        }

        private void MedicinesEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyofcityDataSet.Medicines);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Program.mainWindow = new MainWindow();
                if (nameTextBox.Text == "" || producing_countryTextBox.Text == "" || date_of_manufactureTextBox.Text == "" || form_of_issueTextBox.Text == "" || countTextBox.Text == "" || expiration_dateTextBox.Text == "" || priceTextBox.Text == "")
                {
                    MessageBox.Show("The entry could not be saved.");
                }
                else
                {
                    Program.mainWindow.medicinesTableAdapter.Insert(nameTextBox.Text, producing_countryTextBox.Text, 
                        date_of_manufactureTextBox.Text, form_of_issueTextBox.Text, 
                        Convert.ToInt32(countTextBox.Text), expiration_dateTextBox.Text, priceTextBox.Text);
                    Program.mainWindow.medicinesTableAdapter.Fill(Program.mainWindow.pharmacyofcityDataSet.Medicines);
                    this.Close();
                }
            }
            else
            {
                ((DataRowView)Program.mainWindow.medicinesBindingSource.Current).Row["name"] = nameTextBox.Text;
                ((DataRowView)Program.mainWindow.medicinesBindingSource.Current).Row["producing_country"] = producing_countryTextBox.Text;
                ((DataRowView)Program.mainWindow.medicinesBindingSource.Current).Row["date_of_manufacture"] = date_of_manufactureTextBox.Text;
                ((DataRowView)Program.mainWindow.medicinesBindingSource.Current).Row["form_of_issue"] = form_of_issueTextBox.Text;
                ((DataRowView)Program.mainWindow.medicinesBindingSource.Current).Row["count"] = countTextBox.Text;
                ((DataRowView)Program.mainWindow.medicinesBindingSource.Current).Row["expiration_date"] = expiration_dateTextBox.Text;
                ((DataRowView)Program.mainWindow.medicinesBindingSource.Current).Row["price"] = priceTextBox.Text;

                Program.mainWindow.medicinesTableAdapter.Update(Program.mainWindow.pharmacyofcityDataSet.Medicines);
                Program.mainWindow.medicinesTableAdapter.Fill(Program.mainWindow.pharmacyofcityDataSet.Medicines);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
