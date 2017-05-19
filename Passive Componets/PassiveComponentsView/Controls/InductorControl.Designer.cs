namespace PassiveComponentsView.Controls
{
    partial class InductorControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInductance = new System.Windows.Forms.TextBox();
            this.textBoxNameInductor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индуктивность, Гн:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя для катушки индуктивности:";
            // 
            // textBoxInductance
            // 
            this.textBoxInductance.Location = new System.Drawing.Point(3, 16);
            this.textBoxInductance.Name = "textBoxInductance";
            this.textBoxInductance.Size = new System.Drawing.Size(105, 20);
            this.textBoxInductance.TabIndex = 2;
            // 
            // textBoxNameInductor
            // 
            this.textBoxNameInductor.Location = new System.Drawing.Point(3, 61);
            this.textBoxNameInductor.Name = "textBoxNameInductor";
            this.textBoxNameInductor.Size = new System.Drawing.Size(173, 20);
            this.textBoxNameInductor.TabIndex = 3;
            // 
            // InductorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxNameInductor);
            this.Controls.Add(this.textBoxInductance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InductorControl";
            this.Size = new System.Drawing.Size(182, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInductance;
        private System.Windows.Forms.TextBox textBoxNameInductor;
    }
}
