
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
            this.components = new System.ComponentModel.Container();
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
            this.Sin_button = new System.Windows.Forms.Button();
            this.Cos_button = new System.Windows.Forms.Button();
            this.Sqrt_button = new System.Windows.Forms.Button();
            this.Sqr_button = new System.Windows.Forms.Button();
            this.Percent_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(16, 41);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(138, 20);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Click += new System.EventHandler(this.FirstNumber_Click);
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(16, 115);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(145, 20);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Click += new System.EventHandler(this.SecondNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Первый операнд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Второй операнд";
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Location = new System.Drawing.Point(13, 300);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(141, 29);
            this.Result.TabIndex = 4;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Plus_button
            // 
            this.Plus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus_button.Location = new System.Drawing.Point(17, 154);
            this.Plus_button.Name = "Plus_button";
            this.Plus_button.Size = new System.Drawing.Size(34, 35);
            this.Plus_button.TabIndex = 6;
            this.Plus_button.Text = "+";
            this.Plus_button.UseVisualStyleBackColor = true;
            this.Plus_button.Click += new System.EventHandler(this.Plus_button_Click);
            // 
            // Minus_button
            // 
            this.Minus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus_button.Location = new System.Drawing.Point(57, 154);
            this.Minus_button.Name = "Minus_button";
            this.Minus_button.Size = new System.Drawing.Size(34, 35);
            this.Minus_button.TabIndex = 7;
            this.Minus_button.Text = "-";
            this.Minus_button.UseVisualStyleBackColor = true;
            this.Minus_button.Click += new System.EventHandler(this.Minus_button_Click);
            // 
            // Mul_button
            // 
            this.Mul_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mul_button.Location = new System.Drawing.Point(17, 195);
            this.Mul_button.Name = "Mul_button";
            this.Mul_button.Size = new System.Drawing.Size(34, 35);
            this.Mul_button.TabIndex = 8;
            this.Mul_button.Text = "*";
            this.Mul_button.UseVisualStyleBackColor = true;
            this.Mul_button.Click += new System.EventHandler(this.Mul_button_Click);
            // 
            // Div_button
            // 
            this.Div_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Div_button.Location = new System.Drawing.Point(57, 195);
            this.Div_button.Name = "Div_button";
            this.Div_button.Size = new System.Drawing.Size(34, 35);
            this.Div_button.TabIndex = 9;
            this.Div_button.Text = "/";
            this.Div_button.UseVisualStyleBackColor = true;
            this.Div_button.Click += new System.EventHandler(this.Div_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(34, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Очистить";
            this.toolTip1.SetToolTip(this.button1, "Очистить поля ввода");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_clear);
            // 
            // Sin_button
            // 
            this.Sin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sin_button.Location = new System.Drawing.Point(97, 154);
            this.Sin_button.Name = "Sin_button";
            this.Sin_button.Size = new System.Drawing.Size(34, 35);
            this.Sin_button.TabIndex = 11;
            this.Sin_button.Text = "Sin";
            this.toolTip1.SetToolTip(this.Sin_button, "Вычисление синуса первого операнда");
            this.Sin_button.UseVisualStyleBackColor = true;
            this.Sin_button.Click += new System.EventHandler(this.Sin_button_Click);
            // 
            // Cos_button
            // 
            this.Cos_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cos_button.Location = new System.Drawing.Point(97, 195);
            this.Cos_button.Name = "Cos_button";
            this.Cos_button.Size = new System.Drawing.Size(34, 34);
            this.Cos_button.TabIndex = 12;
            this.Cos_button.Text = "Cos";
            this.toolTip1.SetToolTip(this.Cos_button, "Вычисление косинуса первого операнда");
            this.Cos_button.UseVisualStyleBackColor = true;
            this.Cos_button.Click += new System.EventHandler(this.Cos_button_Click);
            // 
            // Sqrt_button
            // 
            this.Sqrt_button.Location = new System.Drawing.Point(137, 196);
            this.Sqrt_button.Name = "Sqrt_button";
            this.Sqrt_button.Size = new System.Drawing.Size(35, 34);
            this.Sqrt_button.TabIndex = 13;
            this.Sqrt_button.Text = "✓";
            this.toolTip1.SetToolTip(this.Sqrt_button, "Вычисление квадратного корня первого операнда");
            this.Sqrt_button.UseVisualStyleBackColor = true;
            this.Sqrt_button.Click += new System.EventHandler(this.Sqrt_button_Click);
            // 
            // Sqr_button
            // 
            this.Sqr_button.Location = new System.Drawing.Point(17, 236);
            this.Sqr_button.Name = "Sqr_button";
            this.Sqr_button.Size = new System.Drawing.Size(35, 34);
            this.Sqr_button.TabIndex = 14;
            this.Sqr_button.Text = "A^B";
            this.toolTip1.SetToolTip(this.Sqr_button, "Возведение в степень первого операнда показателем степени второго операнда");
            this.Sqr_button.UseVisualStyleBackColor = true;
            this.Sqr_button.Click += new System.EventHandler(this.Sqr_button_Click);
            // 
            // Percent_button
            // 
            this.Percent_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Percent_button.Location = new System.Drawing.Point(137, 154);
            this.Percent_button.Name = "Percent_button";
            this.Percent_button.Size = new System.Drawing.Size(35, 35);
            this.Percent_button.TabIndex = 15;
            this.Percent_button.Text = "%";
            this.toolTip1.SetToolTip(this.Percent_button, "Вычисление доли первого операнда от второго");
            this.Percent_button.UseVisualStyleBackColor = true;
            this.Percent_button.Click += new System.EventHandler(this.Percent_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(185, 385);
            this.Controls.Add(this.Percent_button);
            this.Controls.Add(this.Sqr_button);
            this.Controls.Add(this.Sqrt_button);
            this.Controls.Add(this.Cos_button);
            this.Controls.Add(this.Sin_button);
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
        private System.Windows.Forms.Button Sin_button;
        private System.Windows.Forms.Button Cos_button;
        private System.Windows.Forms.Button Sqrt_button;
        private System.Windows.Forms.Button Sqr_button;
        private System.Windows.Forms.Button Percent_button;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

