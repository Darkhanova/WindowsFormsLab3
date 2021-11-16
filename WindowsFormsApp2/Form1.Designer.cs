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
            this.label1 = new System.Windows.Forms.Label();
            this.chisl1 = new System.Windows.Forms.TextBox();
            this.znam1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.znam2 = new System.Windows.Forms.TextBox();
            this.chisl2 = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.raz = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.srav = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.Button();
            this.sokr = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите дроби";
            // 
            // chisl1
            // 
            this.chisl1.Location = new System.Drawing.Point(206, 13);
            this.chisl1.Name = "chisl1";
            this.chisl1.Size = new System.Drawing.Size(81, 26);
            this.chisl1.TabIndex = 1;
            this.chisl1.TextChanged += new System.EventHandler(this.chisl1_TextChanged_1);
            this.chisl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chisl1_KeyDown);
            // 
            // znam1
            // 
            this.znam1.Location = new System.Drawing.Point(206, 68);
            this.znam1.Name = "znam1";
            this.znam1.Size = new System.Drawing.Size(81, 26);
            this.znam1.TabIndex = 2;
            this.znam1.TextChanged += new System.EventHandler(this.znam1_TextChanged_1);
            this.znam1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.znam1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "----------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "----------------";
            // 
            // znam2
            // 
            this.znam2.Location = new System.Drawing.Point(363, 68);
            this.znam2.Name = "znam2";
            this.znam2.Size = new System.Drawing.Size(81, 26);
            this.znam2.TabIndex = 5;
            this.znam2.TextChanged += new System.EventHandler(this.znam2_TextChanged_1);
            this.znam2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.znam2_KeyDown);
            // 
            // chisl2
            // 
            this.chisl2.Location = new System.Drawing.Point(363, 13);
            this.chisl2.Name = "chisl2";
            this.chisl2.Size = new System.Drawing.Size(81, 26);
            this.chisl2.TabIndex = 4;
            this.chisl2.TextChanged += new System.EventHandler(this.chisl2_TextChanged_1);
            this.chisl2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chisl2_KeyDown);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(35, 142);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 32);
            this.sum.TabIndex = 7;
            this.sum.Text = "Сумма";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // raz
            // 
            this.raz.Location = new System.Drawing.Point(131, 142);
            this.raz.Name = "raz";
            this.raz.Size = new System.Drawing.Size(96, 32);
            this.raz.TabIndex = 8;
            this.raz.Text = "Разность";
            this.raz.UseVisualStyleBackColor = true;
            this.raz.Click += new System.EventHandler(this.raz_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(252, 142);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(88, 32);
            this.multi.TabIndex = 9;
            this.multi.Text = "Произв.";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // srav
            // 
            this.srav.Location = new System.Drawing.Point(363, 142);
            this.srav.Name = "srav";
            this.srav.Size = new System.Drawing.Size(105, 32);
            this.srav.TabIndex = 10;
            this.srav.Text = "Сравнение";
            this.srav.UseVisualStyleBackColor = true;
            this.srav.Click += new System.EventHandler(this.srav_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ответ:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(571, 40);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 12;
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(35, 198);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(99, 32);
            this.divide.TabIndex = 13;
            this.divide.Text = "Деление";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // sokr
            // 
            this.sokr.Location = new System.Drawing.Point(181, 198);
            this.sokr.Name = "sokr";
            this.sokr.Size = new System.Drawing.Size(127, 32);
            this.sokr.TabIndex = 14;
            this.sokr.Text = "Сокращение";
            this.sokr.UseVisualStyleBackColor = true;
            this.sokr.Click += new System.EventHandler(this.sokr_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(353, 198);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(115, 32);
            this.clear.TabIndex = 15;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 249);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.sokr);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.srav);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.raz);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.znam2);
            this.Controls.Add(this.chisl2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.znam1);
            this.Controls.Add(this.chisl1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Калькулятор ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chisl1;
        private System.Windows.Forms.TextBox znam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox znam2;
        private System.Windows.Forms.TextBox chisl2;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button raz;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button srav;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button sokr;
        private System.Windows.Forms.Button clear;
    }
}

