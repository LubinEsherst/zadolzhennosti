namespace Гороскоп
{
    partial class Sign
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
            this.cmbSign = new System.Windows.Forms.ComboBox();
            this.butStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.знакиЗодиакаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какУзнатьСвойЗзToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.характеристикаЗзToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.овенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.близнецыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ракToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.левToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скорпионToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стрелецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.козерогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водолейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рыбыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dataonline = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSign
            // 
            this.cmbSign.FormattingEnabled = true;
            this.cmbSign.Items.AddRange(new object[] {
            "Овен",
            "Телец",
            "Близнецы",
            "Рак",
            "Лев",
            "Дева",
            "Весы",
            "Скорпион",
            "Стрелец",
            "Козерог",
            "Водолей",
            "Рыбы"});
            this.cmbSign.Location = new System.Drawing.Point(97, 90);
            this.cmbSign.Name = "cmbSign";
            this.cmbSign.Size = new System.Drawing.Size(118, 21);
            this.cmbSign.TabIndex = 1;
            this.cmbSign.SelectedIndexChanged += new System.EventHandler(this.cmbSign_SelectedIndexChanged);
            // 
            // butStart
            // 
            this.butStart.Enabled = false;
            this.butStart.Location = new System.Drawing.Point(120, 117);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 41);
            this.butStart.TabIndex = 2;
            this.butStart.Text = "Узнать будущее";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.знакиЗодиакаToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // знакиЗодиакаToolStripMenuItem
            // 
            this.знакиЗодиакаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какУзнатьСвойЗзToolStripMenuItem,
            this.характеристикаЗзToolStripMenuItem});
            this.знакиЗодиакаToolStripMenuItem.Name = "знакиЗодиакаToolStripMenuItem";
            this.знакиЗодиакаToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.знакиЗодиакаToolStripMenuItem.Text = "Знаки зодиака";
            // 
            // какУзнатьСвойЗзToolStripMenuItem
            // 
            this.какУзнатьСвойЗзToolStripMenuItem.Name = "какУзнатьСвойЗзToolStripMenuItem";
            this.какУзнатьСвойЗзToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.какУзнатьСвойЗзToolStripMenuItem.Text = "Как узнать свой зз?";
            this.какУзнатьСвойЗзToolStripMenuItem.Click += new System.EventHandler(this.какУзнатьСвойЗзToolStripMenuItem_Click);
            // 
            // характеристикаЗзToolStripMenuItem
            // 
            this.характеристикаЗзToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.овенToolStripMenuItem,
            this.телецToolStripMenuItem,
            this.близнецыToolStripMenuItem,
            this.ракToolStripMenuItem,
            this.левToolStripMenuItem,
            this.деваToolStripMenuItem,
            this.весыToolStripMenuItem,
            this.скорпионToolStripMenuItem,
            this.стрелецToolStripMenuItem,
            this.козерогToolStripMenuItem,
            this.водолейToolStripMenuItem,
            this.рыбыToolStripMenuItem});
            this.характеристикаЗзToolStripMenuItem.Name = "характеристикаЗзToolStripMenuItem";
            this.характеристикаЗзToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.характеристикаЗзToolStripMenuItem.Text = "Характеристика зз";
            // 
            // овенToolStripMenuItem
            // 
            this.овенToolStripMenuItem.Name = "овенToolStripMenuItem";
            this.овенToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.овенToolStripMenuItem.Text = "Овен";
            this.овенToolStripMenuItem.Click += new System.EventHandler(this.овенToolStripMenuItem_Click);
            // 
            // телецToolStripMenuItem
            // 
            this.телецToolStripMenuItem.Name = "телецToolStripMenuItem";
            this.телецToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.телецToolStripMenuItem.Text = "Телец";
            this.телецToolStripMenuItem.Click += new System.EventHandler(this.телецToolStripMenuItem_Click);
            // 
            // близнецыToolStripMenuItem
            // 
            this.близнецыToolStripMenuItem.Name = "близнецыToolStripMenuItem";
            this.близнецыToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.близнецыToolStripMenuItem.Text = "Близнецы";
            this.близнецыToolStripMenuItem.Click += new System.EventHandler(this.близнецыToolStripMenuItem_Click);
            // 
            // ракToolStripMenuItem
            // 
            this.ракToolStripMenuItem.Name = "ракToolStripMenuItem";
            this.ракToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ракToolStripMenuItem.Text = "Рак";
            this.ракToolStripMenuItem.Click += new System.EventHandler(this.ракToolStripMenuItem_Click);
            // 
            // левToolStripMenuItem
            // 
            this.левToolStripMenuItem.Name = "левToolStripMenuItem";
            this.левToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.левToolStripMenuItem.Text = "Лев";
            this.левToolStripMenuItem.Click += new System.EventHandler(this.левToolStripMenuItem_Click);
            // 
            // деваToolStripMenuItem
            // 
            this.деваToolStripMenuItem.Name = "деваToolStripMenuItem";
            this.деваToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.деваToolStripMenuItem.Text = "Дева";
            this.деваToolStripMenuItem.Click += new System.EventHandler(this.деваToolStripMenuItem_Click);
            // 
            // весыToolStripMenuItem
            // 
            this.весыToolStripMenuItem.Name = "весыToolStripMenuItem";
            this.весыToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.весыToolStripMenuItem.Text = "Весы";
            this.весыToolStripMenuItem.Click += new System.EventHandler(this.весыToolStripMenuItem_Click);
            // 
            // скорпионToolStripMenuItem
            // 
            this.скорпионToolStripMenuItem.Name = "скорпионToolStripMenuItem";
            this.скорпионToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.скорпионToolStripMenuItem.Text = "Скорпион";
            this.скорпионToolStripMenuItem.Click += new System.EventHandler(this.скорпионToolStripMenuItem_Click);
            // 
            // стрелецToolStripMenuItem
            // 
            this.стрелецToolStripMenuItem.Name = "стрелецToolStripMenuItem";
            this.стрелецToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.стрелецToolStripMenuItem.Text = "Стрелец";
            this.стрелецToolStripMenuItem.Click += new System.EventHandler(this.стрелецToolStripMenuItem_Click);
            // 
            // козерогToolStripMenuItem
            // 
            this.козерогToolStripMenuItem.Name = "козерогToolStripMenuItem";
            this.козерогToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.козерогToolStripMenuItem.Text = "Козерог";
            this.козерогToolStripMenuItem.Click += new System.EventHandler(this.козерогToolStripMenuItem_Click);
            // 
            // водолейToolStripMenuItem
            // 
            this.водолейToolStripMenuItem.Name = "водолейToolStripMenuItem";
            this.водолейToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.водолейToolStripMenuItem.Text = "Водолей";
            this.водолейToolStripMenuItem.Click += new System.EventHandler(this.водолейToolStripMenuItem_Click);
            // 
            // рыбыToolStripMenuItem
            // 
            this.рыбыToolStripMenuItem.Name = "рыбыToolStripMenuItem";
            this.рыбыToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.рыбыToolStripMenuItem.Text = "Рыбы";
            this.рыбыToolStripMenuItem.Click += new System.EventHandler(this.рыбыToolStripMenuItem_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // Dataonline
            // 
            this.Dataonline.AutoSize = true;
            this.Dataonline.Location = new System.Drawing.Point(13, 237);
            this.Dataonline.Name = "Dataonline";
            this.Dataonline.Size = new System.Drawing.Size(73, 13);
            this.Dataonline.TabIndex = 7;
            this.Dataonline.Text = "Гороскоп на ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(82, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Выберите ваш знак зодиака";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Гороскоп.Properties.Resources.зз3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 264);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Dataonline);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.cmbSign);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sign";
            this.Text = "Гороскоп";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSign;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem знакиЗодиакаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какУзнатьСвойЗзToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem характеристикаЗзToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem овенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem близнецыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ракToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem левToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem деваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скорпионToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стрелецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem козерогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водолейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рыбыToolStripMenuItem;
        private System.Windows.Forms.Label Dataonline;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

