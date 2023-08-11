
using System;

public class Wizard
{
        public string name;
        public string spell;
        public string spell2;
        public int mana;
      
        public int health = 10;
        public int rhealth = 10;

        public Wizard()
                {
                        mana = 10;
                }
        
        public void Callspell()
        {
          int cast = Convert.ToInt32(Console.ReadLine());
                switch (cast)
                {
                        case 1:
                        Console.WriteLine($"casting quagmire haaa");
                        mana--;
                        health -= 4;
                        Console.WriteLine("YOU DID 4 DAMAGE");
                        Console.WriteLine($"Enemy Health: {health}");
                        Console.WriteLine($"Mana:{mana}");
                        
                        break;

                        case 2:
                        Console.WriteLine("casting water magic");
                        mana = mana - 2;
                        Console.WriteLine("YOU DID 6 DAMAGE");
                        health -= 6;
                        Console.WriteLine($"Enemy Health: {health}");
                        Console.WriteLine($"Mana:{mana}");
                      
                        break;

                        default:
                        Console.WriteLine("you didn't cast any magic");
                        break;

               }
        }
}

        Wizard rudy = new Wizard();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Rudy saw a Enemy");
        Console.ForegroundColor = ConsoleColor.White;

        do{
        Console.WriteLine($"Enemy health: {rudy.health}");

         Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Mana: {rudy.mana}");
         Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("1 for quagmire  mana cost:1 Damage: 4\n2 for water magic cost cost: 2 Damage: 6");
        Console.WriteLine("-------------------------------------------------------------------");

      
        rudy.Callspell();
        Console.WriteLine("-------------------------------------------------------------------");

        }while (rudy.health > 0);

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enemy is dead CONGRATE!!!");
        Console.ForegroundColor = ConsoleColor.White;
