namespace AppPharmacesOfCity
{
    partial class TherapyEdit
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
            System.Windows.Forms.Label disease_nameLabel;
            System.Windows.Forms.Label dosageLabel;
            this.pharmacyofcityDataSet = new AppPharmacesOfCity.pharmacyofcityDataSet();
            this.therapyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.therapyTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TherapyTableAdapter();
            this.tableAdapterManager = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager();
            this.disease_nameTextBox = new System.Windows.Forms.TextBox();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.MedicinesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            disease_nameLabel = new System.Windows.Forms.Label();
            dosageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
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
            this.tableAdapterManager.MedicinesExistTableAdapter = null;
            this.tableAdapterManager.MedicinesTableAdapter = this.medicinesTableAdapter;
            this.tableAdapterManager.PharmacesTableAdapter = null;
            this.tableAdapterManager.TherapyTableAdapter = this.therapyTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // disease_nameLabel
            // 
            disease_nameLabel.AutoSize = true;
            disease_nameLabel.Location = new System.Drawing.Point(12, 71);
            disease_nameLabel.Name = "disease_nameLabel";
            disease_nameLabel.Size = new System.Drawing.Size(77, 13);
            disease_nameLabel.TabIndex = 1;
            disease_nameLabel.Text = "Disease name:";
            // 
            // disease_nameTextBox
            // 
            this.disease_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.therapyBindingSource, "disease_name", true));
            this.disease_nameTextBox.Location = new System.Drawing.Point(95, 68);
            this.disease_nameTextBox.Name = "disease_nameTextBox";
            this.disease_nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.disease_nameTextBox.TabIndex = 2;
            // 
            // dosageLabel
            // 
            dosageLabel.AutoSize = true;
            dosageLabel.Location = new System.Drawing.Point(42, 109);
            dosageLabel.Name = "dosageLabel";
            dosageLabel.Size = new System.Drawing.Size(47, 13);
            dosageLabel.TabIndex = 2;
            dosageLabel.Text = "Dosage:";
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.therapyBindingSource, "dosage", true));
            this.dosageTextBox.Location = new System.Drawing.Point(95, 106);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(154, 20);
            this.dosageTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.medicinesBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medication:";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TherapyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(dosageLabel);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(disease_nameLabel);
            this.Controls.Add(this.disease_nameTextBox);
            this.Name = "TherapyEdit";
            this.Text = "TherapyEdit";
            this.Load += new System.EventHandler(this.TherapyEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.therapyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pharmacyofcityDataSet pharmacyofcityDataSet;
        private System.Windows.Forms.BindingSource therapyBindingSource;
        private pharmacyofcityDataSetTableAdapters.TherapyTableAdapter therapyTableAdapter;
        private pharmacyofcityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox disease_nameTextBox;
        private pharmacyofcityDataSetTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        public System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}