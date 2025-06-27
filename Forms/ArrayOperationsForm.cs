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
    public partial class ArrayOperationsForm : Form
    {
        private FixedStringArray array1 = FormInitalSetup.array1;
        private FixedStringArray array2 = FormInitalSetup.array2;

        public ArrayOperationsForm()
        {
            InitializeComponent();
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            lstConcatResult.Items.Clear();

            if (array1 == null || array2 == null)
            {
                MessageBox.Show("Масиви ще не створено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = FixedStringArray.ElementWiseConcat(array1, array2);
            foreach (var item in result.GetAll())
            {
                lstConcatResult.Items.Add(item);
            }
        }

        private void btnMergeUnique_Click(object sender, EventArgs e)
        {
            lstMergeResult.Items.Clear();

            if (array1 == null || array2 == null)
            {
                MessageBox.Show("Масиви ще не створено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = FixedStringArray.MergeUnique(array1, array2);
            foreach (var item in result.GetAll())
            {
                lstMergeResult.Items.Add(item);
            }
        }
    }
}
