namespace AbstractFactory
{
    partial class UCFood
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFood));
            btnCarnivore = new Button();
            btnOmnivore = new Button();
            btnHerbivore = new Button();
            button1 = new Button();
            lblName = new Label();
            pBAnimal = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBAnimal).BeginInit();
            SuspendLayout();
            // 
            // btnCarnivore
            // 
            btnCarnivore.BackColor = Color.SaddleBrown;
            btnCarnivore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarnivore.ForeColor = Color.White;
            btnCarnivore.Location = new Point(141, 29);
            btnCarnivore.Name = "btnCarnivore";
            btnCarnivore.Size = new Size(105, 42);
            btnCarnivore.TabIndex = 0;
            btnCarnivore.Text = "Carnivore";
            btnCarnivore.UseVisualStyleBackColor = false;
            btnCarnivore.Click += btnCarnivore_Click;
            // 
            // btnOmnivore
            // 
            btnOmnivore.BackColor = Color.DarkBlue;
            btnOmnivore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOmnivore.ForeColor = Color.AntiqueWhite;
            btnOmnivore.Location = new Point(282, 29);
            btnOmnivore.Name = "btnOmnivore";
            btnOmnivore.Size = new Size(105, 42);
            btnOmnivore.TabIndex = 1;
            btnOmnivore.Text = "Omnivore";
            btnOmnivore.UseVisualStyleBackColor = false;
            btnOmnivore.Click += btnOmnivore_Click;
            // 
            // btnHerbivore
            // 
            btnHerbivore.BackColor = Color.DarkGreen;
            btnHerbivore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHerbivore.ForeColor = Color.AntiqueWhite;
            btnHerbivore.Location = new Point(422, 29);
            btnHerbivore.Name = "btnHerbivore";
            btnHerbivore.Size = new Size(105, 42);
            btnHerbivore.TabIndex = 2;
            btnHerbivore.Text = "Herbivore";
            btnHerbivore.UseVisualStyleBackColor = false;
            btnHerbivore.Click += btnHerbivore_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(61, 29);
            button1.Name = "button1";
            button1.Size = new Size(54, 42);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.DarkGoldenrod;
            lblName.Font = new Font("DVN - Fredoka", 21.7499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Cornsilk;
            lblName.Location = new Point(-5, 280);
            lblName.Name = "lblName";
            lblName.Size = new Size(290, 36);
            lblName.TabIndex = 5;
            lblName.Text = "Choose to have a pet";
            // 
            // pBAnimal
            // 
            pBAnimal.BackColor = Color.Transparent;
            pBAnimal.BackgroundImageLayout = ImageLayout.Stretch;
            pBAnimal.Location = new Point(303, 154);
            pBAnimal.Name = "pBAnimal";
            pBAnimal.Size = new Size(310, 273);
            pBAnimal.TabIndex = 4;
            pBAnimal.TabStop = false;
            // 
            // UCFood
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblName);
            Controls.Add(pBAnimal);
            Controls.Add(button1);
            Controls.Add(btnHerbivore);
            Controls.Add(btnOmnivore);
            Controls.Add(btnCarnivore);
            Name = "UCFood";
            Size = new Size(661, 466);
            ((System.ComponentModel.ISupportInitialize)pBAnimal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarnivore;
        private Button btnOmnivore;
        private Button btnHerbivore;
        private Button button1;
        private Label lblName;
        private PictureBox pBAnimal;
    }
}
