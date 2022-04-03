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
    public partial class Sorter : Form
    {
        private List<Panel> panelList = new List<Panel>();
        private List<Label> labelList = new List<Label>();
        private List<int> intList = new List<int>();

        private int previousInt = 0;
        private int comparisons = 0;
        private int swaps = 0;

        public Sorter(List<Label> labelNumbers, List<int> intNumbers)
        {
            InitializeComponent();
            labelList = labelNumbers;
            intList = intNumbers;
            DisplayLabels();
        }

        public void DisplayLabels()
        {
            for (int i = 0; i < labelList.Count; i++)
            {
                labelList[i].Location = new Point(0, previousInt);
                mainPanel.Controls.Add(labelList[i]);
                labelList[i].Refresh();

                Panel newPanel = new Panel();
                newPanel.Size = panelRow.Size;
                newPanel.Location = new Point(40, previousInt);
                mainPanel.Controls.Add(newPanel);
                newPanel.Refresh();

                FillRowPanelWithPictureBoxes(i, newPanel); 

                previousInt += 30;
            }

            sortButton.Location = new Point(this.Size.Width / 2, previousInt + 5);
            sortButton.Visible = true;
        }

        private void FillRowPanelWithPictureBoxes(int i, Panel newPanel)
        {
            int previousForRow = 0;
            for (int j = 0; j < int.Parse(labelList[i].Text.ToString()); j++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = pbSquare.Size;
                pictureBox.BackColor = pbSquare.BackColor;
                pictureBox.Location = new Point(previousForRow, 0);
                newPanel.Controls.Add(pictureBox);
                pictureBox.Refresh();
                previousForRow += 40;
            }
            panelList.Add(newPanel);
        }

        public void NewSort()
        {
            int nrValues = intList.Count;
            int gap = nrValues / 2;

            do
            {
                for (int ixO = gap; ixO < nrValues; ixO++)
                {
                    for (int ixI = ixO; ixI >= gap; ixI -= gap)
                    {
                        ChangeColor(ixI, gap, Color.Yellow);
                        System.Threading.Thread.Sleep(5);

                        int cmp = Compare(ixI - gap, ixI);
                        comparisons++;
                        if (cmp > 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            swaps++;
                            Swap(ixI - gap, ixI);
                        }

                        ChangeColor(ixI, gap, Color.White);
                    }
                }
                gap /= 2;
            } while (gap > 0);
        }

        private void ChangeColor(int ixI, int gap, Color color)
        {
            labelList[ixI - gap].BackColor = color;
            labelList[ixI].BackColor = color;
            labelList[ixI - gap].Refresh();
            labelList[ixI].Refresh();
        }

        private int Compare(int low, int high)
        {
            int retVal = 0;
            if (intList[low] < intList[high])
            {
                retVal = -1;
            }
            else if (intList[low] > intList[high])
            {
                retVal = 1;
            }
            return retVal;
        }

        private void Swap(int low, int high)
        {

            int tmp = intList[low];
            String tmpLabel = labelList[low].Text.ToString();
            Point tmpLocation = panelList[low].Location;


            intList[low] = intList[high];
            labelList[low].Text = labelList[high].Text;
            panelList[low].Location = panelList[high].Location;

            intList[high] = tmp;
            labelList[high].Text = tmpLabel;
            panelList[high].Location = tmpLocation;


            Panel tmpPanel = panelList[low];
            panelList[low] = panelList[high];
            panelList[high] = tmpPanel;

            panelList[low].Refresh();
            panelList[high].Refresh();
            System.Threading.Thread.Sleep(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (intList.Count != 1)
            {
                NewSort();
            }
            sortButton.Visible = false;
            MessageBox.Show("Sorted :) \n\nComparisons: " + comparisons + "\nSwaps: " + swaps);
        }

    
    }
}
