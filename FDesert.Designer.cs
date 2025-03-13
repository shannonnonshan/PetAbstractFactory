using AbstractFactory.Factory;

namespace AbstractFactory
{
    partial class FDesert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDesert));
            IAnimalFactory factory = new DesertAnimalFactory();
            ucFood1 = new UCFood(factory);
            SuspendLayout();
            // 
            // ucFood1
            // 
            ucFood1.BackColor = Color.Transparent;
            ucFood1.Location = new Point(63, -10);
            ucFood1.Name = "ucFood1";
            ucFood1.Size = new Size(661, 466);
            ucFood1.TabIndex = 0;
            // 
            // FDesert
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ucFood1);
            Name = "FDesert";
            Text = "FDesert";
            ResumeLayout(false);
        }

        #endregion


        private UCFood ucFood1;
    }
}