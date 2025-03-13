using AbstractFactory.Animal;
using AbstractFactory.Factory;
using System.Diagnostics;

namespace AbstractFactory
{
    internal static class Program
    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //IAnimalFactory carnivoreFactory = new CarnivoreFactory();
            //IAnimalFactory omnivoreFactory = new OmnivoreFactory();

            //Console.WriteLine("Carnivores:");
            //Console.WriteLine($"House Pet: {carnivoreFactory.CreateHousePet().GetImage()} {carnivoreFactory.CreateHousePet().GetName()}");
            //Console.WriteLine($"Small Wild Animal: {carnivoreFactory.CreateSmallWildAnimal().GetImage()} {carnivoreFactory.CreateSmallWildAnimal().GetName()}");
            //Console.WriteLine($"Desert Animal: {carnivoreFactory.CreateDesertAnimal().GetImage()} {carnivoreFactory.CreateDesertAnimal().GetName()}");

            //Console.WriteLine("\nOmnivores:");
            //Console.WriteLine($"House Pet: {omnivoreFactory.CreateHousePet().GetImage()} {omnivoreFactory.CreateHousePet().GetName()}");
            //Console.WriteLine($"Small Wild Animal: {omnivoreFactory.CreateSmallWildAnimal().GetImage()} {omnivoreFactory.CreateSmallWildAnimal().GetName()}");
            //Console.WriteLine($"Desert Animal: {omnivoreFactory.CreateDesertAnimal().GetImage()} {omnivoreFactory.CreateDesertAnimal().GetName()}");

            //Form1 form = new Form1(); // Tạo Form1
            //IAnimalFactory factory = new DesertAnimalFactory();
            //ICarnivore carnivore = factory.CreateCarnivore();
            //IHerbivore herbivore = factory.CreateHerbivore();
            //IOmnivore omnivore = factory.CreateIOmnivore();

            //// Hiển thị kết quả trên Form1
            //form.ShowOutput("Dessert Animal Information");
            //form.ShowOutput("Carnivore: " + carnivore.GetName());
            //form.ShowOutput("Herbivore: " + herbivore.GetName());
            //form.ShowOutput("Omnivore: " + omnivore.GetName());

            //Application.Run(form); 

            MainPage mainPage = new MainPage();
            Application.Run(mainPage);

        }
    }
}