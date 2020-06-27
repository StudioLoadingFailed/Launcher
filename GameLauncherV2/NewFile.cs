using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncherV2
{
    class NewFile
    {
        string name;
        string path;
        Image convertedImage;

        TableLayoutPanel TableLayoutPanel;
        Label panelLabel = new Label();

        public NewFile(string path, TableLayoutPanel tableLayoutPanel)
        {
            this.path = path;
            this.TableLayoutPanel = tableLayoutPanel;
            name = GetName(path);
            name = name.Substring(0, name.Length - 4);
            GetIcon();
        }
        void GetIcon()
        {
            Icon icon = Icon.ExtractAssociatedIcon(path);
            convertedImage = icon.ToBitmap();
            Generate();
        }
        void Generate()
        {
            Label label = new Label();
            label.Text = name;
            label.Font = new Font("Calibri", 12, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;
            TableLayoutPanel.Controls.Add(label, Form1.column, Form1.row);
            Form1.row++;

            PictureBox pictureBox = new PictureBox();
            convertedImage = ChangeSize(convertedImage, new Size(30, 30));
            pictureBox.Image = convertedImage;
            pictureBox.Margin = new Padding(37, 0, 0, 0);
            TableLayoutPanel.Controls.Add(pictureBox, Form1.column, Form1.row);
            Form1.row++;

            switch (Form1.remove)
            {
                case true:
                    panelLabel.Text = "Remove";
                    break;
                case false:
                    panelLabel.Text = "Open";
                    break;
                default:
                    break;
            }
            panelLabel.Click += Button_Click;
            panelLabel.Font = new Font("Calibri", 12, FontStyle.Bold);
            panelLabel.ForeColor = Color.White;
            Panel panel = new Panel();
            panel.Controls.Add(panelLabel);
            panel.Margin = new Padding(18, 0, 0, 0);
            panel.BackColor = Color.Black;
            panel.Size = new Size(64, 19);
            Form1.labelList.Add(panelLabel);
            TableLayoutPanel.Controls.Add(panel, Form1.column, Form1.row);

            Form1.row++;

            Form1.column++;

            if (Form1.column == 6)
            {
                Form1.counter++;
                Form1.column = 0;
            }
            switch (Form1.counter)
            {
                case 0:
                    Form1.row = 0;
                    break;
                case 1:
                    Form1.row = 3;
                    break;
                case 2:
                    Form1.row = 6;
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!Form1.remove)
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                Form1.labelList.Remove(panelLabel);
                string[] lines = File.ReadAllLines(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Data.txt");
                var list = new List<string>();
                foreach (var line in lines)
                {
                    list.Add(line);
                    if (list.Contains(path))
                    {
                        list.Remove(path);
                    }
                }
                File.WriteAllText(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Data.txt", string.Empty);
                using (StreamWriter sw = new StreamWriter(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Data.txt", append: true))
                {
                    foreach (var item in list)
                    {
                        sw.WriteLine(item);                       
                    }
                    sw.Close();
                }
            }
            TableLayoutPanel.Controls.Clear();
            string[] linesN = File.ReadAllLines(@"D:\Projects\App\GameLauncherV2\GameLauncherV2\Data.txt");
            Form1.column = 0;
            Form1.row = 0;
            Form1.counter = 0;
            foreach (var item in linesN)
            {
                NewFile file = new NewFile(item, this.TableLayoutPanel);
            }
        }

        Image ChangeSize(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        string GetName(string path)
        {
            return Path.GetFileName(path);
        }
    }
}
