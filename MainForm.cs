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
    public partial class MainForm : ChildFormManager
    {
        public MainForm()
        {
            InitializeComponent();
        }

    

        private void InitialSetupBTN_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, colorButton[1]);
            OpenChildForm(new FormInitalSetup());
        }

        private void Processing1arrayBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Processing1arrayForm());
        }

        private void Processing2arrayBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Processing2arrayForm());
        }

        private void ArrayOperationsBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArrayOperationsForm());
        }
    }
}
