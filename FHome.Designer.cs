using AbstractFactory.Factory;

namespace AbstractFactory
{
    partial class FHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHome));
            IAnimalFactory factory = new HousePetFactory();
            ucFood1 = new UCFood(factory);
            SuspendLayout();
            // 
            // ucFood1
            // 
            ucFood1.BackColor = Color.Transparent;
            ucFood1.Location = new Point(73, 12);
            ucFood1.Name = "ucFood1";
            ucFood1.Size = new Size(656, 426);
            ucFood1.TabIndex = 0;
            // 
            // FHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ucFood1);
            Name = "FHome";
            Text = "FHome";
            ResumeLayout(false);
        }

        #endregion
        private UCFood ucFood1;
    }
}