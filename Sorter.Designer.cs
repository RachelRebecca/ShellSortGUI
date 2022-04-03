namespace ShellSortGUI
{
    partial class Sorter
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelRow = new System.Windows.Forms.Panel();
            this.pbSquare = new System.Windows.Forms.PictureBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panelRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panelRow);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1055, 480);
            this.mainPanel.TabIndex = 0;
            // 
            // panelRow
            // 
            this.panelRow.Controls.Add(this.pbSquare);
            this.panelRow.Location = new System.Drawing.Point(56, 21);
            this.panelRow.Name = "panelRow";
            this.panelRow.Size = new System.Drawing.Size(985, 20);
            this.panelRow.TabIndex = 0;
            this.panelRow.Visible = false;
            // 
            // pbSquare
            // 
            this.pbSquare.BackColor = System.Drawing.Color.IndianRed;
            this.pbSquare.Location = new System.Drawing.Point(0, 0);
            this.pbSquare.Name = "pbSquare";
            this.pbSquare.Size = new System.Drawing.Size(40, 20);
            this.pbSquare.TabIndex = 0;
            this.pbSquare.TabStop = false;
            this.pbSquare.Visible = false;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(453, 498);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(150, 50);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "SORT!";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Visible = false;
            this.sortButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 544);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.mainPanel);
            this.Name = "Sorter";
            this.Text = "Sorter";
            this.mainPanel.ResumeLayout(false);
            this.panelRow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSquare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelRow;
        private System.Windows.Forms.PictureBox pbSquare;
        private System.Windows.Forms.Button sortButton;
    }
}