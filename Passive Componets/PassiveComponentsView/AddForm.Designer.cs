namespace PassiveComponentsView
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
            this.ElementComboBoxSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NominalLabel = new System.Windows.Forms.Label();
            this.NameElementTextBox = new System.Windows.Forms.TextBox();
            this.NominalTextBox = new System.Windows.Forms.TextBox();
            this.SelectElement = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ElementComboBoxSelect
            // 
            this.ElementComboBoxSelect.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ElementComboBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementComboBoxSelect.Items.AddRange(new object[] {
            "Резистор",
            "Конденсатор",
            "Катушка индуктивности"});
            this.ElementComboBoxSelect.Location = new System.Drawing.Point(5, 21);
            this.ElementComboBoxSelect.Name = "ElementComboBoxSelect";
            this.ElementComboBoxSelect.Size = new System.Drawing.Size(127, 21);
            this.ElementComboBoxSelect.TabIndex = 9;
            this.ElementComboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя:";
            // 
            // NominalLabel
            // 
            this.NominalLabel.AutoSize = true;
            this.NominalLabel.Location = new System.Drawing.Point(2, 45);
            this.NominalLabel.Name = "NominalLabel";
            this.NominalLabel.Size = new System.Drawing.Size(56, 13);
            this.NominalLabel.TabIndex = 7;
            this.NominalLabel.Text = "Номинал:";
            // 
            // NameElementTextBox
            // 
            this.NameElementTextBox.Location = new System.Drawing.Point(5, 100);
            this.NameElementTextBox.Name = "NameElementTextBox";
            this.NameElementTextBox.Size = new System.Drawing.Size(127, 20);
            this.NameElementTextBox.TabIndex = 6;
            this.NameElementTextBox.TextChanged += new System.EventHandler(this.NameElementTextBox_TextChanged);
            // 
            // NominalTextBox
            // 
            this.NominalTextBox.Location = new System.Drawing.Point(5, 61);
            this.NominalTextBox.Name = "NominalTextBox";
            this.NominalTextBox.Size = new System.Drawing.Size(53, 20);
            this.NominalTextBox.TabIndex = 5;
            this.NominalTextBox.TextChanged += new System.EventHandler(this.NominalTextBox_TextChanged);
            // 
            // SelectElement
            // 
            this.SelectElement.AutoSize = true;
            this.SelectElement.Location = new System.Drawing.Point(2, 5);
            this.SelectElement.Name = "SelectElement";
            this.SelectElement.Size = new System.Drawing.Size(81, 13);
            this.SelectElement.TabIndex = 2;
            this.SelectElement.Text = "Тип элемента:";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Location = new System.Drawing.Point(86, 126);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 21);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOK.Location = new System.Drawing.Point(5, 126);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 21);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "ОК";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 159);
            this.Controls.Add(this.NominalLabel);
            this.Controls.Add(this.ElementComboBoxSelect);
            this.Controls.Add(this.NominalTextBox);
            this.Controls.Add(this.SelectElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.NameElementTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SelectElement;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NominalLabel;
        private System.Windows.Forms.TextBox NameElementTextBox;
        private System.Windows.Forms.TextBox NominalTextBox;
        private System.Windows.Forms.ComboBox ElementComboBoxSelect;
    }
}