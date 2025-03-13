using AbstractFactory.Animal;
using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class UCFood : UserControl
    {
        private IAnimalFactory animalFactory;
        private ICarnivore carnivore;
        private IHerbivore herbivore;
        private IOmnivore omnivore;
        private Button selectedButton;
        public UCFood()
        {
            InitializeComponent();
        }

        // Constructor có tham số
        public UCFood(IAnimalFactory factory) : this()
        {
            this.animalFactory = factory;
            this.carnivore = factory.CreateCarnivore();
            this.herbivore = factory.CreateHerbivore();
            this.omnivore = factory.CreateIOmnivore();
        }
        private void btnOmnivore_Click(object sender, EventArgs e)
        {
            omnivore = animalFactory.CreateIOmnivore();
            ShowAnimal(omnivore.GetName(), omnivore.GetImage());
            ChangeButtonStyle((Button)sender);
        }

        private void btnCarnivore_Click(object sender, EventArgs e)
        {
            carnivore = animalFactory.CreateCarnivore();
            ShowAnimal(carnivore.GetName(), carnivore.GetImage());
            ChangeButtonStyle((Button)sender);
        }

        private void btnHerbivore_Click(object sender, EventArgs e)
        {
            herbivore = animalFactory.CreateHerbivore();
            ShowAnimal(herbivore.GetName(), herbivore.GetImage());
            ChangeButtonStyle((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainPage)
                {
                    form.Show();  // Hiện lại MainPage
                    this.ParentForm?.Close();  // Đóng Form hiện tại
                    return;
                }
            }

            // Nếu không tìm thấy, tạo mới (phòng trường hợp MainPage đã đóng)
            MainPage mainForm = new MainPage();
            mainForm.Show();
            this.ParentForm?.Close();
        }
        private void ShowAnimal(string animalName, Image animalImage)
        {
            lblName.Text = animalName;  // Cập nhật tên vào Label
            pBAnimal.BackgroundImage = animalImage;  // Cập nhật hình ảnh vào PictureBox
        }
        private void ChangeButtonStyle(Button clickedButton)
        {
            // Nếu có nút được chọn trước đó, khôi phục màu gốc của nó
            if (selectedButton != null && selectedButton.Tag is Color originalColor)
            {
                selectedButton.BackColor = originalColor;
            }

            // Lưu màu hiện tại của button vào `Tag` trước khi thay đổi màu
            clickedButton.Tag = clickedButton.BackColor;

            // Cập nhật button mới được chọn
            selectedButton = clickedButton;
            selectedButton.BackColor = Color.LightGray; // Màu nhạt khi được chọn
        }
    }
}
