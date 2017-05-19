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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AutoCreateButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Freq = new System.Windows.Forms.Label();
            this.AngularFreqTextBox = new System.Windows.Forms.TextBox();
            this.ModifyElementButton = new System.Windows.Forms.Button();
            this.ElementDataGridView = new System.Windows.Forms.DataGridView();
            this.NameElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impedance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveElementButton = new System.Windows.Forms.Button();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.CalculateGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElementDataGridView)).BeginInit();
            this.CalculateGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(5, 13);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 10;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(111, 11);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AutoCreateButton
            // 
            this.AutoCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoCreateButton.Location = new System.Drawing.Point(471, 327);
            this.AutoCreateButton.Name = "AutoCreateButton";
            this.AutoCreateButton.Size = new System.Drawing.Size(75, 36);
            this.AutoCreateButton.TabIndex = 8;
            this.AutoCreateButton.Text = "Рандомные элементы";
            this.AutoCreateButton.UseVisualStyleBackColor = true;
            this.AutoCreateButton.Click += new System.EventHandler(this.AutoCreateButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CalculateButton.Location = new System.Drawing.Point(128, 15);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Freq
            // 
            this.Freq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Freq.AutoSize = true;
            this.Freq.Location = new System.Drawing.Point(6, 2);
            this.Freq.Name = "Freq";
            this.Freq.Size = new System.Drawing.Size(113, 13);
            this.Freq.TabIndex = 6;
            this.Freq.Text = "Угловая частота, Гц:";
            // 
            // AngularFreqTextBox
            // 
            this.AngularFreqTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AngularFreqTextBox.Location = new System.Drawing.Point(9, 18);
            this.AngularFreqTextBox.Name = "AngularFreqTextBox";
            this.AngularFreqTextBox.Size = new System.Drawing.Size(113, 20);
            this.AngularFreqTextBox.TabIndex = 5;
            this.AngularFreqTextBox.Text = "10";
            // 
            // ModifyElementButton
            // 
            this.ModifyElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifyElementButton.Location = new System.Drawing.Point(93, 333);
            this.ModifyElementButton.Name = "ModifyElementButton";
            this.ModifyElementButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyElementButton.TabIndex = 4;
            this.ModifyElementButton.Text = "Изменить";
            this.ModifyElementButton.UseVisualStyleBackColor = true;
            this.ModifyElementButton.Click += new System.EventHandler(this.ModifyElement_Click);
            // 
            // ElementDataGridView
            // 
            this.ElementDataGridView.AllowUserToAddRows = false;
            this.ElementDataGridView.AllowUserToDeleteRows = false;
            this.ElementDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ElementDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ElementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameElement,
            this.Nominal,
            this.Impedance});
            this.ElementDataGridView.Location = new System.Drawing.Point(1, 27);
            this.ElementDataGridView.Name = "ElementDataGridView";
            this.ElementDataGridView.ReadOnly = true;
            this.ElementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ElementDataGridView.Size = new System.Drawing.Size(747, 288);
            this.ElementDataGridView.TabIndex = 3;
            // 
            // NameElement
            // 
            this.NameElement.DataPropertyName = "Name";
            this.NameElement.HeaderText = "Имя элемента";
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
            this.RemoveElementButton.Location = new System.Drawing.Point(174, 334);
            this.RemoveElementButton.Name = "RemoveElementButton";
            this.RemoveElementButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveElementButton.TabIndex = 2;
            this.RemoveElementButton.Text = "Удалить";
            this.RemoveElementButton.UseVisualStyleBackColor = true;
            this.RemoveElementButton.Click += new System.EventHandler(this.RemoveElement_Click);
            // 
            // AddElementButton
            // 
            this.AddElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddElementButton.Location = new System.Drawing.Point(12, 333);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(75, 23);
            this.AddElementButton.TabIndex = 1;
            this.AddElementButton.Text = "Добавить";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // CalculateGroupBox
            // 
            this.CalculateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CalculateGroupBox.Controls.Add(this.Freq);
            this.CalculateGroupBox.Controls.Add(this.AngularFreqTextBox);
            this.CalculateGroupBox.Controls.Add(this.CalculateButton);
            this.CalculateGroupBox.Location = new System.Drawing.Point(255, 318);
            this.CalculateGroupBox.Name = "CalculateGroupBox";
            this.CalculateGroupBox.Size = new System.Drawing.Size(210, 44);
            this.CalculateGroupBox.TabIndex = 11;
            this.CalculateGroupBox.TabStop = false;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Location = new System.Drawing.Point(552, 323);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(192, 40);
            this.SearchGroupBox.TabIndex = 12;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Поиск";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 369);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.CalculateGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.AutoCreateButton);
            this.Controls.Add(this.ElementDataGridView);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.ModifyElementButton);
            this.Controls.Add(this.RemoveElementButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Passive Components  - Spengle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElementDataGridView)).EndInit();
            this.CalculateGroupBox.ResumeLayout(false);
            this.CalculateGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button RemoveElementButton;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.DataGridView ElementDataGridView;
        private System.Windows.Forms.Button ModifyElementButton;
        private System.Windows.Forms.Label Freq;
        private System.Windows.Forms.TextBox AngularFreqTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.Button AutoCreateButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.GroupBox CalculateGroupBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impedance;
    }
}

