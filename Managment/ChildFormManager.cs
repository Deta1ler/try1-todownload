using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace try1
{
    public partial class ChildFormManager : Form
    {
        // Для управління дочірніми формами
        protected Form activeForm;

        public ChildFormManager()
        {
            InitializeComponent();
        }

        // Механізм відкриття дочірніх форм
        protected void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}