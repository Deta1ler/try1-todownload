namespace try1
{
    partial class Processing2arrayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.lblAddStatus2 = new System.Windows.Forms.Label();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.txtIndex2 = new System.Windows.Forms.TextBox();
            this.btnGetByIndex2 = new System.Windows.Forms.Button();
            this.lblIndexResult2 = new System.Windows.Forms.Label();
            this.lstArray2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(419, 60);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(100, 22);
            this.txtAdd2.TabIndex = 0;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(559, 46);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(196, 50);
            this.btnAdd2.TabIndex = 1;
            this.btnAdd2.Text = "Додати рядок у другий масив";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // lblAddStatus2
            // 
            this.lblAddStatus2.AutoSize = true;
            this.lblAddStatus2.Location = new System.Drawing.Point(496, 125);
            this.lblAddStatus2.Name = "lblAddStatus2";
            this.lblAddStatus2.Size = new System.Drawing.Size(0, 16);
            this.lblAddStatus2.TabIndex = 2;
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(993, 289);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(188, 43);
            this.btnClear2.TabIndex = 3;
            this.btnClear2.Text = "Очистити другий масив";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtIndex2
            // 
            this.txtIndex2.Location = new System.Drawing.Point(522, 463);
            this.txtIndex2.Name = "txtIndex2";
            this.txtIndex2.Size = new System.Drawing.Size(100, 22);
            this.txtIndex2.TabIndex = 4;
            // 
            // btnGetByIndex2
            // 
            this.btnGetByIndex2.Location = new System.Drawing.Point(663, 438);
            this.btnGetByIndex2.Name = "btnGetByIndex2";
            this.btnGetByIndex2.Size = new System.Drawing.Size(184, 78);
            this.btnGetByIndex2.TabIndex = 5;
            this.btnGetByIndex2.Text = "Отримати елемент другого масиву за індексом";
            this.btnGetByIndex2.UseVisualStyleBackColor = true;
            this.btnGetByIndex2.Click += new System.EventHandler(this.btnGetByIndex2_Click);
            // 
            // lblIndexResult2
            // 
            this.lblIndexResult2.AutoSize = true;
            this.lblIndexResult2.Location = new System.Drawing.Point(439, 544);
            this.lblIndexResult2.Name = "lblIndexResult2";
            this.lblIndexResult2.Size = new System.Drawing.Size(0, 16);
            this.lblIndexResult2.TabIndex = 6;
            // 
            // lstArray2
            // 
            this.lstArray2.FormattingEnabled = true;
            this.lstArray2.ItemHeight = 16;
            this.lstArray2.Location = new System.Drawing.Point(1203, 32);
            this.lstArray2.Name = "lstArray2";
            this.lstArray2.Size = new System.Drawing.Size(210, 548);
            this.lstArray2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введення нового рядка для другого масиву";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Повідомлення про додавання/помилки другого масиву";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введення індексу для доступу до елементу другого масиву";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вивід елемента/помилки для другого масиву";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1138, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Відображення елементів другого масиву";
            // 
            // Processing2arrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 688);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstArray2);
            this.Controls.Add(this.lblIndexResult2);
            this.Controls.Add(this.btnGetByIndex2);
            this.Controls.Add(this.txtIndex2);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.lblAddStatus2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.txtAdd2);
            this.Name = "Processing2arrayForm";
            this.Text = "Processing2arrayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Label lblAddStatus2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TextBox txtIndex2;
        private System.Windows.Forms.Button btnGetByIndex2;
        private System.Windows.Forms.Label lblIndexResult2;
        private System.Windows.Forms.ListBox lstArray2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}