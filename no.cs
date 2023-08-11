//My first c# program without looking i tooka help from chargbt but i did it my self bruhh
//Rudy was walking and he found a beast infront of him about t o atk him 
//let the battle begain

using System;

public class Wizard
{
        public string name;
        public string spell;
        public string spell2;
        public int mana;
      
        public int ehealth = 10;
        public int rhealth = 10;

        public Wizard()
                {
                        mana = 10;
                }

        
        public void Callspell(int manacost , int Damage, string spellname)
        {
        
           if(mana >= manacost)
          {
                Console.WriteLine($"casting {spellname}");
                        mana -= manacost;
                        ehealth -= Damage;
                        rhealth -= 7;
                        Console.WriteLine($"YOU DID {Damage} DAMAGE");
                        Console.WriteLine(" ENEMY DID 7 DAMAGE");
                       
          }

        }
        public bool isalive()
        {
                return (rhealth > 0);
        }

        public bool eisalive()
        {
                return (ehealth > 0);
        }

        
        
     
}

        Wizard rudy = new Wizard();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Rudy saw a Enemy");
        Console.ForegroundColor = ConsoleColor.White;

        do{
        Console.WriteLine($"  Enemy health: {rudy.ehealth}");
                                                   Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine($"  YOUR Health: {rudy.rhealth}");
                                                   Console.ForegroundColor = ConsoleColor.White;

                        

         Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"  Mana: {rudy.mana}");
         Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("1 for quagmire  mana cost:1 Damage: 4\n2 for water magic cost cost: 2 Damage: 6\n3 for Healing magic");
        Console.WriteLine("-------------------------------------------------------------------");

        int cast = Convert.ToInt32(Console.ReadLine());
                switch (cast)
                {
                        case 1:
                                rudy.Callspell(2,4,"Quagmire");
                        break;

                        case 2:
                                rudy.Callspell(4,6,"water spell");
                        break;

                        case 3:
                        rudy.rhealth += 14;
                       
                       rudy.Callspell(0,0,"Healing");
                      
                      Console.ForegroundColor =  ConsoleColor.Magenta;
                        Console.WriteLine($"YOU HEALED 14 HEALTH");
                      Console.ForegroundColor =  ConsoleColor.White;

                        default:
                        Console.WriteLine("you didn't cast any magic");
                        break;

               }
        
        Console.WriteLine("-------------------------------------------------------------------");

        }while (rudy.isalive() && rudy.eisalive());

if(rudy.ehealth <= 0)
{

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enemy is dead CONGRATE!!!");
        Console.ForegroundColor = ConsoleColor.White;
}else{
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("YOU ARE dead CONGRATE!!!");
        Console.ForegroundColor = ConsoleColor.White;
}
