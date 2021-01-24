using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoColonna1308.Forms;
using AutoColonna1308.Models;
using System.IO;

namespace AutoColonna1308.Forms
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            LoadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.Show();
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void LoadData()
        {
            lnameTB.Text = "";
            fnameTB.Text = "";
            mnameTB.Text = "";
            genderCB.Text = "";
            birthDTP.Value = DateTime.Now;
            phoneTB.Text = "";
            addressTB.Text = "";
            eduCB.Text = "";
            receiptDTP.Value = DateTime.Now;
            divisionCB.Text = "";
            positionCB.Text = "";

            genderCB.DropDownStyle = ComboBoxStyle.DropDownList;
            eduCB.DropDownStyle = ComboBoxStyle.DropDownList;
            divisionCB.DropDownStyle = ComboBoxStyle.DropDownList;
            positionCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lnameTB.Text) || string.IsNullOrEmpty(fnameTB.Text) || string.IsNullOrEmpty(mnameTB.Text) || string.IsNullOrEmpty(genderCB.Text)
                || string.IsNullOrEmpty(birthDTP.Text) || string.IsNullOrEmpty(phoneTB.Text) || string.IsNullOrEmpty(addressTB.Text) || string.IsNullOrEmpty(eduCB.Text)
                || string.IsNullOrEmpty(receiptDTP.Text) || string.IsNullOrEmpty(divisionCB.Text) || string.IsNullOrEmpty(positionCB.Text))
                MessageBox.Show("Все поля должны быть заполнены", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var agent = Program.db.Staff.FirstOrDefault(f => f.LastName == lnameTB.Text);
                if (agent == null) goto _next;
                if (agent.FirstName == fnameTB.Text && agent.MiddleName == mnameTB.Text)
                {
                    MessageBox.Show("Данный сотрудник уже существует", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            _next: var newpers = new Staff()
            {
                LastName = lnameTB.Text,
                FirstName = fnameTB.Text,
                MiddleName = mnameTB.Text,
                Gender = genderCB.Text,
                Birth = birthDTP.Value,
                Phone = phoneTB.Text,
                Address = addressTB.Text,
                Edu = eduCB.Text,
                DateOfReceipt = receiptDTP.Value,
                Division = divisionCB.Text,
                Position = positionCB.Text,
            };

                Program.db.Staff.Add(newpers);
                Program.db.SaveChanges();
                MessageBox.Show("Сотрудник успешно добавлен", "Сотрудники", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                var requiredPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
                var result = requiredPath.Remove(0, 6);
                
                    var Staf = Program.db.Staff.ToList();
                    var max = Staf.Max(p => p.Id_chel);
                    Convert.ToString(max);
                    var maxx =result+ "\\" + max;
                    pbFoto.Image.Save(maxx+".jpg");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
             Bitmap image;

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; 
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName); 
                    pbFoto.Image = image;
                    pbFoto.Invalidate();
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
