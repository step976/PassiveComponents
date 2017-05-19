namespace PassiveComponentsView.Controls
{
    partial class CapacitorControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCapacitance = new System.Windows.Forms.TextBox();
            this.textBoxNameCapacitor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Емкость, Ф:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя для конденсатора:";
            // 
            // textBoxCapacitance
            // 
            this.textBoxCapacitance.Location = new System.Drawing.Point(6, 16);
            this.textBoxCapacitance.Name = "textBoxCapacitance";
            this.textBoxCapacitance.Size = new System.Drawing.Size(124, 20);
            this.textBoxCapacitance.TabIndex = 2;
            // 
            // textBoxNameCapacitor
            // 
            this.textBoxNameCapacitor.Location = new System.Drawing.Point(6, 68);
            this.textBoxNameCapacitor.Name = "textBoxNameCapacitor";
            this.textBoxNameCapacitor.Size = new System.Drawing.Size(124, 20);
            this.textBoxNameCapacitor.TabIndex = 3;
            // 
            // CapacitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNameCapacitor);
            this.Controls.Add(this.textBoxCapacitance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CapacitorControl";
            this.Size = new System.Drawing.Size(182, 90);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxNameCapacitor;
        private System.Windows.Forms.TextBox textBoxCapacitance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
