namespace Core_Mk3
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            _manaBarsPanelPlayer = new Panel();
            _manaCountWaterLabelPlayer = new Label();
            _manaCountAirLabelPlayer = new Label();
            _manaCountFireLabelPlayer = new Label();
            _manaCountEarthLabelPlayer = new Label();
            DrawButton = new Button();
            _nameLabelPlayer = new Label();
            _iconPictureBoxPlayer = new PictureBox();
            _iconPictureBoxEnemy = new PictureBox();
            _nameLabelEnemy = new Label();
            _manaBarsPanelEnemy = new Panel();
            _manaCountWaterLabelEnemy = new Label();
            _manaCountAirLabelEnemy = new Label();
            _manaCountFireLabelEnemy = new Label();
            _manaCountEarthLabelEnemy = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_iconPictureBoxPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_iconPictureBoxEnemy).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(895, 954);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 0;
            button1.Text = "Перегенерировать доску";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1427, 1078);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cardBG;
            pictureBox1.Location = new Point(0, 100);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 980);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cardBG;
            pictureBox2.Location = new Point(1410, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(510, 980);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // _manaBarsPanelPlayer
            // 
            _manaBarsPanelPlayer.BackColor = Color.FromArgb(25, 23, 24);
            _manaBarsPanelPlayer.Location = new Point(307, 208);
            _manaBarsPanelPlayer.Name = "_manaBarsPanelPlayer";
            _manaBarsPanelPlayer.Size = new Size(180, 200);
            _manaBarsPanelPlayer.TabIndex = 5;
            // 
            // _manaCountWaterLabelPlayer
            // 
            _manaCountWaterLabelPlayer.BackColor = Color.Transparent;
            _manaCountWaterLabelPlayer.Font = new Font("Century Gothic", 10F);
            _manaCountWaterLabelPlayer.ForeColor = SystemColors.AppWorkspace;
            _manaCountWaterLabelPlayer.Location = new Point(456, 453);
            _manaCountWaterLabelPlayer.Name = "_manaCountWaterLabelPlayer";
            _manaCountWaterLabelPlayer.Size = new Size(37, 29);
            _manaCountWaterLabelPlayer.TabIndex = 6;
            _manaCountWaterLabelPlayer.Text = "123";
            _manaCountWaterLabelPlayer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _manaCountAirLabelPlayer
            // 
            _manaCountAirLabelPlayer.BackColor = Color.Transparent;
            _manaCountAirLabelPlayer.Font = new Font("Century Gothic", 10F);
            _manaCountAirLabelPlayer.ForeColor = SystemColors.AppWorkspace;
            _manaCountAirLabelPlayer.Location = new Point(403, 453);
            _manaCountAirLabelPlayer.Name = "_manaCountAirLabelPlayer";
            _manaCountAirLabelPlayer.Size = new Size(37, 29);
            _manaCountAirLabelPlayer.TabIndex = 7;
            _manaCountAirLabelPlayer.Text = "123";
            _manaCountAirLabelPlayer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _manaCountFireLabelPlayer
            // 
            _manaCountFireLabelPlayer.BackColor = Color.Transparent;
            _manaCountFireLabelPlayer.Font = new Font("Century Gothic", 10F);
            _manaCountFireLabelPlayer.ForeColor = SystemColors.AppWorkspace;
            _manaCountFireLabelPlayer.Location = new Point(351, 453);
            _manaCountFireLabelPlayer.Name = "_manaCountFireLabelPlayer";
            _manaCountFireLabelPlayer.Size = new Size(37, 29);
            _manaCountFireLabelPlayer.TabIndex = 8;
            _manaCountFireLabelPlayer.Text = "123";
            _manaCountFireLabelPlayer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _manaCountEarthLabelPlayer
            // 
            _manaCountEarthLabelPlayer.BackColor = Color.Transparent;
            _manaCountEarthLabelPlayer.Font = new Font("Century Gothic", 10F);
            _manaCountEarthLabelPlayer.ForeColor = SystemColors.AppWorkspace;
            _manaCountEarthLabelPlayer.Location = new Point(301, 453);
            _manaCountEarthLabelPlayer.Name = "_manaCountEarthLabelPlayer";
            _manaCountEarthLabelPlayer.Size = new Size(37, 29);
            _manaCountEarthLabelPlayer.TabIndex = 9;
            _manaCountEarthLabelPlayer.Text = "123";
            _manaCountEarthLabelPlayer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(330, 57);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(97, 23);
            DrawButton.TabIndex = 10;
            DrawButton.Text = "DrawButton";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // _nameLabelPlayer
            // 
            _nameLabelPlayer.BackColor = Color.Transparent;
            _nameLabelPlayer.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _nameLabelPlayer.ForeColor = SystemColors.AppWorkspace;
            _nameLabelPlayer.Location = new Point(21, 156);
            _nameLabelPlayer.Name = "_nameLabelPlayer";
            _nameLabelPlayer.Size = new Size(284, 39);
            _nameLabelPlayer.TabIndex = 11;
            _nameLabelPlayer.Text = "Имя персонажа";
            // 
            // _iconPictureBoxPlayer
            // 
            _iconPictureBoxPlayer.BackColor = Color.Transparent;
            _iconPictureBoxPlayer.Location = new Point(19, 211);
            _iconPictureBoxPlayer.Name = "_iconPictureBoxPlayer";
            _iconPictureBoxPlayer.Size = new Size(270, 270);
            _iconPictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            _iconPictureBoxPlayer.TabIndex = 12;
            _iconPictureBoxPlayer.TabStop = false;
            // 
            // _iconPictureBoxEnemy
            // 
            _iconPictureBoxEnemy.BackColor = Color.Transparent;
            _iconPictureBoxEnemy.Location = new Point(1429, 212);
            _iconPictureBoxEnemy.Name = "_iconPictureBoxEnemy";
            _iconPictureBoxEnemy.Size = new Size(270, 270);
            _iconPictureBoxEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            _iconPictureBoxEnemy.TabIndex = 19;
            _iconPictureBoxEnemy.TabStop = false;
            // 
            // _nameLabelEnemy
            // 
            _nameLabelEnemy.BackColor = Color.Transparent;
            _nameLabelEnemy.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _nameLabelEnemy.ForeColor = SystemColors.AppWorkspace;
            _nameLabelEnemy.Location = new Point(1430, 156);
            _nameLabelEnemy.Name = "_nameLabelEnemy";
            _nameLabelEnemy.Size = new Size(284, 39);
            _nameLabelEnemy.TabIndex = 18;
            _nameLabelEnemy.Text = "Имя персонажа";
            // 
            // _manaBarsPanelEnemy
            // 
            _manaBarsPanelEnemy.BackColor = Color.FromArgb(25, 23, 24);
            _manaBarsPanelEnemy.Location = new Point(1717, 209);
            _manaBarsPanelEnemy.Name = "_manaBarsPanelEnemy";
            _manaBarsPanelEnemy.Size = new Size(180, 200);
            _manaBarsPanelEnemy.TabIndex = 13;
            // 
            // _manaCountWaterLabelEnemy
            // 
            _manaCountWaterLabelEnemy.BackColor = Color.Transparent;
            _manaCountWaterLabelEnemy.Font = new Font("Century Gothic", 10F);
            _manaCountWaterLabelEnemy.ForeColor = SystemColors.AppWorkspace;
            _manaCountWaterLabelEnemy.Location = new Point(1866, 454);
            _manaCountWaterLabelEnemy.Name = "_manaCountWaterLabelEnemy";
            _manaCountWaterLabelEnemy.Size = new Size(37, 29);
            _manaCountWaterLabelEnemy.TabIndex = 14;
            _manaCountWaterLabelEnemy.Text = "123";
            _manaCountWaterLabelEnemy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _manaCountAirLabelEnemy
            // 
            _manaCountAirLabelEnemy.BackColor = Color.Transparent;
            _manaCountAirLabelEnemy.Font = new Font("Century Gothic", 10F);
            _manaCountAirLabelEnemy.ForeColor = SystemColors.AppWorkspace;
            _manaCountAirLabelEnemy.Location = new Point(1813, 454);
            _manaCountAirLabelEnemy.Name = "_manaCountAirLabelEnemy";
            _manaCountAirLabelEnemy.Size = new Size(37, 29);
            _manaCountAirLabelEnemy.TabIndex = 15;
            _manaCountAirLabelEnemy.Text = "123";
            _manaCountAirLabelEnemy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _manaCountFireLabelEnemy
            // 
            _manaCountFireLabelEnemy.BackColor = Color.Transparent;
            _manaCountFireLabelEnemy.Font = new Font("Century Gothic", 10F);
            _manaCountFireLabelEnemy.ForeColor = SystemColors.AppWorkspace;
            _manaCountFireLabelEnemy.Location = new Point(1761, 454);
            _manaCountFireLabelEnemy.Name = "_manaCountFireLabelEnemy";
            _manaCountFireLabelEnemy.Size = new Size(37, 29);
            _manaCountFireLabelEnemy.TabIndex = 16;
            _manaCountFireLabelEnemy.Text = "123";
            _manaCountFireLabelEnemy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _manaCountEarthLabelEnemy
            // 
            _manaCountEarthLabelEnemy.BackColor = Color.Transparent;
            _manaCountEarthLabelEnemy.Font = new Font("Century Gothic", 10F);
            _manaCountEarthLabelEnemy.ForeColor = SystemColors.AppWorkspace;
            _manaCountEarthLabelEnemy.Location = new Point(1711, 454);
            _manaCountEarthLabelEnemy.Name = "_manaCountEarthLabelEnemy";
            _manaCountEarthLabelEnemy.Size = new Size(37, 29);
            _manaCountEarthLabelEnemy.TabIndex = 17;
            _manaCountEarthLabelEnemy.Text = "123";
            _manaCountEarthLabelEnemy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            BackgroundImage = Properties.Resources.фон_1;
            ClientSize = new Size(1920, 1080);
            Controls.Add(_iconPictureBoxEnemy);
            Controls.Add(_nameLabelEnemy);
            Controls.Add(_manaBarsPanelEnemy);
            Controls.Add(_manaCountWaterLabelEnemy);
            Controls.Add(_manaCountAirLabelEnemy);
            Controls.Add(_manaCountFireLabelEnemy);
            Controls.Add(_manaCountEarthLabelEnemy);
            Controls.Add(_iconPictureBoxPlayer);
            Controls.Add(_nameLabelPlayer);
            Controls.Add(_manaBarsPanelPlayer);
            Controls.Add(DrawButton);
            Controls.Add(_manaCountWaterLabelPlayer);
            Controls.Add(_manaCountAirLabelPlayer);
            Controls.Add(_manaCountFireLabelPlayer);
            Controls.Add(_manaCountEarthLabelPlayer);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Form2";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_iconPictureBoxPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)_iconPictureBoxEnemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel _manaBarsPanelPlayer;
        private Label _manaCountWaterLabelPlayer;
        private Label _manaCountAirLabelPlayer;
        private Label _manaCountFireLabelPlayer;
        private Label _manaCountEarthLabelPlayer;
        private Button DrawButton;
        private Label _nameLabelPlayer;
        private PictureBox _iconPictureBoxPlayer;
        private PictureBox _iconPictureBoxEnemy;
        private Label _nameLabelEnemy;
        private Panel _manaBarsPanelEnemy;
        private Label _manaCountWaterLabelEnemy;
        private Label _manaCountAirLabelEnemy;
        private Label _manaCountFireLabelEnemy;
        private Label _manaCountEarthLabelEnemy;
    }
}