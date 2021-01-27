namespace AmperAndVolts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_volts1 = new System.Windows.Forms.TextBox();
            this.textBox_resistance1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ampers1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_count1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_count2 = new System.Windows.Forms.Button();
            this.textBox_power = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_resistance2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ampers2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_count3 = new System.Windows.Forms.Button();
            this.textBox_energy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_mass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_count1);
            this.panel1.Controls.Add(this.textBox_ampers1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_resistance1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_volts1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 189);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напряжение:";
            // 
            // textBox_volts1
            // 
            this.textBox_volts1.Location = new System.Drawing.Point(97, 3);
            this.textBox_volts1.Name = "textBox_volts1";
            this.textBox_volts1.Size = new System.Drawing.Size(100, 20);
            this.textBox_volts1.TabIndex = 1;
            this.textBox_volts1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_resistance_KeyPress);
            // 
            // textBox_resistance1
            // 
            this.textBox_resistance1.Location = new System.Drawing.Point(97, 29);
            this.textBox_resistance1.Name = "textBox_resistance1";
            this.textBox_resistance1.Size = new System.Drawing.Size(100, 20);
            this.textBox_resistance1.TabIndex = 3;
            this.textBox_resistance1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_resistance_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сопротивление:";
            // 
            // textBox_ampers1
            // 
            this.textBox_ampers1.Location = new System.Drawing.Point(97, 55);
            this.textBox_ampers1.Name = "textBox_ampers1";
            this.textBox_ampers1.ReadOnly = true;
            this.textBox_ampers1.Size = new System.Drawing.Size(100, 20);
            this.textBox_ampers1.TabIndex = 5;
            this.textBox_ampers1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ток:";
            // 
            // button_count1
            // 
            this.button_count1.Location = new System.Drawing.Point(6, 76);
            this.button_count1.Name = "button_count1";
            this.button_count1.Size = new System.Drawing.Size(191, 23);
            this.button_count1.TabIndex = 6;
            this.button_count1.Text = "Рассчёт";
            this.button_count1.UseVisualStyleBackColor = true;
            this.button_count1.Click += new System.EventHandler(this.button_count_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_count2);
            this.panel2.Controls.Add(this.textBox_power);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_resistance2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_ampers2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(215, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 189);
            this.panel2.TabIndex = 7;
            // 
            // button_count2
            // 
            this.button_count2.Location = new System.Drawing.Point(6, 76);
            this.button_count2.Name = "button_count2";
            this.button_count2.Size = new System.Drawing.Size(191, 23);
            this.button_count2.TabIndex = 6;
            this.button_count2.Text = "Рассчёт";
            this.button_count2.UseVisualStyleBackColor = true;
            this.button_count2.Click += new System.EventHandler(this.button_count2_Click);
            // 
            // textBox_power
            // 
            this.textBox_power.Location = new System.Drawing.Point(97, 55);
            this.textBox_power.Name = "textBox_power";
            this.textBox_power.ReadOnly = true;
            this.textBox_power.Size = new System.Drawing.Size(100, 20);
            this.textBox_power.TabIndex = 5;
            this.textBox_power.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Мощность:";
            // 
            // textBox_resistance2
            // 
            this.textBox_resistance2.Location = new System.Drawing.Point(97, 29);
            this.textBox_resistance2.Name = "textBox_resistance2";
            this.textBox_resistance2.Size = new System.Drawing.Size(100, 20);
            this.textBox_resistance2.TabIndex = 3;
            this.textBox_resistance2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_resistance_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Сопротивление:";
            // 
            // textBox_ampers2
            // 
            this.textBox_ampers2.Location = new System.Drawing.Point(97, 3);
            this.textBox_ampers2.Name = "textBox_ampers2";
            this.textBox_ampers2.Size = new System.Drawing.Size(100, 20);
            this.textBox_ampers2.TabIndex = 1;
            this.textBox_ampers2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_resistance_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ток:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_count3);
            this.panel3.Controls.Add(this.textBox_energy);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBox_speed);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox_mass);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(421, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 189);
            this.panel3.TabIndex = 7;
            // 
            // button_count3
            // 
            this.button_count3.Location = new System.Drawing.Point(6, 76);
            this.button_count3.Name = "button_count3";
            this.button_count3.Size = new System.Drawing.Size(191, 23);
            this.button_count3.TabIndex = 6;
            this.button_count3.Text = "Рассчёт";
            this.button_count3.UseVisualStyleBackColor = true;
            this.button_count3.Click += new System.EventHandler(this.button_count3_Click);
            // 
            // textBox_energy
            // 
            this.textBox_energy.Location = new System.Drawing.Point(97, 55);
            this.textBox_energy.Name = "textBox_energy";
            this.textBox_energy.ReadOnly = true;
            this.textBox_energy.Size = new System.Drawing.Size(100, 20);
            this.textBox_energy.TabIndex = 5;
            this.textBox_energy.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Энергия:";
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(97, 29);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(100, 20);
            this.textBox_speed.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Скорость:";
            // 
            // textBox_mass
            // 
            this.textBox_mass.Location = new System.Drawing.Point(97, 3);
            this.textBox_mass.Name = "textBox_mass";
            this.textBox_mass.Size = new System.Drawing.Size(100, 20);
            this.textBox_mass.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Масса:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 204);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_count1;
        private System.Windows.Forms.TextBox textBox_ampers1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_resistance1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_volts1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_count2;
        private System.Windows.Forms.TextBox textBox_power;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_resistance2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ampers2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_count3;
        private System.Windows.Forms.TextBox textBox_energy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_mass;
        private System.Windows.Forms.Label label9;
    }
}

