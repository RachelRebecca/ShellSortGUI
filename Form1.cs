using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellSortGUI
{
    public partial class NumberSelector : Form
    {
        private List<Label> labelNumbers = new List<Label>();
        private List<int> intNumbers = new List<int>();

        private int prevLocation = 0;

        public NumberSelector()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            String numberOrNumbers = intNumbers.Count == 0 ? "number" : "numbers";
            numberCount.Text = "You have " + (intNumbers.Count + 1) + " current " + numberOrNumbers;
            if (intNumbers.Count + 1 <= 16)
            {
                Label label = new Label();
                label.Visible = true;
                label.Size = new Size(40, 20);
                label.Location = new Point(prevLocation, 0);
                label.BackColor = Color.White;
                prevLocation += 45;
                label.Text = ((int)nud.Value).ToString();
                intNumbers.Add(int.Parse(label.Text));
                labelNumbers.Add(label);
                pnlRowOfNumbers.Controls.Add(label);
                label.Refresh();

                if (intNumbers.Count + 1 == 17)
                {
                    nud.Visible = false;
                    nud.Refresh();
                    btnAddNewNum.Visible = false;
                    btnAddNewNum.Refresh();
                    numberSelectorPrompt.Text = "No more numbers can be added.";
                    numberSelectorPrompt.Refresh();
                }
            }
        }

        private void Sort(object sender, EventArgs e)
        {
            Sorter sorter = new Sorter(labelNumbers, intNumbers);
            this.Hide();
            sorter.Closed += (s, args) => this.Close();
            sorter.Show();
        }
    }
}
