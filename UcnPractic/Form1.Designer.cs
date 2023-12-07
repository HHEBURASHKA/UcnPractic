namespace UcnPractic
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOth = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNoum = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.BoxKlass = new System.Windows.Forms.ComboBox();
            this.BoxChildren = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Proverka = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // txtFam
            // 
            this.txtFam.Location = new System.Drawing.Point(103, 76);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(164, 20);
            this.txtFam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Имя:";
            // 
            // txtOth
            // 
            this.txtOth.Location = new System.Drawing.Point(103, 132);
            this.txtOth.Name = "txtOth";
            this.txtOth.Size = new System.Drawing.Size(164, 20);
            this.txtOth.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(31, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 16);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Телефон:";
            // 
            // txtNoum
            // 
            this.txtNoum.Location = new System.Drawing.Point(104, 158);
            this.txtNoum.Mask = "+7(000)-00-0000";
            this.txtNoum.Name = "txtNoum";
            this.txtNoum.Size = new System.Drawing.Size(163, 20);
            this.txtNoum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата:";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(102, 206);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 13;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // BoxKlass
            // 
            this.BoxKlass.FormattingEnabled = true;
            this.BoxKlass.Items.AddRange(new object[] {
            "Эконом",
            "Комфорт",
            "Бизнес",
            "Первый класс"});
            this.BoxKlass.Location = new System.Drawing.Point(273, 106);
            this.BoxKlass.Name = "BoxKlass";
            this.BoxKlass.Size = new System.Drawing.Size(121, 21);
            this.BoxKlass.TabIndex = 14;
            // 
            // BoxChildren
            // 
            this.BoxChildren.FormattingEnabled = true;
            this.BoxChildren.Items.AddRange(new object[] {
            "Без детей ",
            "С детьми"});
            this.BoxChildren.Location = new System.Drawing.Point(273, 75);
            this.BoxChildren.Name = "BoxChildren";
            this.BoxChildren.Size = new System.Drawing.Size(121, 21);
            this.BoxChildren.TabIndex = 15;
            this.BoxChildren.SelectedIndexChanged += new System.EventHandler(this.BoxChildren_SelectedIndexChanged);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(103, 184);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(163, 20);
            this.txtData.TabIndex = 16;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(290, 374);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(140, 20);
            this.txtStart.TabIndex = 17;
            // 
            // txtFinish
            // 
            this.txtFinish.Location = new System.Drawing.Point(102, 374);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.Size = new System.Drawing.Size(140, 20);
            this.txtFinish.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(242, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Куда:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Откуда:";
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Items.AddRange(new object[] {
            "Багаж",
            "Питание",
            "Обратный билет"});
            this.List.Location = new System.Drawing.Point(273, 132);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(120, 49);
            this.List.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(270, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Проверка билета:";
            // 
            // Proverka
            // 
            this.Proverka.FormattingEnabled = true;
            this.Proverka.Location = new System.Drawing.Point(273, 208);
            this.Proverka.Name = "Proverka";
            this.Proverka.Size = new System.Drawing.Size(157, 160);
            this.Proverka.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(379, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Proverka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.BoxChildren);
            this.Controls.Add(this.BoxKlass);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtOth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Авиасейлс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox txtNoum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.ComboBox BoxKlass;
        private System.Windows.Forms.ComboBox BoxChildren;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox List;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Proverka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

