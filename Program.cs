namespace AbstractFactory
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            IAnimalFactory carnivoreFactory = new CarnivoreFactory();
            IAnimalFactory omnivoreFactory = new OmnivoreFactory();

            Console.WriteLine("Carnivores:");
            Console.WriteLine($"House Pet: {carnivoreFactory.CreateHousePet().GetImage()} {carnivoreFactory.CreateHousePet().GetName()}");
            Console.WriteLine($"Small Wild Animal: {carnivoreFactory.CreateSmallWildAnimal().GetImage()} {carnivoreFactory.CreateSmallWildAnimal().GetName()}");
            Console.WriteLine($"Desert Animal: {carnivoreFactory.CreateDesertAnimal().GetImage()} {carnivoreFactory.CreateDesertAnimal().GetName()}");

            Console.WriteLine("\nOmnivores:");
            Console.WriteLine($"House Pet: {omnivoreFactory.CreateHousePet().GetImage()} {omnivoreFactory.CreateHousePet().GetName()}");
            Console.WriteLine($"Small Wild Animal: {omnivoreFactory.CreateSmallWildAnimal().GetImage()} {omnivoreFactory.CreateSmallWildAnimal().GetName()}");
            Console.WriteLine($"Desert Animal: {omnivoreFactory.CreateDesertAnimal().GetImage()} {omnivoreFactory.CreateDesertAnimal().GetName()}");
        }
    }
}