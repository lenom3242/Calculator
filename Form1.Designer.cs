
namespace WindowsFormsApp2
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
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Plus_button = new System.Windows.Forms.Button();
            this.Minus_button = new System.Windows.Forms.Button();
            this.Mul_button = new System.Windows.Forms.Button();
            this.Div_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(35, 70);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(125, 20);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Click += new System.EventHandler(this.FirstNumber_Click);
            this.FirstNumber.TextChanged += new System.EventHandler(this.FirstNumber_TextChanged);
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(309, 70);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(125, 20);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Click += new System.EventHandler(this.SecondNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первое число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(306, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Второе число";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(178, 172);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(141, 20);
            this.Result.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(194, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // Plus_button
            // 
            this.Plus_button.Location = new System.Drawing.Point(198, 48);
            this.Plus_button.Name = "Plus_button";
            this.Plus_button.Size = new System.Drawing.Size(34, 23);
            this.Plus_button.TabIndex = 6;
            this.Plus_button.Text = "+";
            this.Plus_button.UseVisualStyleBackColor = true;
            this.Plus_button.Click += new System.EventHandler(this.Plus_button_Click);
            // 
            // Minus_button
            // 
            this.Minus_button.Location = new System.Drawing.Point(250, 48);
            this.Minus_button.Name = "Minus_button";
            this.Minus_button.Size = new System.Drawing.Size(34, 23);
            this.Minus_button.TabIndex = 7;
            this.Minus_button.Text = "-";
            this.Minus_button.UseVisualStyleBackColor = true;
            this.Minus_button.Click += new System.EventHandler(this.Minus_button_Click);
            // 
            // Mul_button
            // 
            this.Mul_button.Location = new System.Drawing.Point(198, 89);
            this.Mul_button.Name = "Mul_button";
            this.Mul_button.Size = new System.Drawing.Size(34, 23);
            this.Mul_button.TabIndex = 8;
            this.Mul_button.Text = "*";
            this.Mul_button.UseVisualStyleBackColor = true;
            this.Mul_button.Click += new System.EventHandler(this.Mul_button_Click);
            // 
            // Div_button
            // 
            this.Div_button.Location = new System.Drawing.Point(250, 89);
            this.Div_button.Name = "Div_button";
            this.Div_button.Size = new System.Drawing.Size(34, 23);
            this.Div_button.TabIndex = 9;
            this.Div_button.Text = "/";
            this.Div_button.UseVisualStyleBackColor = true;
            this.Div_button.Click += new System.EventHandler(this.Div_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_clear);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Div_button);
            this.Controls.Add(this.Mul_button);
            this.Controls.Add(this.Minus_button);
            this.Controls.Add(this.Plus_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Plus_button;
        private System.Windows.Forms.Button Minus_button;
        private System.Windows.Forms.Button Mul_button;
        private System.Windows.Forms.Button Div_button;
        private System.Windows.Forms.Button button1;
    }
}

