namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Weight in Pounds (lb) >> ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Weight in Pounds (lb): {0}", pounds);
            Console.WriteLine("Weight converted to Kilograms (kg): " + pounds * 0.45359237);
            Console.WriteLine("=================================");

            Console.Write("Enter distance in Miles (mi) >> ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Distance in Miles (mi): {0}", miles);
            Console.WriteLine("Distance in Kilometers (km): " + miles * 1.60934);
            Console.WriteLine("=================================");

            Console.Write("Enter temperature in Fahrenheit (°F) >> ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature in Farenheit (°F): {0}", temp);
            Console.WriteLine("Temperature in Celsius (°C): " + (temp - 32) * 0.5555555556);
            Console.WriteLine("=================================");
            */
            int count = 1;
            double sum = 0;
            double[] students = new double[10];
            for(int i = 0; i < students.Length; i++) {
            Console.Write($"Enter Age for student #{count+i} >> ");
            students[i] = Convert.ToDouble(Console.ReadLine());
            sum += students[i];
            }
            for(int i = 0; i < students.Length;i++)
            {
            Console.WriteLine("Display the ages of all the students:", students[i]);

            }
            Console.WriteLine("The average age of the students is: "+sum/students.Length);
            Console.Write("=================================");

            String[] Cnames = { "Charles", "Dave", "Juliet", "Jack", "Steve" };
            String[] Enames = { "Excalibur", "Zalroth's Bow", "Straw Hat", "Staff of Thorns", "Dragon Slayer" };
            String[] Inames = { "Knight's armor", "Dragon's breath", "Potion of invisibility", "Traveller's Compass", "Enchanted Book of Azazel" };
            String[] Anames = { "Bane of Arthropods", "Redo-Healing", "Spell Casting", "Deploys the Shells", "Warrior's Rage" };

            string story = $@"
In the mystical land of Frieren, five adventurers embarked on a 10 year journey. {Cnames[0]}, the noble knight, equipped with the {Inames[0]}, {Enames[1]}, a blade only wielded to those who are worthy, 
said to be the {Anames[0]} that dared to threaten the realm. By his side, {Cnames[1]}, the skilled archer, wielded {Enames[1]}, a weapon for precision and accuracy, enchanted with the {Inames[1]}. 
Experienced {Anames[1]}, as his secondary offense. Guiding the party through treacherous terrain was {Cnames[2]}, who possessed the {Enames[2]}, {Inames[2]}, {Anames[2]} allowing her to navigate 
unseen past the lurking dangers that awaited them. As they ventured deeper into the heart of Frieren, the adventurers encountered a myriad of challenges. {Cnames[3]}, the enigmatic sorcerer, unveiled 
the secrets of the {Inames[3]}, {Enames[3]} a potent spell capable of unleashing the fury of the ancient dragons themselves. Once out of spells {Anames[3]}.Alongside him, {Cnames[4]}, the stalwart guardian, 
donned the {Enames[4]}, It was too thick to even call it a sword, combined this {Anames[4]}, rendered him nearly invulnerable to the perils that beset them. In their quest to vanquish the malevolent 
forces threatening their homeland, the party uncovered an artifact of immense power {Inames[4]}. Little did they know that this tome held the key to unlocking abilities beyond their wildest imaginations, 
propelling them towards a destiny that would forever alter the fate of Frieren.
";
            Console.WriteLine(story);
            Console.WriteLine("=================================");

            Console.Write("Enter a pattern number >> ");
            int pattern1 = Convert.ToInt32(Console.ReadLine());

            if(pattern1 <= 0)
            {
                Console.WriteLine("Invalid input");
            } else
            {
                for (int i = 1; i <= pattern1; i++)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("=================================");

            Console.Write("Enter a pattern number >> ");
            int pattern2 = Convert.ToInt32(Console.ReadLine());
            int add = 0;
                
            if (pattern2 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= pattern2; i++)
                {
                    add += i;
                }
                Console.WriteLine("Output:"+add);
            }
            Console.WriteLine("=================================");
            
            Console.Write("Enter a pattern number >> ");
            int pattern3 = Convert.ToInt32(Console.ReadLine());
            if (pattern3 <= 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (pattern3 > 0) { }
            {
                for ( int i = 1; i <= pattern3;)
                {
                    for (int j = 1; j <= pattern3;j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                    pattern3--;
                }
            }
        }
    }
}
