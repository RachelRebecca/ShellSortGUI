namespace ShellSortGUI
{
    partial class NumberSelector
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
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewNum = new System.Windows.Forms.Button();
            this.pnlRowOfNumbers = new System.Windows.Forms.Panel();
            this.numberSelectorPrompt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numberCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(456, 194);
            this.nud.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(47, 20);
            this.nud.TabIndex = 0;
            this.nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddNewNum
            // 
            this.btnAddNewNum.Location = new System.Drawing.Point(335, 220);
            this.btnAddNewNum.Name = "btnAddNewNum";
            this.btnAddNewNum.Size = new System.Drawing.Size(168, 35);
            this.btnAddNewNum.TabIndex = 2;
            this.btnAddNewNum.Text = "Click Here To Add New Number";
            this.btnAddNewNum.UseVisualStyleBackColor = true;
            this.btnAddNewNum.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlRowOfNumbers
            // 
            this.pnlRowOfNumbers.Location = new System.Drawing.Point(44, 44);
            this.pnlRowOfNumbers.Name = "pnlRowOfNumbers";
            this.pnlRowOfNumbers.Size = new System.Drawing.Size(724, 50);
            this.pnlRowOfNumbers.TabIndex = 3;
            // 
            // numberSelectorPrompt
            // 
            this.numberSelectorPrompt.AutoSize = true;
            this.numberSelectorPrompt.Location = new System.Drawing.Point(339, 196);
            this.numberSelectorPrompt.Name = "numberSelectorPrompt";
            this.numberSelectorPrompt.Size = new System.Drawing.Size(111, 13);
            this.numberSelectorPrompt.TabIndex = 4;
            this.numberSelectorPrompt.Text = "Choose New Number:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 85);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ready?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Sort);
            // 
            // numberCount
            // 
            this.numberCount.AutoSize = true;
            this.numberCount.Location = new System.Drawing.Point(362, 18);
            this.numberCount.Name = "numberCount";
            this.numberCount.Size = new System.Drawing.Size(141, 13);
            this.numberCount.TabIndex = 6;
            this.numberCount.Text = "You have 0 current numbers";
            // 
            // NumberSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 461);
            this.Controls.Add(this.numberCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberSelectorPrompt);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.pnlRowOfNumbers);
            this.Controls.Add(this.btnAddNewNum);
            this.Name = "NumberSelector";
            this.Text = "Choose Your Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Button btnAddNewNum;
        private System.Windows.Forms.Panel pnlRowOfNumbers;
        private System.Windows.Forms.Label numberSelectorPrompt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label numberCount;
    }
}

