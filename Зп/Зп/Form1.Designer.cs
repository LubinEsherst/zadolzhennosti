namespace Зп
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
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.cmbDischarge = new System.Windows.Forms.ComboBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.cmbHours = new System.Windows.Forms.ComboBox();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.butZ = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccrued = new System.Windows.Forms.TextBox();
            this.txtWithheld = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIssued = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbExperience
            // 
            this.cmbExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbExperience.FormattingEnabled = true;
            this.cmbExperience.Items.AddRange(new object[] {
            "<5 лет",
            "5-10 лет",
            ">10 лет"});
            this.cmbExperience.Location = new System.Drawing.Point(165, 10);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(90, 28);
            this.cmbExperience.TabIndex = 0;
            this.cmbExperience.SelectedIndexChanged += new System.EventHandler(this.cmbExperience_SelectedIndexChanged);
            // 
            // cmbDischarge
            // 
            this.cmbDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbDischarge.FormattingEnabled = true;
            this.cmbDischarge.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbDischarge.Location = new System.Drawing.Point(183, 42);
            this.cmbDischarge.Name = "cmbDischarge";
            this.cmbDischarge.Size = new System.Drawing.Size(43, 28);
            this.cmbDischarge.TabIndex = 1;
            this.cmbDischarge.SelectedIndexChanged += new System.EventHandler(this.cmbDischarge_SelectedIndexChanged);
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPayment.Location = new System.Drawing.Point(199, 78);
            this.txtPayment.Multiline = true;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(56, 22);
            this.txtPayment.TabIndex = 2;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
            // 
            // cmbHours
            // 
            this.cmbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbHours.FormattingEnabled = true;
            this.cmbHours.Items.AddRange(new object[] {
            "6 часов",
            "8 часов"});
            this.cmbHours.Location = new System.Drawing.Point(323, 107);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(78, 28);
            this.cmbHours.TabIndex = 3;
            this.cmbHours.SelectedIndexChanged += new System.EventHandler(this.cmbHours_SelectedIndexChanged);
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cmbQuantity.Location = new System.Drawing.Point(285, 141);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(52, 28);
            this.cmbQuantity.TabIndex = 4;
            this.cmbQuantity.SelectedIndexChanged += new System.EventHandler(this.cmbQuantity_SelectedIndexChanged);
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTax.Location = new System.Drawing.Point(285, 183);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(47, 31);
            this.txtTax.TabIndex = 5;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            this.txtTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTax_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Стаж работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Разряд работника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Оплата одного часа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Продолжительность рабочего дня";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во рабочих дней в месяце";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Налоговая ставка в процентах";
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbTax.ForeColor = System.Drawing.Color.Red;
            this.lbTax.Location = new System.Drawing.Point(338, 189);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(397, 17);
            this.lbTax.TabIndex = 12;
            this.lbTax.Text = "К сожалению ставка должна быть в диаппозоне от 1 до 99";
            this.lbTax.Visible = false;
            // 
            // butZ
            // 
            this.butZ.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butZ.Enabled = false;
            this.butZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.butZ.ForeColor = System.Drawing.Color.Olive;
            this.butZ.Location = new System.Drawing.Point(427, 22);
            this.butZ.Name = "butZ";
            this.butZ.Size = new System.Drawing.Size(293, 147);
            this.butZ.TabIndex = 13;
            this.butZ.Text = "Рассчитать зарплату";
            this.butZ.UseVisualStyleBackColor = false;
            this.butZ.Click += new System.EventHandler(this.butZ_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(18, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Итого начислено";
            // 
            // txtAccrued
            // 
            this.txtAccrued.Enabled = false;
            this.txtAccrued.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAccrued.Location = new System.Drawing.Point(42, 283);
            this.txtAccrued.Multiline = true;
            this.txtAccrued.Name = "txtAccrued";
            this.txtAccrued.Size = new System.Drawing.Size(151, 27);
            this.txtAccrued.TabIndex = 15;
            // 
            // txtWithheld
            // 
            this.txtWithheld.Enabled = false;
            this.txtWithheld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtWithheld.Location = new System.Drawing.Point(559, 283);
            this.txtWithheld.Multiline = true;
            this.txtWithheld.Name = "txtWithheld";
            this.txtWithheld.Size = new System.Drawing.Size(124, 27);
            this.txtWithheld.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label8.Location = new System.Drawing.Point(553, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Удержано";
            // 
            // txtIssued
            // 
            this.txtIssued.Enabled = false;
            this.txtIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtIssued.Location = new System.Drawing.Point(323, 336);
            this.txtIssued.Multiline = true;
            this.txtIssued.Name = "txtIssued";
            this.txtIssued.Size = new System.Drawing.Size(96, 27);
            this.txtIssued.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label9.Location = new System.Drawing.Point(317, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Выдано";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 405);
            this.Controls.Add(this.txtIssued);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWithheld);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAccrued);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butZ);
            this.Controls.Add(this.lbTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.cmbQuantity);
            this.Controls.Add(this.cmbHours);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.cmbDischarge);
            this.Controls.Add(this.cmbExperience);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Заработная плата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.ComboBox cmbDischarge;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.ComboBox cmbHours;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Button butZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccrued;
        private System.Windows.Forms.TextBox txtWithheld;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIssued;
        private System.Windows.Forms.Label label9;
    }
}

