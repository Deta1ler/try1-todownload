namespace try1
{
    partial class ChildFormManager
    {
        /// <summary>
        /// Обов’язковий компонент-диспозер
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Звільнення ресурсів
        /// </summary>
        /// <param name="disposing">true, якщо потрібно звільнити ресурси</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, згенерований дизайнером Windows Forms

        /// <summary>
        /// Метод, необхідний для підтримки конструктора — не змінювати в редакторі
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormDesignSchema";
        }

        #endregion
    }
}
