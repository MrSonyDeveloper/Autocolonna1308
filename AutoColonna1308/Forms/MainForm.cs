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

namespace AutoColonna1308
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void loadData(int index)
        {
            LoadData();
            dgvPersonal.CurrentCell = dgvPersonal.Rows[index].Cells[0];
        }
        void LoadData()
        {
            dgvPersonal.DataSource = Program.db.Staff.Select(s => new
            {
                s.Id_chel,
                s.LastName,
                s.FirstName,
                s.MiddleName,
                s.Position,
            }).ToList();
        }
        void loadData(Boolean scroll, int dif)
        {
            var v = dgvPersonal.FirstDisplayedScrollingRowIndex;
            var index = dgvPersonal.SelectedRows[0].Index - dif;
            LoadData();
            if (scroll)
            {
                dgvPersonal.FirstDisplayedScrollingRowIndex = v;
                dgvPersonal.Rows[index].Selected = true;
            }
        }

        private void DgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var selectedRegistrationEventID = (int)dgvPersonal.SelectedRows[0].Cells[1].Value;
                var selectedRegistrationEvent = Program.db.Staff.FirstOrDefault(p =>
                    p.Id_chel == selectedRegistrationEventID
                );
                if (selectedRegistrationEvent == null)
                    return;
                Hide();
                var CheckForm = new CheckForm(selectedRegistrationEvent);
                CheckForm.ShowDialog();
                LoadData();
                return;
            }
        }
        public int col = 0;
        public int row = 0;
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            for (col = 0; col < dgvPersonal.ColumnCount; col++)
                for (row = 0; row < dgvPersonal.RowCount; row++)
                {
                    dgvPersonal[col, row].Style.BackColor = Color.White;
                    if (dgvPersonal[col, row].Value.ToString().IndexOf(searchTB.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        dgvPersonal[col, row].Style.BackColor = Color.DarkGray;
                }
            if (string.IsNullOrWhiteSpace(searchTB.Text))
            {
                MessageBox.Show("Введите запрос!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchTB.Focus();
                for (col = 0; col < dgvPersonal.ColumnCount; col++)
                    for (row = 0; row < dgvPersonal.RowCount; row++)
                        dgvPersonal[col, row].Style.BackColor = Color.White;
                searchTB.Focus();
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            searchTB.Text = "";
            for (col = 0; col < dgvPersonal.ColumnCount; col++)
                for (row = 0; row < dgvPersonal.RowCount; row++)
                    dgvPersonal[col, row].Style.BackColor = Color.White;
            searchTB.Focus();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            Hide();
            add.Show();
        }

        private void delBtn_Click_1(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Вы действительно хотите удалить сотрудника?", "Сотрудники", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (question == DialogResult.Yes)
            {
                try
                {
                    var selectedRegistrationEventID = (int)dgvPersonal.SelectedRows[0].Cells[1].Value;
                    var selectedRegistrationEvent = Program.db.Staff.FirstOrDefault(p =>
                        p.Id_chel == selectedRegistrationEventID
                    );
                    var select = Program.db.Staff.Find(selectedRegistrationEventID);
                    Program.db.Staff.Remove(select);
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
    }
}
