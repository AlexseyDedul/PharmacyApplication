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
    public partial class UserEdit : Form
    {
        private bool flag;

        public UserEdit()
        {
            Program.userEdit = this;
            InitializeComponent();
        }

        public UserEdit(bool flag)
        {
            Program.userEdit = this;
            this.flag = flag;
            InitializeComponent();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pharmacyofcityDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Program.mainWindow = new MainWindow();
                if (nameTextBox.Text == "" || surnameTextBox.Text == "" || roleTextBox.Text == "" || loginTextBox.Text == "" || passwordTextBox.Text == "")
                {
                    MessageBox.Show("");////////////////////////////////////////////
                }
                else
                {
                    Program.mainWindow.usersTableAdapter.Insert(nameTextBox.Text, surnameTextBox.Text,
                        roleTextBox.Text, loginTextBox.Text, passwordTextBox.Text);
                    Program.mainWindow.usersTableAdapter.Fill(Program.mainWindow.pharmacyofcityDataSet.Users);
                    this.Close();
                }
            }
            else
            {
                ((DataRowView)Program.mainWindow.usersBindingSource.Current).Row["name"] = nameTextBox.Text;
                ((DataRowView)Program.mainWindow.usersBindingSource.Current).Row["surname"] = surnameTextBox.Text;
                ((DataRowView)Program.mainWindow.usersBindingSource.Current).Row["role"] = roleTextBox.Text;
                ((DataRowView)Program.mainWindow.usersBindingSource.Current).Row["login"] = loginTextBox.Text;
                ((DataRowView)Program.mainWindow.usersBindingSource.Current).Row["password"] = passwordTextBox.Text;

                Program.mainWindow.usersTableAdapter.Update(Program.mainWindow.pharmacyofcityDataSet.Users);
                Program.mainWindow.usersTableAdapter.Fill(Program.mainWindow.pharmacyofcityDataSet.Users);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
