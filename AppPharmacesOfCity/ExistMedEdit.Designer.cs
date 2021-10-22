namespace AppPharmacesOfCity
{
    partial class ExistMedEdit
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
            System.Windows.Forms.Label restLabel;
            System.Windows.Forms.Label countLabel;
            this.pharmacyofcityDataSet = new AppPharmacesOfCity.pharmacyofcityDataSet();
            this.therapyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.therapyTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TherapyTableAdapter();
            this.tableAdapterManager = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager();
            this.medicinesExistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesExistTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.MedicinesExistTableAdapter();
            this.restTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.MedicinesTableAdapter();
            this.pharmacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacesTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.PharmacesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            restLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesExistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyofcityDataSet
            // 
            this.pharmacyofcityDataSet.DataSetName = "pharmacyofcityDataSet";
            this.pharmacyofcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // therapyBindingSource
            // 
            this.therapyBindingSource.DataMember = "Therapy";
            this.therapyBindingSource.DataSource = this.pharmacyofcityDataSet;
            // 
            // therapyTableAdapter
            // 
            this.therapyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MedicinesExistTableAdapter = this.medicinesExistTableAdapter;
            this.tableAdapterManager.MedicinesTableAdapter = this.medicinesTableAdapter;
            this.tableAdapterManager.PharmacesTableAdapter = this.pharmacesTableAdapter;
            this.tableAdapterManager.TherapyTableAdapter = this.therapyTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // medicinesExistBindingSource
            // 
            this.medicinesExistBindingSource.DataMember = "MedicinesExist";
            this.medicinesExistBindingSource.DataSource = this.pharmacyofcityDataSet;
            // 
            // medicinesExistTableAdapter
            // 
            this.medicinesExistTableAdapter.ClearBeforeFill = true;
            // 
            // restLabel
            // 
            restLabel.AutoSize = true;
            restLabel.Location = new System.Drawing.Point(42, 110);
            restLabel.Name = "restLabel";
            restLabel.Size = new System.Drawing.Size(32, 13);
            restLabel.TabIndex = 0;
            restLabel.Text = "Rest:";
            // 
            // restTextBox
            // 
            this.restTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesExistBindingSource, "rest", true));
            this.restTextBox.Location = new System.Drawing.Point(75, 103);
            this.restTextBox.Name = "restTextBox";
            this.restTextBox.Size = new System.Drawing.Size(182, 20);
            this.restTextBox.TabIndex = 1;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(32, 149);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 2;
            countLabel.Text = "Count:";
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesExistBindingSource, "count", true));
            this.countTextBox.Location = new System.Drawing.Point(75, 142);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(182, 20);
            this.countTextBox.TabIndex = 3;
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "Medicines";
            this.medicinesBindingSource.DataSource = this.pharmacyofcityDataSet;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pharmacesBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.medicinesBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(75, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pharmacy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Medication";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExistMedEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(restLabel);
            this.Controls.Add(this.restTextBox);
            this.Name = "ExistMedEdit";
            this.Text = "ExistMedEdit";
            this.Load += new System.EventHandler(this.ExistMedEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesExistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pharmacyofcityDataSet pharmacyofcityDataSet;
        private System.Windows.Forms.BindingSource therapyBindingSource;
        private pharmacyofcityDataSetTableAdapters.TherapyTableAdapter therapyTableAdapter;
        private pharmacyofcityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private pharmacyofcityDataSetTableAdapters.MedicinesExistTableAdapter medicinesExistTableAdapter;
        private System.Windows.Forms.BindingSource medicinesExistBindingSource;
        private pharmacyofcityDataSetTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private pharmacyofcityDataSetTableAdapters.PharmacesTableAdapter pharmacesTableAdapter;
        private System.Windows.Forms.BindingSource pharmacesBindingSource;
        public System.Windows.Forms.TextBox restTextBox;
        public System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}