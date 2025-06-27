using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace try1
{
    public partial class Processing1arrayForm : Form
    {
        private FixedStringArray array1 = FormInitalSetup.array1;
        public Processing1arrayForm()
        {
            InitializeComponent();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            string value = txtAdd1.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                Labek4.Text = "Рядок не може бути порожнім.";
                return;
            }

            if (array1 == null)
            {
                Labek4.Text = "Масив ще не створено.";
                return;
            }

            if (array1.Add(value))
            {
                Labek4.Text = "Рядок додано.";
                UpdateArray1List();
            }
            else
            {
                Labek4.Text = "Масив переповнено.";
            }
            txtAdd1.Clear();
        }

        // ОЧИСТИТИ перший масив
        private void btnClear1_Click(object sender, EventArgs e)
        {
            if (array1 != null)
            {
                array1.Clear();
                Labek4.Text = "Масив очищено.";
                UpdateArray1List();
            }
            else
            {
                Labek4.Text = "Масив ще не створено.";
            }
        }

        // ОТРИМАТИ елемент за індексом
        private void btnGetByIndex1_Click(object sender, EventArgs e)
        {
            if (array1 == null)
            {
                lblIndexResult1.Text = "Масив ще не створено.";
                return;
            }

            if (int.TryParse(txtIndex1.Text, out int index))
            {
                try
                {
                    string value = array1.GetByIndex(index);
                    lblIndexResult1.Text = $"Елемент [{index}] = {value}";
                }
                catch (IndexOutOfRangeException)
                {
                    lblIndexResult1.Text = "Індекс поза межами масиву.";
                }
            }
            else
            {
                lblIndexResult1.Text = "Некоректне значення індексу.";
            }
        }

        // МЕТОД ДЛЯ ОНОВЛЕННЯ ListBox
        private void UpdateArray1List()
        {
            lstArray1.Items.Clear();
            if (array1 != null)
            {
                foreach (var item in array1.GetAll())
                {
                    lstArray1.Items.Add(item);
                }
            }
        }
    }
}
