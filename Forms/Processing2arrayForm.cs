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
    public partial class Processing2arrayForm : Form
    {
        private FixedStringArray array2 = FormInitalSetup.array2;

        public Processing2arrayForm()
        {
            InitializeComponent();
            
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            string value = txtAdd2.Text.Trim();
            if (string.IsNullOrEmpty(value))
            {
                lblAddStatus2.Text = "Рядок не може бути порожнім.";
                return;
            }

            if (array2 == null)
            {
                lblAddStatus2.Text = "Масив ще не створено.";
                return;
            }

            if (array2.Add(value))
            {
                lblAddStatus2.Text = "Рядок додано.";
                UpdateArray2List();
            }
            else
            {
                lblAddStatus2.Text = "Масив переповнено.";
            }
            txtAdd2.Clear();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            if (array2 != null)
            {
                array2.Clear();
                lblAddStatus2.Text = "Масив очищено.";
                UpdateArray2List();
            }
            else
            {
                lblAddStatus2.Text = "Масив ще не створено.";
            }
        }

        private void btnGetByIndex2_Click(object sender, EventArgs e)
        {
            if (array2 == null)
            {
                lblIndexResult2.Text = "Масив ще не створено.";
                return;
            }

            if (int.TryParse(txtIndex2.Text, out int index))
            {
                try
                {
                    string value = array2.GetByIndex(index);
                    lblIndexResult2.Text = $"Елемент [{index}] = {value}";
                }
                catch (IndexOutOfRangeException)
                {
                    lblIndexResult2.Text = "Індекс поза межами масиву.";
                }
            }
            else
            {
                lblIndexResult2.Text = "Некоректне значення індексу.";
            }
        }

        private void UpdateArray2List()
        {
            lstArray2.Items.Clear();
            if (array2 != null)
            {
                foreach (var item in array2.GetAll())
                {
                    lstArray2.Items.Add(item);

                }
            }
        }
    }
}  

