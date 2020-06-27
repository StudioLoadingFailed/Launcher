namespace GameLauncherV2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.TableGrid = new System.Windows.Forms.TableLayoutPanel();
            this.RemovePanel = new System.Windows.Forms.Panel();
            this.RemoveLabel = new System.Windows.Forms.Label();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            this.RemovePanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ExitBox);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 20);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // ExitBox
            // 
            this.ExitBox.Image = global::GameLauncherV2.Properties.Resources.Exit_hover;
            this.ExitBox.Location = new System.Drawing.Point(791, 2);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(22, 17);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBox.TabIndex = 6;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            this.ExitBox.MouseEnter += new System.EventHandler(this.ExitBox_MouseHover);
            this.ExitBox.MouseLeave += new System.EventHandler(this.ExitBox_MouseLeave);
            // 
            // TableGrid
            // 
            this.TableGrid.ColumnCount = 6;
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableGrid.Location = new System.Drawing.Point(14, 24);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.RowCount = 9;
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableGrid.Size = new System.Drawing.Size(776, 262);
            this.TableGrid.TabIndex = 5;
            // 
            // RemovePanel
            // 
            this.RemovePanel.BackColor = System.Drawing.Color.Black;
            this.RemovePanel.Controls.Add(this.RemoveLabel);
            this.RemovePanel.Location = new System.Drawing.Point(671, 292);
            this.RemovePanel.Name = "RemovePanel";
            this.RemovePanel.Size = new System.Drawing.Size(70, 19);
            this.RemovePanel.TabIndex = 6;
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.AutoSize = true;
            this.RemoveLabel.BackColor = System.Drawing.Color.Black;
            this.RemoveLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveLabel.ForeColor = System.Drawing.Color.White;
            this.RemoveLabel.Location = new System.Drawing.Point(3, -1);
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(64, 19);
            this.RemoveLabel.TabIndex = 1;
            this.RemoveLabel.Text = "Remove";
            this.RemoveLabel.Click += new System.EventHandler(this.RemoveLabel_Click);
            this.RemoveLabel.MouseEnter += new System.EventHandler(this.RemoveLabel_MouseEnter);
            this.RemoveLabel.MouseLeave += new System.EventHandler(this.RemoveLabel_MouseLeave);
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.Black;
            this.AddPanel.Controls.Add(this.AddLabel);
            this.AddPanel.Location = new System.Drawing.Point(747, 292);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(44, 19);
            this.AddPanel.TabIndex = 7;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.BackColor = System.Drawing.Color.Black;
            this.AddLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddLabel.ForeColor = System.Drawing.Color.White;
            this.AddLabel.Location = new System.Drawing.Point(3, -1);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(37, 19);
            this.AddLabel.TabIndex = 1;
            this.AddLabel.Text = "Add";
            this.AddLabel.Click += new System.EventHandler(this.AddButton_Click);
            this.AddLabel.MouseEnter += new System.EventHandler(this.AddLabel_MouseEnter);
            this.AddLabel.MouseLeave += new System.EventHandler(this.AddLabel_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 319);
            this.ControlBox = false;
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.RemovePanel);
            this.Controls.Add(this.TableGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Game launcher";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            this.RemovePanel.ResumeLayout(false);
            this.RemovePanel.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TableGrid;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.Panel RemovePanel;
        private System.Windows.Forms.Label RemoveLabel;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Label AddLabel;
    }
}

