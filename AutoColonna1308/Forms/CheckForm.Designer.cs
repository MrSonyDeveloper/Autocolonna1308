namespace AutoColonna1308.Forms
{
    partial class CheckForm
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
            this.components = new System.ComponentModel.Container();
            this.LastNameLb = new System.Windows.Forms.Label();
            this.firstNameLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.mnameTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.birthDTP = new System.Windows.Forms.DateTimePicker();
            this.receiptDTP = new System.Windows.Forms.DateTimePicker();
            this.positionCB = new System.Windows.Forms.ComboBox();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFDataSet = new AutoColonna1308.STAFFDataSet();
            this.positionTableAdapter = new AutoColonna1308.STAFFDataSetTableAdapters.PositionTableAdapter();
            this.divisionCB = new System.Windows.Forms.ComboBox();
            this.divisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.divisionTableAdapter = new AutoColonna1308.STAFFDataSetTableAdapters.DivisionTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.sTAFFDataSet1 = new AutoColonna1308.STAFFDataSet();
            this.childsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childsTableAdapter = new AutoColonna1308.STAFFDataSetTableAdapters.ChildsTableAdapter();
            this.dgvChilds = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childsL = new System.Windows.Forms.Label();
            this.dgvBol = new System.Windows.Forms.DataGridView();
            this.bolStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.bolTableAdapter = new AutoColonna1308.STAFFDataSetTableAdapters.BolTableAdapter();
            this.BolL = new System.Windows.Forms.Label();
            this.VacL = new System.Windows.Forms.Label();
            this.dgvVac = new System.Windows.Forms.DataGridView();
            this.vacStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.vacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationTableAdapter = new AutoColonna1308.STAFFDataSetTableAdapters.VacationTableAdapter();
            this.stajTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.eduCB = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.bolstartDTP = new System.Windows.Forms.DateTimePicker();
            this.bolfinishDTP = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.addbolBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChilds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LastNameLb
            // 
            this.LastNameLb.AutoSize = true;
            this.LastNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LastNameLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastNameLb.Location = new System.Drawing.Point(94, 53);
            this.LastNameLb.Name = "LastNameLb";
            this.LastNameLb.Size = new System.Drawing.Size(96, 24);
            this.LastNameLb.TabIndex = 72;
            this.LastNameLb.Text = "Фамилия:";
            // 
            // firstNameLb
            // 
            this.firstNameLb.AutoSize = true;
            this.firstNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.firstNameLb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameLb.Location = new System.Drawing.Point(139, 84);
            this.firstNameLb.Name = "firstNameLb";
            this.firstNameLb.Size = new System.Drawing.Size(51, 24);
            this.firstNameLb.TabIndex = 71;
            this.firstNameLb.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(87, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(312, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 92;
            this.label2.Text = "Профиль сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(2, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Адрес проживания:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(141, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 94;
            this.label4.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(35, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 95;
            this.label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(95, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 96;
            this.label6.Text = "Телефон:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(59, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 97;
            this.label7.Text = "Дата приёма:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 31);
            this.button1.TabIndex = 104;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(73, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 105;
            this.label9.Text = "Должность:";
            // 
            // lnameTB
            // 
            this.lnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnameTB.Location = new System.Drawing.Point(192, 53);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(255, 26);
            this.lnameTB.TabIndex = 106;
            // 
            // fnameTB
            // 
            this.fnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fnameTB.Location = new System.Drawing.Point(192, 84);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(255, 26);
            this.fnameTB.TabIndex = 107;
            // 
            // mnameTB
            // 
            this.mnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mnameTB.Location = new System.Drawing.Point(192, 115);
            this.mnameTB.Name = "mnameTB";
            this.mnameTB.Size = new System.Drawing.Size(255, 26);
            this.mnameTB.TabIndex = 108;
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(192, 208);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(255, 26);
            this.phoneTB.TabIndex = 111;
            // 
            // addressTB
            // 
            this.addressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTB.Location = new System.Drawing.Point(192, 239);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(255, 26);
            this.addressTB.TabIndex = 112;
            // 
            // genderCB
            // 
            this.genderCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderCB.Location = new System.Drawing.Point(192, 146);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(255, 28);
            this.genderCB.TabIndex = 115;
            // 
            // birthDTP
            // 
            this.birthDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDTP.Location = new System.Drawing.Point(192, 178);
            this.birthDTP.Name = "birthDTP";
            this.birthDTP.Size = new System.Drawing.Size(255, 26);
            this.birthDTP.TabIndex = 116;
            this.birthDTP.Value = new System.DateTime(2002, 11, 29, 0, 0, 0, 0);
            // 
            // receiptDTP
            // 
            this.receiptDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptDTP.Location = new System.Drawing.Point(192, 302);
            this.receiptDTP.Name = "receiptDTP";
            this.receiptDTP.Size = new System.Drawing.Size(255, 26);
            this.receiptDTP.TabIndex = 117;
            this.receiptDTP.Value = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            // 
            // positionCB
            // 
            this.positionCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.positionBindingSource, "NamePosition", true));
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
            this.positionCB.Location = new System.Drawing.Point(192, 363);
            this.positionCB.Name = "positionCB";
            this.positionCB.Size = new System.Drawing.Size(255, 28);
            this.positionCB.TabIndex = 118;
            this.positionCB.SelectedIndexChanged += new System.EventHandler(this.PositionCB_SelectedIndexChanged);
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this.sTAFFDataSet;
            // 
            // sTAFFDataSet
            // 
            this.sTAFFDataSet.DataSetName = "STAFFDataSet";
            this.sTAFFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // divisionCB
            // 
            this.divisionCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.divisionBindingSource, "NameDivision", true));
            this.divisionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionCB.FormattingEnabled = true;
            this.divisionCB.Items.AddRange(new object[] {
            "Отдел кадров",
            "Юридический отдел",
            "Инженерный отдел",
            "Бухгалтерия",
            "Отдел по перевозкам",
            "Отдел по информационным технологиям"});
            this.divisionCB.Location = new System.Drawing.Point(192, 332);
            this.divisionCB.Name = "divisionCB";
            this.divisionCB.Size = new System.Drawing.Size(255, 28);
            this.divisionCB.TabIndex = 120;
            // 
            // divisionBindingSource
            // 
            this.divisionBindingSource.DataMember = "Division";
            this.divisionBindingSource.DataSource = this.sTAFFDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(32, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 24);
            this.label8.TabIndex = 119;
            this.label8.Text = "Подразделение:";
            // 
            // divisionTableAdapter
            // 
            this.divisionTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(453, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 24);
            this.label10.TabIndex = 121;
            this.label10.Text = "Дети:";
            // 
            // sTAFFDataSet1
            // 
            this.sTAFFDataSet1.DataSetName = "STAFFDataSet1";
            this.sTAFFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // childsBindingSource
            // 
            this.childsBindingSource.DataMember = "Childs";
            this.childsBindingSource.DataSource = this.sTAFFDataSet1;
            // 
            // childsTableAdapter
            // 
            this.childsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvChilds
            // 
            this.dgvChilds.AutoGenerateColumns = false;
            this.dgvChilds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChilds.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvChilds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChilds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn});
            this.dgvChilds.DataSource = this.childsBindingSource;
            this.dgvChilds.Location = new System.Drawing.Point(512, 301);
            this.dgvChilds.Name = "dgvChilds";
            this.dgvChilds.Size = new System.Drawing.Size(414, 119);
            this.dgvChilds.TabIndex = 122;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            // 
            // childsL
            // 
            this.childsL.AutoSize = true;
            this.childsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.childsL.Location = new System.Drawing.Point(508, 304);
            this.childsL.Name = "childsL";
            this.childsL.Size = new System.Drawing.Size(39, 20);
            this.childsL.TabIndex = 123;
            this.childsL.Text = "Нет";
            this.childsL.Visible = false;
            // 
            // dgvBol
            // 
            this.dgvBol.AutoGenerateColumns = false;
            this.dgvBol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvBol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolStartDataGridViewTextBoxColumn,
            this.bolFinishDataGridViewTextBoxColumn});
            this.dgvBol.DataSource = this.bolBindingSource;
            this.dgvBol.Location = new System.Drawing.Point(578, 53);
            this.dgvBol.Name = "dgvBol";
            this.dgvBol.Size = new System.Drawing.Size(208, 121);
            this.dgvBol.TabIndex = 125;
            // 
            // bolStartDataGridViewTextBoxColumn
            // 
            this.bolStartDataGridViewTextBoxColumn.DataPropertyName = "BolStart";
            this.bolStartDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.bolStartDataGridViewTextBoxColumn.Name = "bolStartDataGridViewTextBoxColumn";
            // 
            // bolFinishDataGridViewTextBoxColumn
            // 
            this.bolFinishDataGridViewTextBoxColumn.DataPropertyName = "BolFinish";
            this.bolFinishDataGridViewTextBoxColumn.HeaderText = "Конец";
            this.bolFinishDataGridViewTextBoxColumn.Name = "bolFinishDataGridViewTextBoxColumn";
            // 
            // bolBindingSource
            // 
            this.bolBindingSource.DataMember = "Bol";
            this.bolBindingSource.DataSource = this.sTAFFDataSet1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(589, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 24);
            this.label12.TabIndex = 124;
            this.label12.Text = "Больничные:";
            // 
            // bolTableAdapter
            // 
            this.bolTableAdapter.ClearBeforeFill = true;
            // 
            // BolL
            // 
            this.BolL.AutoSize = true;
            this.BolL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BolL.Location = new System.Drawing.Point(710, 29);
            this.BolL.Name = "BolL";
            this.BolL.Size = new System.Drawing.Size(39, 20);
            this.BolL.TabIndex = 126;
            this.BolL.Text = "Нет";
            this.BolL.Visible = false;
            // 
            // VacL
            // 
            this.VacL.AutoSize = true;
            this.VacL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VacL.Location = new System.Drawing.Point(1097, 276);
            this.VacL.Name = "VacL";
            this.VacL.Size = new System.Drawing.Size(39, 20);
            this.VacL.TabIndex = 129;
            this.VacL.Text = "Нет";
            this.VacL.Visible = false;
            // 
            // dgvVac
            // 
            this.dgvVac.AutoGenerateColumns = false;
            this.dgvVac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvVac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vacStartDataGridViewTextBoxColumn,
            this.vacFinishDataGridViewTextBoxColumn});
            this.dgvVac.DataSource = this.vacationBindingSource1;
            this.dgvVac.Location = new System.Drawing.Point(968, 301);
            this.dgvVac.Name = "dgvVac";
            this.dgvVac.Size = new System.Drawing.Size(208, 116);
            this.dgvVac.TabIndex = 128;
            // 
            // vacStartDataGridViewTextBoxColumn
            // 
            this.vacStartDataGridViewTextBoxColumn.DataPropertyName = "VacStart";
            this.vacStartDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.vacStartDataGridViewTextBoxColumn.Name = "vacStartDataGridViewTextBoxColumn";
            // 
            // vacFinishDataGridViewTextBoxColumn
            // 
            this.vacFinishDataGridViewTextBoxColumn.DataPropertyName = "VacFinish";
            this.vacFinishDataGridViewTextBoxColumn.HeaderText = "Конец";
            this.vacFinishDataGridViewTextBoxColumn.Name = "vacFinishDataGridViewTextBoxColumn";
            // 
            // vacationBindingSource1
            // 
            this.vacationBindingSource1.DataMember = "Vacation";
            this.vacationBindingSource1.DataSource = this.sTAFFDataSet1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(1014, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 24);
            this.label13.TabIndex = 127;
            this.label13.Text = "Отпуска:";
            // 
            // vacationBindingSource
            // 
            this.vacationBindingSource.DataMember = "Vacation";
            this.vacationBindingSource.DataSource = this.sTAFFDataSet1;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
            // 
            // stajTB
            // 
            this.stajTB.Enabled = false;
            this.stajTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stajTB.Location = new System.Drawing.Point(192, 394);
            this.stajTB.Name = "stajTB";
            this.stajTB.Size = new System.Drawing.Size(255, 26);
            this.stajTB.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(128, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 24);
            this.label11.TabIndex = 131;
            this.label11.Text = "Стаж:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(53, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 24);
            this.label14.TabIndex = 133;
            this.label14.Text = "Образование:";
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
            this.eduCB.Location = new System.Drawing.Point(192, 270);
            this.eduCB.Name = "eduCB";
            this.eduCB.Size = new System.Drawing.Size(255, 28);
            this.eduCB.TabIndex = 134;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(12, 425);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(114, 38);
            this.saveBtn.TabIndex = 135;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // bolstartDTP
            // 
            this.bolstartDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bolstartDTP.Location = new System.Drawing.Point(532, 180);
            this.bolstartDTP.Name = "bolstartDTP";
            this.bolstartDTP.Size = new System.Drawing.Size(157, 22);
            this.bolstartDTP.TabIndex = 136;
            this.bolstartDTP.Value = new System.DateTime(2021, 1, 23, 0, 0, 0, 0);
            // 
            // bolfinishDTP
            // 
            this.bolfinishDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bolfinishDTP.Location = new System.Drawing.Point(532, 206);
            this.bolfinishDTP.Name = "bolfinishDTP";
            this.bolfinishDTP.Size = new System.Drawing.Size(157, 22);
            this.bolfinishDTP.TabIndex = 137;
            this.bolfinishDTP.Value = new System.DateTime(2021, 1, 23, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(453, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 24);
            this.label15.TabIndex = 138;
            this.label15.Text = "Начало:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(461, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 24);
            this.label16.TabIndex = 139;
            this.label16.Text = "Конец:";
            // 
            // addbolBtn
            // 
            this.addbolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbolBtn.Location = new System.Drawing.Point(695, 179);
            this.addbolBtn.Name = "addbolBtn";
            this.addbolBtn.Size = new System.Drawing.Size(91, 49);
            this.addbolBtn.TabIndex = 140;
            this.addbolBtn.Text = "Add";
            this.addbolBtn.UseVisualStyleBackColor = true;
            this.addbolBtn.Click += new System.EventHandler(this.addbolBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.Location = new System.Drawing.Point(465, 92);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(91, 38);
            this.delBtn.TabIndex = 141;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(1022, 42);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(140, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 142;
            this.pbFoto.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(1021, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 24);
            this.label17.TabIndex = 143;
            this.label17.Text = "Фото профиля";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(1045, 198);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(107, 38);
            this.btnChange.TabIndex = 144;
            this.btnChange.Text = "Изменить...";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 470);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addbolBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bolfinishDTP);
            this.Controls.Add(this.bolstartDTP);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.eduCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.stajTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VacL);
            this.Controls.Add(this.dgvVac);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BolL);
            this.Controls.Add(this.dgvBol);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.childsL);
            this.Controls.Add(this.dgvChilds);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameLb);
            this.Controls.Add(this.firstNameLb);
            this.Name = "CheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр профиля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckForm_FormClosed);
            this.Load += new System.EventHandler(this.CheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChilds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LastNameLb;
        private System.Windows.Forms.Label firstNameLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.TextBox mnameTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.DateTimePicker birthDTP;
        private System.Windows.Forms.DateTimePicker receiptDTP;
        private System.Windows.Forms.ComboBox positionCB;
        private STAFFDataSet sTAFFDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private STAFFDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.ComboBox divisionCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource divisionBindingSource;
        private STAFFDataSetTableAdapters.DivisionTableAdapter divisionTableAdapter;
        private System.Windows.Forms.Label label10;
        private STAFFDataSet sTAFFDataSet1;
        private System.Windows.Forms.BindingSource childsBindingSource;
        private STAFFDataSetTableAdapters.ChildsTableAdapter childsTableAdapter;
        private System.Windows.Forms.DataGridView dgvChilds;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label childsL;
        private System.Windows.Forms.DataGridView dgvBol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bolBindingSource;
        private STAFFDataSetTableAdapters.BolTableAdapter bolTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label BolL;
        private System.Windows.Forms.Label VacL;
        private System.Windows.Forms.DataGridView dgvVac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource vacationBindingSource;
        private STAFFDataSetTableAdapters.VacationTableAdapter vacationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacFinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vacationBindingSource1;
        private System.Windows.Forms.TextBox stajTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox eduCB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker bolstartDTP;
        private System.Windows.Forms.DateTimePicker bolfinishDTP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button addbolBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnChange;
    }
}