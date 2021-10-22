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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            Program.mainWindow = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Therapy' table. You can move, or remove it, as needed.
            this.therapyTableAdapter.Fill(this.pharmacyofcityDataSet.Therapy);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.MedicinesExist' table. You can move, or remove it, as needed.
            this.medicinesExistTableAdapter.Fill(this.pharmacyofcityDataSet.MedicinesExist);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Pharmaces' table. You can move, or remove it, as needed.
            this.pharmacesTableAdapter.Fill(this.pharmacyofcityDataSet.Pharmaces);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Medicines' table. You can move, or remove it, as needed.
            this.medicinesTableAdapter.Fill(this.pharmacyofcityDataSet.Medicines);
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pharmacyofcityDataSet.Users);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Program.pharmacyEdit = new PharmacyEdit(true);
                Program.pharmacyEdit.Show();

                Program.pharmacyEdit.nameTextBox.Clear();
                Program.pharmacyEdit.adressTextBox.Clear();
                Program.pharmacyEdit.phoneTextBox.Clear();
            }else if(tabControl1.SelectedIndex == 1)
            {
                Program.medicinesEdit = new MedicinesEdit(true);
                Program.medicinesEdit.Show();

                Program.medicinesEdit.nameTextBox.Clear();
                Program.medicinesEdit.producing_countryTextBox.Clear();
                Program.medicinesEdit.date_of_manufactureTextBox.Clear();
                Program.medicinesEdit.form_of_issueTextBox.Clear();
                Program.medicinesEdit.countTextBox.Clear();
                Program.medicinesEdit.expiration_dateTextBox.Clear();
                Program.medicinesEdit.priceTextBox.Clear();
            }else if(tabControl1.SelectedIndex == 2)
            {
                Program.userEdit = new UserEdit(true);
                Program.userEdit.Show();

                Program.userEdit.nameTextBox.Clear();
                Program.userEdit.surnameTextBox.Clear();
                Program.userEdit.roleTextBox.Clear();
                Program.userEdit.loginTextBox.Clear();
                Program.userEdit.passwordTextBox.Clear();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Program.pharmacyEdit = new PharmacyEdit(false);
                Program.pharmacyEdit.Show();

                Program.pharmacyEdit.nameTextBox.Text = Convert.ToString(((DataRowView)this.pharmacesBindingSource.Current).Row["name"]);
                Program.pharmacyEdit.adressTextBox.Text = Convert.ToString(((DataRowView)this.pharmacesBindingSource.Current).Row["adress"]);
                Program.pharmacyEdit.phoneTextBox.Text = Convert.ToString(((DataRowView)this.pharmacesBindingSource.Current).Row["phone"]);
            }else if (tabControl1.SelectedIndex == 1)
            {
                Program.medicinesEdit = new MedicinesEdit(false);
                Program.medicinesEdit.Show();

                Program.medicinesEdit.nameTextBox.Text = Convert.ToString(((DataRowView)this.medicinesBindingSource.Current).Row["name"]);
                Program.medicinesEdit.producing_countryTextBox.Text = Convert.ToString(((DataRowView)this.medicinesBindingSource.Current).Row["producing_country"]);
                Program.medicinesEdit.date_of_manufactureTextBox.Text = Convert.ToString(((DataRowView)this.medicinesBindingSource.Current).Row["date_of_manufacture"]);
                Program.medicinesEdit.form_of_issueTextBox.Text = Convert.ToString(((DataRowView)this.medicinesBindingSource.Current).Row["form_of_issue"]);
                Program.medicinesEdit.countTextBox.Text = Convert.ToString(((DataRowView)this.medicinesBindingSource.Current).Row["count"]);
                Program.medicinesEdit.expiration_dateTextBox.Text = Convert.ToString(((DataRowView)this.medicinesBindingSource.Current).Row["expiration_date"]);
                Program.medicinesEdit.priceTextBox.Text = Convert.ToString(((DataRowView)this.medicinesBindingSource.Current).Row["price"]);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                Program.userEdit = new UserEdit(false);
                Program.userEdit.Show();

                Program.userEdit.nameTextBox.Text = Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["name"]);
                Program.userEdit.surnameTextBox.Text = Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["surname"]);
                Program.userEdit.roleTextBox.Text = Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["role"]);
                Program.userEdit.loginTextBox.Text = Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["login"]);
                Program.userEdit.passwordTextBox.Text = Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["password"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.existMedEdit = new ExistMedEdit();
            Program.existMedEdit.Show();

            Program.existMedEdit.restTextBox.Clear();
            Program.existMedEdit.countTextBox.Clear();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                try
                {
                    if (MessageBox.Show("Do you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pharmacesBindingSource.RemoveCurrent();
                        pharmacesTableAdapter.Update(pharmacyofcityDataSet.Pharmaces);
                        pharmacesTableAdapter.Fill(pharmacyofcityDataSet.Pharmaces);
                    }
                }
                catch
                {
                    DialogResult = MessageBox.Show("This row cannot delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                try
                {
                    if (MessageBox.Show("Do you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        medicinesBindingSource.RemoveCurrent();
                        medicinesTableAdapter.Update(pharmacyofcityDataSet.Medicines);
                        medicinesTableAdapter.Fill(pharmacyofcityDataSet.Medicines);
                    }
                }
                catch
                {
                    DialogResult = MessageBox.Show("This row cannot delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (tabControl1.SelectedIndex == 2)
            {
                try
                {
                    if (MessageBox.Show("Do you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        usersBindingSource.RemoveCurrent();
                        usersTableAdapter.Update(pharmacyofcityDataSet.Users);
                        usersTableAdapter.Fill(pharmacyofcityDataSet.Users);
                    }
                }
                catch
                {
                    DialogResult = MessageBox.Show("This row cannot delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    medicinesExistBindingSource.RemoveCurrent();
                    medicinesExistTableAdapter.Update(pharmacyofcityDataSet.MedicinesExist);
                    medicinesExistTableAdapter.Fill(pharmacyofcityDataSet.MedicinesExist);
                }
            }
            catch
            {
                DialogResult = MessageBox.Show("This row cannot delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.therapyEdit = new TherapyEdit();
            Program.therapyEdit.Show();

            Program.therapyEdit.disease_nameTextBox.Clear();
            Program.therapyEdit.dosageTextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    therapyBindingSource.RemoveCurrent();
                    therapyTableAdapter.Update(pharmacyofcityDataSet.Therapy);
                    therapyTableAdapter.Fill(pharmacyofcityDataSet.Therapy);
                }
            }
            catch
            {
                DialogResult = MessageBox.Show("This row cannot delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (textBox1.Text != "")
                    pharmacesBindingSource.Filter = "name LIKE'%" + textBox1.Text + "%'";
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (textBox1.Text != "")
                    medicinesBindingSource.Filter = "name LIKE'%" + textBox1.Text + "%'";
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                if (textBox1.Text != "")
                    usersBindingSource.Filter = "name LIKE'%" + textBox1.Text + "%'";
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Search";
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
