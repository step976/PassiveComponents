﻿namespace PassiveComponentsView
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ElementComboBoxSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameElementTextBox = new System.Windows.Forms.TextBox();
            this.NominalTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SelectElement = new System.Windows.Forms.Label();
            this.iElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resistorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ElementComboBoxSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameElementTextBox);
            this.groupBox1.Controls.Add(this.NominalTextBox);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonOK);
            this.groupBox1.Controls.Add(this.SelectElement);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ElementComboBoxSelect
            // 
            this.ElementComboBoxSelect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ElementComboBoxSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.ElementComboBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementComboBoxSelect.Items.AddRange(new object[] {
            "Резистор",
            "Конденсатор",
            "Катушка индуктивности"});
            this.ElementComboBoxSelect.Location = new System.Drawing.Point(3, 29);
            this.ElementComboBoxSelect.Name = "ElementComboBoxSelect";
            this.ElementComboBoxSelect.Size = new System.Drawing.Size(158, 21);
            this.ElementComboBoxSelect.TabIndex = 9;
            this.ElementComboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите уникальное имя для элемента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите его номинал";
            // 
            // NameElementTextBox
            // 
            this.NameElementTextBox.Location = new System.Drawing.Point(0, 147);
            this.NameElementTextBox.Name = "NameElementTextBox";
            this.NameElementTextBox.Size = new System.Drawing.Size(158, 20);
            this.NameElementTextBox.TabIndex = 6;
            // 
            // NominalTextBox
            // 
            this.NominalTextBox.Location = new System.Drawing.Point(3, 84);
            this.NominalTextBox.Name = "NominalTextBox";
            this.NominalTextBox.Size = new System.Drawing.Size(158, 20);
            this.NominalTextBox.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(178, 284);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Location = new System.Drawing.Point(15, 283);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // SelectElement
            // 
            this.SelectElement.AutoSize = true;
            this.SelectElement.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectElement.Location = new System.Drawing.Point(3, 16);
            this.SelectElement.Name = "SelectElement";
            this.SelectElement.Size = new System.Drawing.Size(103, 13);
            this.SelectElement.TabIndex = 2;
            this.SelectElement.Text = "Выберите элемент";
            // 
            // iElementBindingSource
            // 
            this.iElementBindingSource.DataSource = typeof(Passive_Componets.IElement);
            // 
            // resistorBindingSource
            // 
            this.resistorBindingSource.DataSource = typeof(Passive_Componets.Resistor);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "Добавить элемент";
            this.Load += new System.EventHandler(this.AddFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resistorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SelectElement;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameElementTextBox;
        private System.Windows.Forms.TextBox NominalTextBox;
        private System.Windows.Forms.BindingSource iElementBindingSource;
        private System.Windows.Forms.BindingSource resistorBindingSource;
        private System.Windows.Forms.ComboBox ElementComboBoxSelect;
    }
}