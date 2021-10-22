namespace AppPharmacesOfCity
{
    partial class UserEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.pharmacyofcityDataSet = new AppPharmacesOfCity.pharmacyofcityDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyofcityDataSet
            // 
            this.pharmacyofcityDataSet.DataSetName = "pharmacyofcityDataSet";
            this.pharmacyofcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.pharmacyofcityDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MedicinesExistTableAdapter = null;
            this.tableAdapterManager.MedicinesTableAdapter = null;
            this.tableAdapterManager.PharmacesTableAdapter = null;
            this.tableAdapterManager.TherapyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(19, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(61, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(5, 65);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 2;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(61, 62);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(206, 20);
            this.surnameTextBox.TabIndex = 3;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(28, 101);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(32, 13);
            roleLabel.TabIndex = 4;
            roleLabel.Text = "Role:";
            // 
            // roleTextBox
            // 
            this.roleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "role", true));
            this.roleTextBox.Location = new System.Drawing.Point(61, 98);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(206, 20);
            this.roleTextBox.TabIndex = 5;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(23, 138);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "Login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(61, 135);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(206, 20);
            this.loginTextBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(0, 175);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(61, 172);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(206, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "UserEdit";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pharmacyofcityDataSet pharmacyofcityDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private pharmacyofcityDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private pharmacyofcityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox surnameTextBox;
        public System.Windows.Forms.TextBox roleTextBox;
        public System.Windows.Forms.TextBox loginTextBox;
        public System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}