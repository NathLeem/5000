using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_leemans_nathan
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1;
            string player2;
            string player3;
            string player4;
            string player5;


            Console.WriteLine("-------------");
            Console.Write("|");
            Console.Write("Jeu du 5000");
            Console.WriteLine("|");
            Console.WriteLine("-------------");
            Console.WriteLine("Règles du jeu");
            Console.WriteLine("////");

            ChoixNbreJoueur(player1,player2,player3,player4,player5);
            
            Console.ReadLine();
        }
        static void ChoixNbreJoueur(int NbreJoueur)
        {
            string player1;
            string player2;
            string player3;
            string player4;
            string player5;
            

            Console.WriteLine("Combien de joueurs vont jouer ?");
            NbreJoueur = int.Parse(Console.ReadLine());

            if (NbreJoueur == 2)
            {
                Console.WriteLine("Veuillez entrer le prénom du premier joueur");
                player1 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du deuxième joueur");
                player2 = Console.ReadLine();
            }
            if (NbreJoueur == 3)
            {
                Console.WriteLine("Veuillez entrer le prénom du premier joueur");
                player1 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du deuxième joueur");
                player2 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du troisième joueur");
                player3 = Console.ReadLine();
            }
            if (NbreJoueur == 4)
            {
                Console.WriteLine("Veuillez entrer le prénom du premier joueur");
                player1 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du deuxième joueur");
                player2 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du troisième joueur");
                player3 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du quatrième joueur");
                player4 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Veuillez entrer le prénom du premier joueur");
                player1 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du deuxième joueur");
                player2 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du troisième joueur");
                player3 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du quatrième joueur");
                player4 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du cinquième joueur");
                player5 = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
