namespace Guiuiui.WinForms.TestApplication.Windows
{
    partial class MainWindow
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
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.personGroupBox = new System.Windows.Forms.GroupBox();
            this.personLayout = new System.Windows.Forms.TableLayoutPanel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.isVegetarianLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.isVegetarianCheckBox = new System.Windows.Forms.CheckBox();
            this.fullNameOutputLabel = new System.Windows.Forms.Label();
            this.ageOutputLabel = new System.Windows.Forms.Label();
            this.layout.SuspendLayout();
            this.personGroupBox.SuspendLayout();
            this.personLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 3;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.Controls.Add(this.personGroupBox, 1, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.Size = new System.Drawing.Size(800, 450);
            this.layout.TabIndex = 0;
            // 
            // personGroupBox
            // 
            this.personGroupBox.Controls.Add(this.personLayout);
            this.personGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personGroupBox.Location = new System.Drawing.Point(23, 23);
            this.personGroupBox.Name = "personGroupBox";
            this.personGroupBox.Size = new System.Drawing.Size(754, 404);
            this.personGroupBox.TabIndex = 0;
            this.personGroupBox.TabStop = false;
            this.personGroupBox.Text = "Person";
            // 
            // personLayout
            // 
            this.personLayout.ColumnCount = 4;
            this.personLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.personLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.personLayout.Controls.Add(this.firstNameLabel, 1, 1);
            this.personLayout.Controls.Add(this.lastNameLabel, 1, 2);
            this.personLayout.Controls.Add(this.genderLabel, 1, 3);
            this.personLayout.Controls.Add(this.dateOfBirthLabel, 1, 4);
            this.personLayout.Controls.Add(this.isVegetarianLabel, 1, 5);
            this.personLayout.Controls.Add(this.fullNameLabel, 1, 6);
            this.personLayout.Controls.Add(this.ageLabel, 1, 7);
            this.personLayout.Controls.Add(this.firstNameTextBox, 2, 1);
            this.personLayout.Controls.Add(this.lastNameTextBox, 2, 2);
            this.personLayout.Controls.Add(this.dateOfBirthPicker, 2, 4);
            this.personLayout.Controls.Add(this.genderComboBox, 2, 3);
            this.personLayout.Controls.Add(this.isVegetarianCheckBox, 2, 5);
            this.personLayout.Controls.Add(this.fullNameOutputLabel, 2, 6);
            this.personLayout.Controls.Add(this.ageOutputLabel, 2, 7);
            this.personLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personLayout.Location = new System.Drawing.Point(3, 19);
            this.personLayout.Name = "personLayout";
            this.personLayout.RowCount = 11;
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.personLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.personLayout.Size = new System.Drawing.Size(748, 382);
            this.personLayout.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(23, 27);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(348, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(23, 57);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(348, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(23, 87);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(348, 15);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(23, 117);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(348, 15);
            this.dateOfBirthLabel.TabIndex = 3;
            this.dateOfBirthLabel.Text = "Date of Birth";
            // 
            // isVegetarianLabel
            // 
            this.isVegetarianLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.isVegetarianLabel.AutoSize = true;
            this.isVegetarianLabel.Location = new System.Drawing.Point(23, 147);
            this.isVegetarianLabel.Name = "isVegetarianLabel";
            this.isVegetarianLabel.Size = new System.Drawing.Size(348, 15);
            this.isVegetarianLabel.TabIndex = 4;
            this.isVegetarianLabel.Text = "Is Vegetarian?";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(23, 177);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(348, 15);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "Full Name";
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(23, 207);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(348, 15);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.Location = new System.Drawing.Point(377, 23);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(348, 23);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Location = new System.Drawing.Point(377, 53);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(348, 23);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfBirthPicker.Location = new System.Drawing.Point(377, 113);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(348, 23);
            this.dateOfBirthPicker.TabIndex = 9;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(377, 83);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(348, 23);
            this.genderComboBox.TabIndex = 10;
            // 
            // isVegetarianCheckBox
            // 
            this.isVegetarianCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.isVegetarianCheckBox.AutoSize = true;
            this.isVegetarianCheckBox.Location = new System.Drawing.Point(377, 148);
            this.isVegetarianCheckBox.Name = "isVegetarianCheckBox";
            this.isVegetarianCheckBox.Size = new System.Drawing.Size(348, 14);
            this.isVegetarianCheckBox.TabIndex = 11;
            this.isVegetarianCheckBox.UseVisualStyleBackColor = true;
            // 
            // fullNameOutputLabel
            // 
            this.fullNameOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameOutputLabel.AutoSize = true;
            this.fullNameOutputLabel.Location = new System.Drawing.Point(377, 177);
            this.fullNameOutputLabel.Name = "fullNameOutputLabel";
            this.fullNameOutputLabel.Size = new System.Drawing.Size(348, 15);
            this.fullNameOutputLabel.TabIndex = 12;
            this.fullNameOutputLabel.Text = "label1";
            // 
            // ageOutputLabel
            // 
            this.ageOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ageOutputLabel.AutoSize = true;
            this.ageOutputLabel.Location = new System.Drawing.Point(377, 207);
            this.ageOutputLabel.Name = "ageOutputLabel";
            this.ageOutputLabel.Size = new System.Drawing.Size(348, 15);
            this.ageOutputLabel.TabIndex = 13;
            this.ageOutputLabel.Text = "label2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layout);
            this.Name = "MainWindow";
            this.Text = "Person";
            this.layout.ResumeLayout(false);
            this.personGroupBox.ResumeLayout(false);
            this.personLayout.ResumeLayout(false);
            this.personLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.GroupBox personGroupBox;
        private System.Windows.Forms.TableLayoutPanel personLayout;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label isVegetarianLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.CheckBox isVegetarianCheckBox;
        private System.Windows.Forms.Label fullNameOutputLabel;
        private System.Windows.Forms.Label ageOutputLabel;
    }
}