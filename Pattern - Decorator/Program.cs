using System;

namespace Pattern___Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Item sword = new MeeleWeapon(new Stats(10, 10, 10), Quality.Common);
            sword = new CorruptedItem(sword);
            WriteItemDescription(sword);

            Item grail = new RangeWeapon(new Stats(1, 1, 1), Quality.Mythical);
            grail = new HolyItem(grail);
            WriteItemDescription(grail);


            Console.WriteLine("CREATING ARMOR");
            Item helmet = new Armor(new Stats(5, 5, 5), Quality.Common);
            WriteItemDescription(helmet);

            Console.WriteLine("ENCHANT ARMOR FOR SPEED");
            helmet = new QuickItem(helmet);
            WriteItemDescription(helmet);

            Console.WriteLine("ENCHANT ARMOR FOR WISDOM");
            helmet = new DumbItem(helmet);
            WriteItemDescription(helmet);
            Console.WriteLine("BAD LUCK!");
            Console.WriteLine("THIS ARMOR MAKES YOU DUMBER, HAHA !");

        }

        public static void WriteItemDescription(Item item)
        {
            Stats stats = item.GetStats();

            Console.WriteLine($"Description : {item.GetDescription()}");
            Console.WriteLine($"Quality : {item.GetQuality()}");
            Console.WriteLine("Stats");
            Console.WriteLine($"Strenght : {stats.strenght}");
            Console.WriteLine($"Agility : {stats.agility}");
            Console.WriteLine($"Intelligence : {stats.intelligence}");
            Console.WriteLine("");
        }
    }
}
