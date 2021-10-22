namespace AppPharmacesOfCity
{
    partial class PharmacyEdit
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
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label phoneLabel;
            this.pharmacyofcityDataSet = new AppPharmacesOfCity.pharmacyofcityDataSet();
            this.pharmacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacesTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.PharmacesTableAdapter();
            this.tableAdapterManager = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager();
            this.medicinesExistTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.MedicinesExistTableAdapter();
            this.medicinesTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.MedicinesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.medicinesExistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesExistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesExistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesExistBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(23, 34);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(18, 72);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(42, 13);
            adressLabel.TabIndex = 3;
            adressLabel.Text = "Adress:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(19, 111);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone:";
            // 
            // pharmacyofcityDataSet
            // 
            this.pharmacyofcityDataSet.DataSetName = "pharmacyofcityDataSet";
            this.pharmacyofcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacesBindingSource
            // 
            this.pharmacesBindingSource.DataMember = "Pharmaces";
            this.pharmacesBindingSource.DataSource = this.pharmacyofcityDataSet;
            // 
            // pharmacesTableAdapter
            // 
            this.pharmacesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MedicinesExistTableAdapter = this.medicinesExistTableAdapter;
            this.tableAdapterManager.MedicinesTableAdapter = this.medicinesTableAdapter;
            this.tableAdapterManager.PharmacesTableAdapter = this.pharmacesTableAdapter;
            this.tableAdapterManager.TherapyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // medicinesExistTableAdapter
            // 
            this.medicinesExistTableAdapter.ClearBeforeFill = true;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacesBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(67, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(187, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacesBindingSource, "adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(67, 65);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(187, 20);
            this.adressTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacesBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(67, 104);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(187, 20);
            this.phoneTextBox.TabIndex = 13;
            // 
            // medicinesExistBindingSource
            // 
            this.medicinesExistBindingSource.DataMember = "MedicinesExist";
            this.medicinesExistBindingSource.DataSource = this.pharmacyofcityDataSet;
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this.pharmacyofcityDataSet;
            // 
            // medicinesExistBindingSource1
            // 
            this.medicinesExistBindingSource1.DataMember = "FK_MedicinesExist_Pharmaces";
            this.medicinesExistBindingSource1.DataSource = this.pharmacesBindingSource;
            // 
            // PharmacyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 246);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(adressLabel);
            this.Controls.Add(nameLabel);
            this.Name = "PharmacyEdit";
            this.Text = "PharmacyEdit";
            this.Load += new System.EventHandler(this.PharmacyEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesExistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesExistBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pharmacesBindingSource;
        private pharmacyofcityDataSetTableAdapters.PharmacesTableAdapter pharmacesTableAdapter;
        private pharmacyofcityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public pharmacyofcityDataSet pharmacyofcityDataSet;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox adressTextBox;
        public System.Windows.Forms.TextBox phoneTextBox;
        private pharmacyofcityDataSetTableAdapters.MedicinesExistTableAdapter medicinesExistTableAdapter;
        private System.Windows.Forms.BindingSource medicinesExistBindingSource;
        private pharmacyofcityDataSetTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private System.Windows.Forms.BindingSource medicinesExistBindingSource1;
    }
}