using System;
using System.Windows.Forms;

namespace try1
{
    public partial class FormInitalSetup : Form
    {
        public static FixedStringArray array1;
        public static FixedStringArray array2;

        public FormInitalSetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length1 = (int)numericUpDown1.Value;
            try
            {
                array1 = new FixedStringArray(length1);
                MessageBox.Show($"Масив 1 із {length1} елементів створено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int length2 = (int)numericUpDown2.Value;
            try
            {
                array2 = new FixedStringArray(length2);
                MessageBox.Show($"Масив 2 із {length2} елементів створено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Не обов’язково реалізовувати, якщо нічого не змінюється автоматично
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Не обов’язково реалізовувати, якщо нічого не змінюється автоматично
        }

        private void FormInitalSetup_Load(object sender, EventArgs e)
        {

        }

    }
}
