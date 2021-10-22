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
    public partial class ExistMedEdit : Form
    {
        public ExistMedEdit()
        {
            InitializeComponent();
        }

        private void therapyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.therapyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyofcityDataSet);

        }

        private void ExistMedEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Pharmaces' table. You can move, or remove it, as needed.
            this.pharmacesTableAdapter.Fill(this.pharmacyofcityDataSet.Pharmaces);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyofcityDataSet.Medicines);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.MedicinesExist' table. You can move, or remove it, as needed.
            this.medicinesExistTableAdapter.Fill(this.pharmacyofcityDataSet.MedicinesExist);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Therapy' table. You can move, or remove it, as needed.
            this.therapyTableAdapter.Fill(this.pharmacyofcityDataSet.Therapy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.mainWindow = new MainWindow();
            if (restTextBox.Text == "" || countTextBox.Text == "")
            {
                MessageBox.Show("The entry could not be saved.");
            }
            else
            {
                Program.mainWindow.medicinesExistTableAdapter.Insert(Convert.ToInt32(((DataRowView)this.pharmacesBindingSource.Current).Row["id_pharmacy"]), Convert.ToInt32(((DataRowView)this.medicinesBindingSource.Current).Row["id_medicament"]), restTextBox.Text, countTextBox.Text);
                Program.mainWindow.medicinesExistTableAdapter.Fill(Program.mainWindow.pharmacyofcityDataSet.MedicinesExist);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
