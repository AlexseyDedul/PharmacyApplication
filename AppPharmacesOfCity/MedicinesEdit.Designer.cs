namespace AppPharmacesOfCity
{
    partial class MedicinesEdit
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
            System.Windows.Forms.Label producing_countryLabel;
            System.Windows.Forms.Label date_of_manufactureLabel;
            System.Windows.Forms.Label form_of_issueLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label expiration_dateLabel;
            System.Windows.Forms.Label priceLabel;
            this.pharmacyofcityDataSet = new AppPharmacesOfCity.pharmacyofcityDataSet();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesTableAdapter = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.MedicinesTableAdapter();
            this.tableAdapterManager = new AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.producing_countryTextBox = new System.Windows.Forms.TextBox();
            this.date_of_manufactureTextBox = new System.Windows.Forms.TextBox();
            this.form_of_issueTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.expiration_dateTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            producing_countryLabel = new System.Windows.Forms.Label();
            date_of_manufactureLabel = new System.Windows.Forms.Label();
            form_of_issueLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            expiration_dateLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(72, 27);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // producing_countryLabel
            // 
            producing_countryLabel.AutoSize = true;
            producing_countryLabel.Location = new System.Drawing.Point(13, 56);
            producing_countryLabel.Name = "producing_countryLabel";
            producing_countryLabel.Size = new System.Drawing.Size(96, 13);
            producing_countryLabel.TabIndex = 2;
            producing_countryLabel.Text = "Producing country:";
            // 
            // pharmacyofcityDataSet
            // 
            this.pharmacyofcityDataSet.DataSetName = "pharmacyofcityDataSet";
            this.pharmacyofcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MedicinesExistTableAdapter = null;
            this.tableAdapterManager.MedicinesTableAdapter = this.medicinesTableAdapter;
            this.tableAdapterManager.PharmacesTableAdapter = null;
            this.tableAdapterManager.TherapyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppPharmacesOfCity.pharmacyofcityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(114, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // producing_countryTextBox
            // 
            this.producing_countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "producing_country", true));
            this.producing_countryTextBox.Location = new System.Drawing.Point(114, 53);
            this.producing_countryTextBox.Name = "producing_countryTextBox";
            this.producing_countryTextBox.Size = new System.Drawing.Size(196, 20);
            this.producing_countryTextBox.TabIndex = 3;
            // 
            // date_of_manufactureLabel
            // 
            date_of_manufactureLabel.AutoSize = true;
            date_of_manufactureLabel.Location = new System.Drawing.Point(3, 82);
            date_of_manufactureLabel.Name = "date_of_manufactureLabel";
            date_of_manufactureLabel.Size = new System.Drawing.Size(107, 13);
            date_of_manufactureLabel.TabIndex = 4;
            date_of_manufactureLabel.Text = "Date of manufacture:";
            // 
            // date_of_manufactureTextBox
            // 
            this.date_of_manufactureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "date_of_manufacture", true));
            this.date_of_manufactureTextBox.Location = new System.Drawing.Point(114, 79);
            this.date_of_manufactureTextBox.Name = "date_of_manufactureTextBox";
            this.date_of_manufactureTextBox.Size = new System.Drawing.Size(196, 20);
            this.date_of_manufactureTextBox.TabIndex = 5;
            // 
            // form_of_issueLabel
            // 
            form_of_issueLabel.AutoSize = true;
            form_of_issueLabel.Location = new System.Drawing.Point(39, 108);
            form_of_issueLabel.Name = "form_of_issueLabel";
            form_of_issueLabel.Size = new System.Drawing.Size(72, 13);
            form_of_issueLabel.TabIndex = 6;
            form_of_issueLabel.Text = "Form of issue:";
            // 
            // form_of_issueTextBox
            // 
            this.form_of_issueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "form_of_issue", true));
            this.form_of_issueTextBox.Location = new System.Drawing.Point(114, 105);
            this.form_of_issueTextBox.Name = "form_of_issueTextBox";
            this.form_of_issueTextBox.Size = new System.Drawing.Size(196, 20);
            this.form_of_issueTextBox.TabIndex = 7;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(71, 134);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 8;
            countLabel.Text = "Count:";
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "count", true));
            this.countTextBox.Location = new System.Drawing.Point(114, 131);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(196, 20);
            this.countTextBox.TabIndex = 9;
            // 
            // expiration_dateLabel
            // 
            expiration_dateLabel.AutoSize = true;
            expiration_dateLabel.Location = new System.Drawing.Point(29, 160);
            expiration_dateLabel.Name = "expiration_dateLabel";
            expiration_dateLabel.Size = new System.Drawing.Size(80, 13);
            expiration_dateLabel.TabIndex = 10;
            expiration_dateLabel.Text = "Expiration date:";
            // 
            // expiration_dateTextBox
            // 
            this.expiration_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "expiration_date", true));
            this.expiration_dateTextBox.Location = new System.Drawing.Point(114, 157);
            this.expiration_dateTextBox.Name = "expiration_dateTextBox";
            this.expiration_dateTextBox.Size = new System.Drawing.Size(196, 20);
            this.expiration_dateTextBox.TabIndex = 11;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(75, 186);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 12;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(114, 183);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(196, 20);
            this.priceTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MedicinesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(expiration_dateLabel);
            this.Controls.Add(this.expiration_dateTextBox);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(form_of_issueLabel);
            this.Controls.Add(this.form_of_issueTextBox);
            this.Controls.Add(date_of_manufactureLabel);
            this.Controls.Add(this.date_of_manufactureTextBox);
            this.Controls.Add(producing_countryLabel);
            this.Controls.Add(this.producing_countryTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "MedicinesEdit";
            this.Text = "MedicinesEdit";
            this.Load += new System.EventHandler(this.MedicinesEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyofcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pharmacyofcityDataSet pharmacyofcityDataSet;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private pharmacyofcityDataSetTableAdapters.MedicinesTableAdapter medicinesTableAdapter;
        private pharmacyofcityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox date_of_manufactureTextBox;
        public System.Windows.Forms.TextBox form_of_issueTextBox;
        public System.Windows.Forms.TextBox countTextBox;
        public System.Windows.Forms.TextBox expiration_dateTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox producing_countryTextBox;
    }
}