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
    public partial class Authintification : Form
    {
        public Authintification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["login"]) && textBox2.Text == Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["password"]) 
                && Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["role"]) == "Admin"
                || Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["role"]) == "Администратор"
                || Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["role"]) == "Administrator")
            {
                Program.mainWindow = new MainWindow();
                Program.mainWindow.Show();
                this.Hide();
            }
            else if(textBox1.Text == Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["login"]) && textBox2.Text == Convert.ToString(((DataRowView)this.usersBindingSource.Current).Row["password"]))
            {
                Program.mainWindow = new MainWindow();
                Program.mainWindow.Show();
                Program.mainWindow.addToolStripMenuItem.Visible = false;
                Program.mainWindow.updateToolStripMenuItem.Visible = false;
                Program.mainWindow.deleteToolStripMenuItem.Visible = false;
                Program.mainWindow.tabControl1.Controls.Remove(Program.mainWindow.tabPage3);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sorry, but the Username or Password is invalid");
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyofcityDataSet);

        }

        private void Authintification_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyofcityDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pharmacyofcityDataSet.Users);

        }
    }
}
