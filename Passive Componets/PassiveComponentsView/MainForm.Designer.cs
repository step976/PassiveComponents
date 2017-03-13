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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModifyElement = new System.Windows.Forms.Button();
            this.elementDataGridView = new System.Windows.Forms.DataGridView();
            this.NameElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impedance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveElement = new System.Windows.Forms.Button();
            this.AddElement = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).BeginInit();
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
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItemClick);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModifyElement);
            this.groupBox1.Controls.Add(this.elementDataGridView);
            this.groupBox1.Controls.Add(this.RemoveElement);
            this.groupBox1.Controls.Add(this.AddElement);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ModifyElement
            // 
            this.ModifyElement.Location = new System.Drawing.Point(106, 206);
            this.ModifyElement.Name = "ModifyElement";
            this.ModifyElement.Size = new System.Drawing.Size(75, 23);
            this.ModifyElement.TabIndex = 4;
            this.ModifyElement.Text = "Modify";
            this.ModifyElement.UseVisualStyleBackColor = true;
            // 
            // elementDataGridView
            // 
            this.elementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameElement,
            this.Nominal,
            this.Impedance});
            this.elementDataGridView.Location = new System.Drawing.Point(6, 10);
            this.elementDataGridView.Name = "elementDataGridView";
            this.elementDataGridView.Size = new System.Drawing.Size(452, 150);
            this.elementDataGridView.TabIndex = 3;
            // 
            // NameElement
            // 
            this.NameElement.HeaderText = "Name Element";
            this.NameElement.Name = "NameElement";
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.Name = "Nominal";
            // 
            // Impedance
            // 
            this.Impedance.HeaderText = "Impedance";
            this.Impedance.Name = "Impedance";
            // 
            // RemoveElement
            // 
            this.RemoveElement.Location = new System.Drawing.Point(223, 206);
            this.RemoveElement.Name = "RemoveElement";
            this.RemoveElement.Size = new System.Drawing.Size(75, 23);
            this.RemoveElement.TabIndex = 2;
            this.RemoveElement.Text = "Remove";
            this.RemoveElement.UseVisualStyleBackColor = true;
            // 
            // AddElement
            // 
            this.AddElement.Location = new System.Drawing.Point(6, 206);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(75, 23);
            this.AddElement.TabIndex = 1;
            this.AddElement.Text = "Add";
            this.AddElement.UseVisualStyleBackColor = true;
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
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
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveElement;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.DataGridView elementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impedance;
        private System.Windows.Forms.Button ModifyElement;
    }
}

