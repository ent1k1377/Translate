namespace Translate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.caption = new System.Windows.Forms.Label();
            this.textField1 = new System.Windows.Forms.RichTextBox();
            this.switchLanguage = new System.Windows.Forms.ComboBox();
            this.textField2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Перевести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption.Location = new System.Drawing.Point(12, 9);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(386, 72);
            this.caption.TabIndex = 1;
            this.caption.Text = "Переводчик";
            // 
            // textField1
            // 
            this.textField1.Location = new System.Drawing.Point(24, 99);
            this.textField1.Name = "textField1";
            this.textField1.Size = new System.Drawing.Size(374, 114);
            this.textField1.TabIndex = 2;
            this.textField1.Text = "";
            // 
            // switchLanguage
            // 
            this.switchLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.switchLanguage.FormattingEnabled = true;
            this.switchLanguage.Items.AddRange(new object[] {
            "Английский",
            "Русский"});
            this.switchLanguage.Location = new System.Drawing.Point(188, 230);
            this.switchLanguage.Name = "switchLanguage";
            this.switchLanguage.Size = new System.Drawing.Size(107, 21);
            this.switchLanguage.TabIndex = 4;
            this.switchLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textField2
            // 
            this.textField2.AcceptsTab = true;
            this.textField2.Location = new System.Drawing.Point(24, 306);
            this.textField2.Name = "textField2";
            this.textField2.ReadOnly = true;
            this.textField2.Size = new System.Drawing.Size(374, 125);
            this.textField2.TabIndex = 5;
            this.textField2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Перевод на";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сохранить в файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Сохранить данные";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textField2);
            this.Controls.Add(this.switchLanguage);
            this.Controls.Add(this.textField1);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Переводчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.RichTextBox textField1;
        private System.Windows.Forms.ComboBox switchLanguage;
        private System.Windows.Forms.RichTextBox textField2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
    }
}

