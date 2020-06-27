using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GameLauncherV2
{
    public partial class Form1 : Form
    {
        public static int column = 0;
        public static int row = 0;
        public static int counter = 0;

        public static List<Label> labelList = new List<Label>();

        public static bool remove = false;

        Point lastPoint;

        public Form1()
        {
            InitializeComponent();
            LoadFile loadFile = new LoadFile(TableGrid);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (column != 6 && row != 9)
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Exe Files (.exe)|*.exe";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Data.txt");
                    string contents = sr.ReadToEnd();
                    sr.Close();
                    if (!contents.Contains(openFileDialog.FileName))
                    {
                        NewFile file = new NewFile(openFileDialog.FileName, TableGrid);
                        using (StreamWriter writer = new StreamWriter(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Data.txt", append: true))
                        {
                            writer.WriteLine(openFileDialog.FileName);
                            writer.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error this shortcut is already there");
                    }
                }
            }
            else
            {
                MessageBox.Show("For add remove something");
            }
        }
        private void AddLabel_MouseEnter(object sender, EventArgs e)
        {
            AddLabel.ForeColor = Color.Gray;
        }

        private void AddLabel_MouseLeave(object sender, EventArgs e)
        {
            AddLabel.ForeColor = Color.White;
        }



        private void RemoveLabel_Click(object sender, EventArgs e)
        {
            if (!remove)
            {
                remove = true;
                for (int i = 0; i < labelList.Count; i++)
                {
                    labelList[i].Text = "Remove";
                }
                RemoveLabel.Text = "Done";
            }
            else
            {
                for (int i = 0; i < labelList.Count; i++)
                {
                    labelList[i].Text = "Open";
                }
                RemoveLabel.Text = "Remove";
                remove = false;
            }
        }

        private void RemoveLabel_MouseEnter(object sender, EventArgs e)
        {
            RemoveLabel.ForeColor = Color.Gray;
        }

        private void RemoveLabel_MouseLeave(object sender, EventArgs e)
        {
            RemoveLabel.ForeColor = Color.White;
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        private void ExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBox_MouseHover(object sender, EventArgs e)
        {
            ExitBox.Image = Image.FromFile(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Resources\Exit.png");
            ExitBox.BackColor = Color.White;
        }

        private void ExitBox_MouseLeave(object sender, EventArgs e)
        {
            ExitBox.Image = Image.FromFile(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Resources\Exit-hover.png");
            ExitBox.BackColor = Color.Black;
        }



    }

}
