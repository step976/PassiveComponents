namespace PassiveComponentsView
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AngularFreqTextBox = new System.Windows.Forms.TextBox();
            this.ModifyElementButton = new System.Windows.Forms.Button();
            this.elementDataGridView = new System.Windows.Forms.DataGridView();
            this.NameElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impedance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveElementButton = new System.Windows.Forms.Button();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.iElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impedanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iElementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.HelpToolStripMenuItem.Text = "Попощь";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CalculateButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AngularFreqTextBox);
            this.groupBox1.Controls.Add(this.ModifyElementButton);
            this.groupBox1.Controls.Add(this.elementDataGridView);
            this.groupBox1.Controls.Add(this.RemoveElementButton);
            this.groupBox1.Controls.Add(this.AddElementButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CalculateButton.Location = new System.Drawing.Point(414, 203);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Угловая частота";
            // 
            // AngularFreqTextBox
            // 
            this.AngularFreqTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngularFreqTextBox.Location = new System.Drawing.Point(298, 206);
            this.AngularFreqTextBox.Name = "AngularFreqTextBox";
            this.AngularFreqTextBox.Size = new System.Drawing.Size(100, 20);
            this.AngularFreqTextBox.TabIndex = 5;
            // 
            // ModifyElementButton
            // 
            this.ModifyElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifyElementButton.Location = new System.Drawing.Point(106, 190);
            this.ModifyElementButton.Name = "ModifyElementButton";
            this.ModifyElementButton.Size = new System.Drawing.Size(75, 39);
            this.ModifyElementButton.TabIndex = 4;
            this.ModifyElementButton.Text = "Изменить элемент";
            this.ModifyElementButton.UseVisualStyleBackColor = true;
            this.ModifyElementButton.Click += new System.EventHandler(this.ModifyElement_Click);
            // 
            // elementDataGridView
            // 
            this.elementDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementDataGridView.AutoGenerateColumns = false;
            this.elementDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.elementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameElement,
            this.Nominal,
            this.Impedance,
            this.valueDataGridViewTextBoxColumn,
            this.uniqueNameDataGridViewTextBoxColumn,
            this.impedanceDataGridViewTextBoxColumn,
            this.freqDataGridViewTextBoxColumn});
            this.elementDataGridView.DataSource = this.iElementBindingSource;
            this.elementDataGridView.Location = new System.Drawing.Point(12, 19);
            this.elementDataGridView.Name = "elementDataGridView";
            this.elementDataGridView.ReadOnly = true;
            this.elementDataGridView.Size = new System.Drawing.Size(742, 129);
            this.elementDataGridView.TabIndex = 3;
            // 
            // NameElement
            // 
            this.NameElement.HeaderText = "Элемент";
            this.NameElement.Name = "NameElement";
            this.NameElement.ReadOnly = true;
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Номинал";
            this.Nominal.Name = "Nominal";
            this.Nominal.ReadOnly = true;
            // 
            // Impedance
            // 
            this.Impedance.HeaderText = "Комплексное сопротивление";
            this.Impedance.Name = "Impedance";
            this.Impedance.ReadOnly = true;
            // 
            // RemoveElementButton
            // 
            this.RemoveElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveElementButton.Location = new System.Drawing.Point(197, 190);
            this.RemoveElementButton.Name = "RemoveElementButton";
            this.RemoveElementButton.Size = new System.Drawing.Size(75, 39);
            this.RemoveElementButton.TabIndex = 2;
            this.RemoveElementButton.Text = "Удалить элемент";
            this.RemoveElementButton.UseVisualStyleBackColor = true;
            this.RemoveElementButton.Click += new System.EventHandler(this.RemoveElement_Click);
            // 
            // AddElementButton
            // 
            this.AddElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddElementButton.Location = new System.Drawing.Point(6, 190);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(75, 39);
            this.AddElementButton.TabIndex = 1;
            this.AddElementButton.Text = "Добавить элемент";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // iElementBindingSource
            // 
            this.iElementBindingSource.DataSource = typeof(Passive_Componets.IElement);
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniqueNameDataGridViewTextBoxColumn
            // 
            this.uniqueNameDataGridViewTextBoxColumn.DataPropertyName = "UniqueName";
            this.uniqueNameDataGridViewTextBoxColumn.HeaderText = "UniqueName";
            this.uniqueNameDataGridViewTextBoxColumn.Name = "uniqueNameDataGridViewTextBoxColumn";
            this.uniqueNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // impedanceDataGridViewTextBoxColumn
            // 
            this.impedanceDataGridViewTextBoxColumn.DataPropertyName = "Impedance";
            this.impedanceDataGridViewTextBoxColumn.HeaderText = "Impedance";
            this.impedanceDataGridViewTextBoxColumn.Name = "impedanceDataGridViewTextBoxColumn";
            this.impedanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freqDataGridViewTextBoxColumn
            // 
            this.freqDataGridViewTextBoxColumn.DataPropertyName = "Freq";
            this.freqDataGridViewTextBoxColumn.HeaderText = "Freq";
            this.freqDataGridViewTextBoxColumn.Name = "freqDataGridViewTextBoxColumn";
            this.freqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iElementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveElementButton;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.DataGridView elementDataGridView;
        private System.Windows.Forms.Button ModifyElementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AngularFreqTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impedance;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impedanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freqDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iElementBindingSource;
    }
}

