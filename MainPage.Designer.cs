namespace AbstractFactory
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            lblHeader = new Label();
            btnHouse = new Button();
            btnWild = new Button();
            btnDesert = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Mollie Rocky DEMO", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Tomato;
            lblHeader.Location = new Point(135, 44);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(232, 28);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Chooose the habitat";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHouse
            // 
            btnHouse.BackColor = Color.LightCoral;
            btnHouse.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHouse.ForeColor = Color.Snow;
            btnHouse.Location = new Point(393, 37);
            btnHouse.Name = "btnHouse";
            btnHouse.Size = new Size(86, 44);
            btnHouse.TabIndex = 1;
            btnHouse.Text = "House";
            btnHouse.UseVisualStyleBackColor = false;
            btnHouse.Click += btnHouse_Click;
            // 
            // btnWild
            // 
            btnWild.BackColor = Color.DarkGreen;
            btnWild.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWild.ForeColor = Color.Snow;
            btnWild.Location = new Point(485, 37);
            btnWild.Name = "btnWild";
            btnWild.Size = new Size(86, 44);
            btnWild.TabIndex = 2;
            btnWild.Text = "Wild";
            btnWild.UseVisualStyleBackColor = false;
            btnWild.Click += btnWild_Click;
            // 
            // btnDesert
            // 
            btnDesert.BackColor = Color.BurlyWood;
            btnDesert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesert.ForeColor = Color.Snow;
            btnDesert.Location = new Point(577, 37);
            btnDesert.Name = "btnDesert";
            btnDesert.Size = new Size(86, 44);
            btnDesert.TabIndex = 3;
            btnDesert.Text = "Desert";
            btnDesert.UseVisualStyleBackColor = false;
            btnDesert.Click += button1_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDesert);
            Controls.Add(btnWild);
            Controls.Add(btnHouse);
            Controls.Add(lblHeader);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnHouse;
        private Button btnWild;
        private Button btnDesert;
    }
}