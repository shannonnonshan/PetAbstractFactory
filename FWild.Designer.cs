using AbstractFactory.Factory;

namespace AbstractFactory
{
    partial class FWild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWild));
            IAnimalFactory factory = new SmallWildFactory();
            ucFood2 = new UCFood(factory);
            SuspendLayout();
            // 
            // ucFood2
            // 
            ucFood2.BackColor = Color.Transparent;
            ucFood2.Location = new Point(90, 12);
            ucFood2.Name = "ucFood2";
            ucFood2.Size = new Size(661, 466);
            ucFood2.TabIndex = 0;
            // 
            // FWild
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ucFood2);
            Name = "FWild";
            Text = "FWild";
            Load += FWild_Load;
            ResumeLayout(false);
        }

        #endregion

        private UCFood ucFood2;
    }
}