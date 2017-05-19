namespace PassiveComponentsView.Controls
{
    partial class ElementsControl
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
            this.ElementsComboBox = new System.Windows.Forms.ComboBox();
            this.capacitorControl = new PassiveComponentsView.Controls.CapacitorControl();
            this.inductorControl = new PassiveComponentsView.Controls.InductorControl();
            this.resistorControl = new PassiveComponentsView.Controls.ResistorControl();
            this.SuspendLayout();
            // 
            // ElementsComboBox
            // 
            this.ElementsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementsComboBox.FormattingEnabled = true;
            this.ElementsComboBox.Location = new System.Drawing.Point(3, 3);
            this.ElementsComboBox.Name = "ElementsComboBox";
            this.ElementsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ElementsComboBox.TabIndex = 0;
            this.ElementsComboBox.SelectedIndexChanged += new System.EventHandler(this.ElementsComboBox_SelectedIndexChanged);
            // 
            // capacitorControl
            // 
            this.capacitorControl.Location = new System.Drawing.Point(3, 30);
            this.capacitorControl.Name = "capacitorControl";
            this.capacitorControl.Size = new System.Drawing.Size(182, 90);
            this.capacitorControl.TabIndex = 1;
            // 
            // inductorControl
            // 
            this.inductorControl.Location = new System.Drawing.Point(3, 30);
            this.inductorControl.Name = "inductorControl";
            this.inductorControl.Size = new System.Drawing.Size(182, 90);
            this.inductorControl.TabIndex = 2;
            // 
            // resistorControl
            // 
            this.resistorControl.Location = new System.Drawing.Point(3, 30);
            this.resistorControl.Name = "resistorControl";
            this.resistorControl.Size = new System.Drawing.Size(182, 90);
            this.resistorControl.TabIndex = 3;
            // 
            // ElementsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resistorControl);
            this.Controls.Add(this.inductorControl);
            this.Controls.Add(this.capacitorControl);
            this.Controls.Add(this.ElementsComboBox);
            this.Name = "ElementsControl";
            this.Size = new System.Drawing.Size(202, 137);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ElementsComboBox;
        private CapacitorControl capacitorControl;
        private InductorControl inductorControl;
        private ResistorControl resistorControl;
    }
}
