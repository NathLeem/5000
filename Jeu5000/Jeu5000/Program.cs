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
            string player1 = new string("");
            string player2 = new string("");
            string player3 = new string("");
            string player4 = new string("");
            string player5 = new string("");
            int NbreJoueur;
            int[,] tablDes = new int[5,5];

            Console.WriteLine("-------------");
            Console.Write("|");
            Console.Write("Jeu du 5000");
            Console.WriteLine("|");
            Console.WriteLine("-------------");
            Console.WriteLine("Règles du jeu");
            Console.WriteLine("////");

            Console.WriteLine("Combien de joueurs vont jouer ?");
            NbreJoueur = int.Parse(Console.ReadLine());

            ChoixNbreJoueur(NbreJoueur, ref player1, ref player2, ref player3, ref player4, ref player5);

            Console.WriteLine($"1er Joueur: {player1}");
            Console.WriteLine($"2eme joueur:{player2}");
            Console.WriteLine($"3eme joueur: {player3}");
            Console.WriteLine($"4eme joueur: {player4}");
            Console.WriteLine($"5eme joueur: {player5}");

            Console.ReadLine();
        }
        static void ChoixNbreJoueur(int NbreJoueur, ref string player1, ref string player2, ref string player3, ref string player4, ref string player5)
        {
            if (NbreJoueur >= 2)
            {
                Console.WriteLine("Veuillez entrer le prénom du premier joueur");
                player1 = Console.ReadLine();
                Console.WriteLine("Veuillez entrer le prénom du deuxième joueur");
                player2 = Console.ReadLine();
            }
            if (NbreJoueur >= 3)
            {
                Console.WriteLine("Veuillez entrer le prénom du troisième joueur");
                player3 = Console.ReadLine();
            }
            if (NbreJoueur >= 4)
            {
                Console.WriteLine("Veuillez entrer le prénom du quatrième joueur");
                player4 = Console.ReadLine();
            }
            if (NbreJoueur >= 5)
            {
                Console.WriteLine("Veuillez entrer le prénom du cinquième joueur");
                player5 = Console.ReadLine();
            }

            Console.ReadLine();
        }
        static void lancerDes(int[,] tablDes,int NbreJoueur)
        {
            NbreJoueur = 
        }
        static void AfficheTableau()
        {

        }
    }
}