using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        private List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        Label firstClicked, secondClicked;

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void CheckForWinner()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                Label iconLabel = tableLayoutPanel1.Controls[i] as Label;

                if (iconLabel != null && iconLabel.ForeColor == iconLabel.BackColor)
                    return;
            }
            MessageBox.Show("Congrats! You matched all the icons!", "Congratulations");
            Close();
        }

        private void label_click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;
            
            Label clickedLabel = sender as Label;
            
            if (clickedLabel == null)
                return;
            if (clickedLabel.ForeColor == Color.Black)
                return;
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;
            
            CheckForWinner();
            
            if (firstClicked.Text == secondClicked.Text)
            {
                    firstClicked = null;
                    secondClicked = null;
            }
            else
                timer1.Start();
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }
    }
}