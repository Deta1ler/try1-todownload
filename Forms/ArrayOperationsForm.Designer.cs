namespace try1
{
    partial class ArrayOperationsForm
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
            this.btnConcat = new System.Windows.Forms.Button();
            this.lstConcatResult = new System.Windows.Forms.ListBox();
            this.btnMergeUnique = new System.Windows.Forms.Button();
            this.lstMergeResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConcat
            // 
            this.btnConcat.Location = new System.Drawing.Point(66, 46);
            this.btnConcat.Name = "btnConcat";
            this.btnConcat.Size = new System.Drawing.Size(394, 23);
            this.btnConcat.TabIndex = 0;
            this.btnConcat.Text = "Поелементне зчеплення першого і другого масивів";
            this.btnConcat.UseVisualStyleBackColor = true;
            this.btnConcat.Click += new System.EventHandler(this.btnConcat_Click);
            // 
            // lstConcatResult
            // 
            this.lstConcatResult.FormattingEnabled = true;
            this.lstConcatResult.ItemHeight = 16;
            this.lstConcatResult.Location = new System.Drawing.Point(158, 102);
            this.lstConcatResult.Name = "lstConcatResult";
            this.lstConcatResult.Size = new System.Drawing.Size(147, 516);
            this.lstConcatResult.TabIndex = 1;
            // 
            // btnMergeUnique
            // 
            this.btnMergeUnique.Location = new System.Drawing.Point(757, 46);
            this.btnMergeUnique.Name = "btnMergeUnique";
            this.btnMergeUnique.Size = new System.Drawing.Size(366, 23);
            this.btnMergeUnique.TabIndex = 2;
            this.btnMergeUnique.Text = "Злиття двох масивів із виключенням повторів";
            this.btnMergeUnique.UseVisualStyleBackColor = true;
            this.btnMergeUnique.Click += new System.EventHandler(this.btnMergeUnique_Click);
            // 
            // lstMergeResult
            // 
            this.lstMergeResult.FormattingEnabled = true;
            this.lstMergeResult.ItemHeight = 16;
            this.lstMergeResult.Location = new System.Drawing.Point(874, 102);
            this.lstMergeResult.Name = "lstMergeResult";
            this.lstMergeResult.Size = new System.Drawing.Size(149, 516);
            this.lstMergeResult.TabIndex = 3;
            // 
            // ArrayOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 625);
            this.Controls.Add(this.lstMergeResult);
            this.Controls.Add(this.btnMergeUnique);
            this.Controls.Add(this.lstConcatResult);
            this.Controls.Add(this.btnConcat);
            this.Name = "ArrayOperationsForm";
            this.Text = "ArrayOperationsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConcat;
        private System.Windows.Forms.ListBox lstConcatResult;
        private System.Windows.Forms.Button btnMergeUnique;
        private System.Windows.Forms.ListBox lstMergeResult;
    }
}