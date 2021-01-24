namespace AutoColonna1308.Forms
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eduCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.divisionCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.positionCB = new System.Windows.Forms.ComboBox();
            this.receiptDTP = new System.Windows.Forms.DateTimePicker();
            this.birthDTP = new System.Windows.Forms.DateTimePicker();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.mnameTB = new System.Windows.Forms.TextBox();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameLb = new System.Windows.Forms.Label();
            this.firstNameLb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // eduCB
            // 
            this.eduCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eduCB.FormattingEnabled = true;
            this.eduCB.Items.AddRange(new object[] {
            "Основное общее образование",
            "Среднее (полное) общее образование",
            "Среднее профессиональное образование",
            "Высшее образование - бакалавриат",
            "Высшее образование - магистратура",
            "Высшее образование - подготовка кадров высшей квалификации",
            "Дополнительное профессиональное образование",
            "Профессиональное обучение"});
            this.eduCB.Location = new System.Drawing.Point(204, 228);
            this.eduCB.Name = "eduCB";
            this.eduCB.Size = new System.Drawing.Size(255, 28);
            this.eduCB.TabIndex = 158;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(65, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 24);
            this.label14.TabIndex = 157;
            this.label14.Text = "Образование:";
            // 
            // divisionCB
            // 
            this.divisionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionCB.FormattingEnabled = true;
            this.divisionCB.Items.AddRange(new object[] {
            "Отдел кадров",
            "Юридический отдел",
            "Инженерный отдел",
            "Бухгалтерия",
            "Отдел по перевозкам",
            "Отдел по информационным технологиям"});
            this.divisionCB.Location = new System.Drawing.Point(204, 290);
            this.divisionCB.Name = "divisionCB";
            this.divisionCB.Size = new System.Drawing.Size(255, 28);
            this.divisionCB.TabIndex = 154;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(44, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 24);
            this.label8.TabIndex = 153;
            this.label8.Text = "Подразделение:";
            // 
            // positionCB
            // 
            this.positionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionCB.FormattingEnabled = true;
            this.positionCB.Items.AddRange(new object[] {
            "Директор",
            "Кассиры",
            "Заведующий складами",
            "Электрик",
            "Механник",
            "Водитель",
            "Старший контроллер",
            "Контроллер",
            "Кондуктор",
            "Диспетчер автотранспорта",
            "Начальник колонны",
            "Специалист по кадровой работе",
            "Опертатор газовой котельной",
            "Главный инженер",
            "Специалист по телекоммуникациям",
            "Главный IT-специалист",
            "Программист",
            "Главный юрист",
            "Помощник руководителя",
            "Юрист",
            "Главный механник",
            "Механник - ремонтник",
            "Главный бухгалтер",
            "Бухгалтер"});
            this.positionCB.Location = new System.Drawing.Point(204, 321);
            this.positionCB.Name = "positionCB";
            this.positionCB.Size = new System.Drawing.Size(255, 28);
            this.positionCB.TabIndex = 152;
            // 
            // receiptDTP
            // 
            this.receiptDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptDTP.Location = new System.Drawing.Point(204, 260);
            this.receiptDTP.Name = "receiptDTP";
            this.receiptDTP.Size = new System.Drawing.Size(255, 26);
            this.receiptDTP.TabIndex = 151;
            this.receiptDTP.Value = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            // 
            // birthDTP
            // 
            this.birthDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDTP.Location = new System.Drawing.Point(204, 136);
            this.birthDTP.Name = "birthDTP";
            this.birthDTP.Size = new System.Drawing.Size(255, 26);
            this.birthDTP.TabIndex = 150;
            this.birthDTP.Value = new System.DateTime(2002, 11, 29, 0, 0, 0, 0);
            // 
            // genderCB
            // 
            this.genderCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderCB.Location = new System.Drawing.Point(204, 104);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(255, 28);
            this.genderCB.TabIndex = 149;
            // 
            // addressTB
            // 
            this.addressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTB.Location = new System.Drawing.Point(204, 197);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(255, 26);
            this.addressTB.TabIndex = 148;
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(204, 166);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(255, 26);
            this.phoneTB.TabIndex = 147;
            // 
            // mnameTB
            // 
            this.mnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mnameTB.Location = new System.Drawing.Point(204, 73);
            this.mnameTB.Name = "mnameTB";
            this.mnameTB.Size = new System.Drawing.Size(255, 26);
            this.mnameTB.TabIndex = 146;
            // 
            // fnameTB
            // 
            this.fnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fnameTB.Location = new System.Drawing.Point(204, 42);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(255, 26);
            this.fnameTB.TabIndex = 145;
            // 
            // lnameTB
            // 
            this.lnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnameTB.Location = new System.Drawing.Point(204, 11);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(255, 26);
            this.lnameTB.TabIndex = 144;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(85, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 143;
            this.label9.Text = "Должность:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(71, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 142;
            this.label7.Text = "Дата приёма:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(107, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 141;
            this.label6.Text = "Телефон:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(47, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 140;
            this.label5.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(153, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 139;
            this.label4.Text = "Пол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 138;
            this.label3.Text = "Адрес проживания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(99, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 137;
            this.label1.Text = "Отчество:";
            // 
            // LastNameLb
            // 
            this.LastNameLb.AutoSize = true;
            this.LastNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LastNameLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastNameLb.Location = new System.Drawing.Point(106, 11);
            this.LastNameLb.Name = "LastNameLb";
            this.LastNameLb.Size = new System.Drawing.Size(96, 24);
            this.LastNameLb.TabIndex = 136;
            this.LastNameLb.Text = "Фамилия:";
            // 
            // firstNameLb
            // 
            this.firstNameLb.AutoSize = true;
            this.firstNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.firstNameLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameLb.Location = new System.Drawing.Point(151, 42);
            this.firstNameLb.Name = "firstNameLb";
            this.firstNameLb.Size = new System.Drawing.Size(51, 24);
            this.firstNameLb.TabIndex = 135;
            this.firstNameLb.Text = "Имя:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 159;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(13, 48);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(76, 31);
            this.addBtn.TabIndex = 160;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(517, 44);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(164, 212);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 161;
            this.pbFoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(531, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 162;
            this.label2.Text = "Фото профиля";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.Location = new System.Drawing.Point(556, 260);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(97, 31);
            this.btnSelect.TabIndex = 163;
            this.btnSelect.Text = "Выбрать...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 164;
            this.label10.Text = "label10";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eduCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.divisionCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.positionCB);
            this.Controls.Add(this.receiptDTP);
            this.Controls.Add(this.birthDTP);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.mnameTB);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.lnameTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameLb);
            this.Controls.Add(this.firstNameLb);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox eduCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox divisionCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox positionCB;
        private System.Windows.Forms.DateTimePicker receiptDTP;
        private System.Windows.Forms.DateTimePicker birthDTP;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox mnameTB;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LastNameLb;
        private System.Windows.Forms.Label firstNameLb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label10;
    }
}