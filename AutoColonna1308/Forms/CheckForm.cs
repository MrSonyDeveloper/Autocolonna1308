using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoColonna1308.Models;
using AutoColonna1308.Forms;
using System.IO;

namespace AutoColonna1308.Forms
{
    public partial class CheckForm : Form
    {
        public Staff SelectedRegistrationEvent { get; set; }
        public Bitmap image { get; private set; }

        //public User SelectedUserID { get; }
        public CheckForm()
        {
            InitializeComponent();
            SelectedRegistrationEvent = SelectedRegistrationEvent;
        }
        private void CheckForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public CheckForm(Staff selectedRegistrationEvent)
        {
            InitializeComponent();
            SelectedRegistrationEvent = selectedRegistrationEvent;
            LoadData();
        }
        void LoadData()
        {
            lnameTB.Text = SelectedRegistrationEvent.LastName;
            fnameTB.Text = SelectedRegistrationEvent.FirstName;
            mnameTB.Text = SelectedRegistrationEvent.MiddleName;
            genderCB.Text = SelectedRegistrationEvent.Gender;
            birthDTP.Text = SelectedRegistrationEvent.Birth.ToString();
            phoneTB.Text = SelectedRegistrationEvent.Phone;
            addressTB.Text = SelectedRegistrationEvent.Address;
            eduCB.Text = SelectedRegistrationEvent.Edu;
            receiptDTP.Text = SelectedRegistrationEvent.DateOfReceipt.ToString();
            divisionCB.Text = SelectedRegistrationEvent.Division;
            positionCB.Text = SelectedRegistrationEvent.Position;

            genderCB.DropDownStyle = ComboBoxStyle.DropDownList;
            eduCB.DropDownStyle = ComboBoxStyle.DropDownList;
            divisionCB.DropDownStyle = ComboBoxStyle.DropDownList;
            positionCB.DropDownStyle = ComboBoxStyle.DropDownList;

            var requiredPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            var result = requiredPath.Remove(0, 6);
            var put = Convert.ToString(result+"\\"+ SelectedRegistrationEvent.Id_chel + ".jpg");
            try
            {
            image = new Bitmap(put);
            pbFoto.Image = image;

            }
            catch { }
            var d1 = DateTime.Now.Day;
            int d2 = DateTime.Now.Month;
            var d3 = SelectedRegistrationEvent.DateOfReceipt.Day;
            int d4 = SelectedRegistrationEvent.DateOfReceipt.Month;
            var date1 = DateTime.Now.Year;
            var date2 = SelectedRegistrationEvent.DateOfReceipt.Year;
            var staj = date1 - date2;
            if (d1 >= d3 && d2 >= d4)
                stajTB.Text = staj.ToString();
            else
            {
                var staj2 = staj - 1;
                stajTB.Text = staj2.ToString();
            }

            if (staj == 0)
                stajTB.Text = "Без стажа";

            dgvChilds.DataSource = SelectedRegistrationEvent.Childs.Select(s => new
            {
                s.LastName,
                s.FirstName,
                s.MiddleName,
                s.Birth
            }).ToList();

            if (dgvChilds.RowCount <= 0)
            {
                dgvChilds.Visible = false;
                childsL.Visible = true;
            }
            dgvBol.DataSource = SelectedRegistrationEvent.Bol.Select(s => new
            {
                s.BolStart,
                s.BolFinish
            }).ToList();
            if (dgvBol.RowCount <= 0)
            {
                dgvBol.Visible = false;
                BolL.Visible = true;
            }
            dgvVac.DataSource = SelectedRegistrationEvent.Vacation.Select(s => new
            {
                s.VacStart,
                s.VacFinish
            }).ToList();
            if (dgvVac.RowCount <= 0)
            {
                dgvVac.Visible = false;
                VacL.Visible = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lnameTB.Text) || string.IsNullOrEmpty(fnameTB.Text) || string.IsNullOrEmpty(mnameTB.Text) || string.IsNullOrEmpty(genderCB.Text)
                || string.IsNullOrEmpty(birthDTP.Text) || string.IsNullOrEmpty(phoneTB.Text) || string.IsNullOrEmpty(addressTB.Text) || string.IsNullOrEmpty(eduCB.Text)
                || string.IsNullOrEmpty(receiptDTP.Text) || string.IsNullOrEmpty(divisionCB.Text) || string.IsNullOrEmpty(positionCB.Text)
                || string.IsNullOrEmpty(stajTB.Text))
                MessageBox.Show("Все поля должны быть заполнены", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var id = SelectedRegistrationEvent.Id_chel;
                var edit = Program.db.Staff.Find(id);
                edit.LastName = lnameTB.Text;
                edit.FirstName = fnameTB.Text;
                edit.MiddleName = mnameTB.Text;
                edit.Gender = genderCB.Text;
                edit.Birth = birthDTP.Value;
                edit.Phone = phoneTB.Text;
                edit.Address = addressTB.Text;
                edit.Edu = eduCB.Text;
                edit.DateOfReceipt = receiptDTP.Value;
                edit.Division = divisionCB.Text;
                edit.Position = positionCB.Text;
                Program.db.SaveChanges();
                MainForm mf = new MainForm();
                Hide();
                mf.Show();
            }
        }

        private void CheckForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTAFFDataSet1.Vacation". При необходимости она может быть перемещена или удалена.
            this.vacationTableAdapter.Fill(this.sTAFFDataSet1.Vacation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTAFFDataSet1.Bol". При необходимости она может быть перемещена или удалена.
            this.bolTableAdapter.Fill(this.sTAFFDataSet1.Bol);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTAFFDataSet1.Childs". При необходимости она может быть перемещена или удалена.
            this.childsTableAdapter.Fill(this.sTAFFDataSet1.Childs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTAFFDataSet.Division". При необходимости она может быть перемещена или удалена.
            //this.divisionTableAdapter.Fill(this.sTAFFDataSet.Division);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sTAFFDataSet.Position". При необходимости она может быть перемещена или удалена.
            //this.positionTableAdapter.Fill(this.sTAFFDataSet.Position);

        }

        private void PositionCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lnameTB.Text) || string.IsNullOrEmpty(fnameTB.Text) || string.IsNullOrEmpty(mnameTB.Text) || string.IsNullOrEmpty(genderCB.Text)
                || string.IsNullOrEmpty(birthDTP.Text) || string.IsNullOrEmpty(phoneTB.Text) || string.IsNullOrEmpty(addressTB.Text) || string.IsNullOrEmpty(eduCB.Text)
                || string.IsNullOrEmpty(receiptDTP.Text) || string.IsNullOrEmpty(divisionCB.Text) || string.IsNullOrEmpty(positionCB.Text)
                || string.IsNullOrEmpty(stajTB.Text))
                MessageBox.Show("Все поля должны быть заполнены", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var requiredPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
                var result = requiredPath.Remove(0, 6);
                var id = SelectedRegistrationEvent.Id_chel;
                var edit = Program.db.Staff.Find(id);
                edit.LastName = lnameTB.Text;
                edit.FirstName = fnameTB.Text;
                edit.MiddleName = mnameTB.Text;
                edit.Gender = genderCB.Text;
                edit.Birth = birthDTP.Value;
                edit.Phone = phoneTB.Text;
                edit.Address = addressTB.Text;
                edit.Edu = eduCB.Text;
                edit.DateOfReceipt = receiptDTP.Value;
                edit.Division = divisionCB.Text;
                edit.Position = positionCB.Text;
                Program.db.SaveChanges();
                Convert.ToString(id);
                var maxx = result + "\\" + id;
                pbFoto.Image.Save(maxx + ".jpg");
                LoadData();
                MessageBox.Show("Данные успешно изменены", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addbolBtn_Click(object sender, EventArgs e)
        {
            if (bolstartDTP.Value == bolfinishDTP.Value)
                MessageBox.Show("Данные не могут совпадать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (bolstartDTP.Value == null || bolfinishDTP.Value == null)
                MessageBox.Show("Данные должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (bolstartDTP.Value > bolfinishDTP.Value)
                MessageBox.Show("Данные начала не могут превышать данных конца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var newbol = new Bol()
                {
                    IdChel = SelectedRegistrationEvent.Id_chel,
                    BolStart = bolstartDTP.Value,
                    BolFinish = bolfinishDTP.Value,
                };
                Program.db.Bol.Add(newbol);
                Program.db.SaveChanges();
                MessageBox.Show("Данные успешно обновлены", "Больничные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
        //
        //
        //Надо как-то фиксить и доделать то же самое с детьми и отпусками (хотя вообще похуй если честно, я бы лучше делал учёт и фотки, это на потом можно оставить)
        //
        //
        private void delBtn_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Вы действительно хотите удалить сотрудника?", "Сотрудники", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                try
                {

                    var delbolID = (int)dgvBol.SelectedRows[0].Cells[1].Value;
                    var delbol = Program.db.Bol.FirstOrDefault(p =>
                        p.IdChel == delbolID
                    );
                    var select = Program.db.Bol.Find(delbol);
                    Program.db.Bol.Remove(select);
                    Program.db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Сотрудник успешно удалён", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LoadData();
            }
        }
        //
        //до сюда
        //

        private void btnChange_Click(object sender, EventArgs e)
        {

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pbFoto.Image = image;
                    //pbFoto.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    
