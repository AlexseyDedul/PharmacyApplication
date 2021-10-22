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
    public partial class TherapyEdit : Form
    {
        public TherapyEdit()
        {
            InitializeComponent();
        }

        private void therapyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.therapyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyofcityDataSet);

        }

        private void TherapyEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyofcityDataSet.Medicines);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Therapy' table. You can move, or remove it, as needed.
            this.therapyTableAdapter.Fill(this.pharmacyofcityDataSet.Therapy);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.mainWindow = new MainWindow();
            if (dosageTextBox.Text == "" || disease_nameTextBox.Text == "")
            {
                MessageBox.Show("The entry could not be saved.");
            }
            else
            {
                Program.mainWindow.therapyTableAdapter.Insert(disease_nameTextBox.Text, Convert.ToInt32(((DataRowView)this.medicinesBindingSource.Current).Row["id_medicament"]), dosageTextBox.Text);
                Program.mainWindow.therapyTableAdapter.Fill(Program.mainWindow.pharmacyofcityDataSet.Therapy);
                this.Close();
            }
        }
    }
}
