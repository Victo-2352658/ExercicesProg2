using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace premierCourProg2
{
    /// <summary>
    /// Une ribambelle de croustillants exercices
    /// </summary>
    public class RevisionP1
    {
      ///<summary>
      ///Exercice 1: doit afficher "allo p2"
      /// </summary>  
      public static void Exercice1()
        {
            Console.WriteLine("Allo p2");
        }

        /// <summary>
        /// Exercice 2: Methode qui affiche le premier et le second parametre
        /// </summary>
        /// <param name="premier">premier nombre</param>
        /// <param name="deuxieme">second nombre</param>

        public static void Exercice2(int premier,int deuxieme)
        {
            Console.WriteLine("premier entier: " + premier);
            Console.WriteLine("deuxieme entier: " + deuxieme);
        }

        ///<summary>
        /// exercice 3: Methode qui additionne le premier nombre et le deuxieme nombre et retourne le resultat
        /// <param name="premierNbr">premier nombre</param>
        /// <param name="deuxiemeNbr">second nombre</param>
        ///</summary>
        /// <returns>l'addition des 2 parametres</returns>

        public int Exercice3(int premierNbr, int deuxiemeNbr)
        {
            int resultat = premierNbr + deuxiemeNbr;
            return resultat;
        }

        /// <summary>
        /// exercice 3: Methode qui demande a l'utilisateur un nombre
        /// </summary>
        /// <returns>le nombre de l'utilisateur</returns>
        public int Exercice4()
        {
            Console.WriteLine("Entrez votre nombre: ");
            int utilisateur;
            int.TryParse(Console.ReadLine(), out utilisateur);
            return utilisateur;
        }

        /// <summary>
        /// Exercice 5: Methode qui demande un nombre a l'utilisateur. Si le nombre inferieur a 0, on retourne -1.
        /// Sinon, on retourne le nombre
        /// </summary>
        /// <returns>Retourne -1 si inferieur a 0, retourne le nombre de l'utilisateur si superieur a 0.</returns>
        public int Exercice5()
        {
            Console.WriteLine("Entrez votre nombre: ");
            int nbrUtilisateur;
            int.TryParse(Console.ReadLine(), out nbrUtilisateur);

            if (nbrUtilisateur > 0)
            {
                return -1;
            }
            else
            { 
            return nbrUtilisateur;
            }
        }

        /// <summary>
        /// Exercice 6: Methode qui demande un nombre superieur a 10
        /// a l'utilisateur. Si le nombre est plus petit, alors on redemande
        /// le nombre
        /// </summary>
        /// <returns>Le nombre de l'utilisateur</returns>
        public int Exercice6()
        {
            int nbrUtilisateur = 0;
            while (nbrUtilisateur < 10) { 
            Console.WriteLine("Entrez votre nombre plus grand que 10: ");
            int.TryParse(Console.ReadLine(), out nbrUtilisateur);
            }
            return nbrUtilisateur;
        }

        /// <summary>
        /// Exercice 7: Methode qui fait la division du premier nombre par
        /// le deuxieme nombre. Si la division est par 0, alors elle retourner 0.
        /// Elle revoit aussi le resultat de la division.
        /// </summary>
        /// <param name="premier">Premier nombre</param>
        /// <param name="deuxieme">second nombre</param>
        /// <returns>0 si le deuxieme nombre est 0 et le
        /// resultat de la division</returns>
        public int Exercice7(int premier, int deuxieme)
        {
            int resulat = premier / deuxieme;

            if (deuxieme == 0)
            {
                return 0;
            }
            return resulat;

        }
        /// <summary>
        /// Exercice 8: Methode qui revoit un tableau avec la longueur venant du nombre
        /// en parametre
        /// </summary>
        /// <param name="nombre">Nombre qui va definir la longueur du tableau</param>
        /// <returns>Un tableau avec la longueur defini par le parametre</returns>
        public int[] Exercice8(int nombre)
        {
            nombre = 0;
            int[] tableau = new int[nombre];

            return tableau;
        }

        /// <summary>
        /// Exercice 9: Methode qui prend en parametre un nombre pour la longueur du
        /// tableau, un nombre qui joue le role du nombre minimum et un nombre quoi joue
        /// le role du maximum. La methode prend le premier parametre, cree la longueur et
        /// remplir les cases random entre le parametre minimum et maximum
        /// </summary>
        /// <param name="longueur">Nombre qui va servir de longeueur du tableau</param>
        /// <param name="minimum">Nombre qui va servir de minimum pour le random des cases du tableau</param>
        /// <param name="maximum">Nombre qui va servir de maximum pour le random des cases du tableau</param>
        /// <returns>retourne le tableau avec sa longueur et ses cases remplies aleatoirement</returns>
        public int[] Exercice9(int longueur, int minimum, int maximum)
        {
            int[] tableau = new int[longueur];

            for(int i = 0; i < tableau.Length; i++)
            {
                Random remplir = new Random();
                tableau[i] = remplir.Next(minimum, maximum);
            }
            return tableau;
        }
        /// <summary>
        /// Exercice 10: Methode qui prend en parametre un nombre pour la longueur du
        /// tableau, un nombre qui joue le role du nombre minimum et un nombre quoi joue
        /// le role du maximum. La methode prend le premier parametre, cree la longueur et
        /// remplir les cases random entre le parametre minimum et maximum avec le maximum inclu.
        /// </summary>
        /// <param name="longueur">Longueur du tableau</param>
        /// <param name="premierNbr">Nombre 1 qui va servir a remplir le tableau en random</param>
        /// <param name="deuxiemeNbr">Nombre 2 qui va servir a remplir le tableau en random</param>
        /// <returns>retourne le tableau avec sa longueur et ses cases remplies aleatoirement</returns>
        public int[] Exercice10(int longueur, int premierNbr, int deuxiemeNbr)
        {
            int[] tableau = new int[longueur];
            if (premierNbr >= deuxiemeNbr) { 
                for (int i = 0;i < tableau.Length; i++)
                {
                Random remplir = new Random();
                tableau[i] = remplir.Next(premierNbr, deuxiemeNbr + 1);
                }
            }
            return tableau;
        }
        /// <summary>
        /// Exercice 11: Methode qui prend en parametre un nombre pour la longueur du
        /// tableau, un nombre qui joue le role du nombre minimum et un nombre quoi joue
        /// le role du maximum. La methode prend le premier parametre, cree la longueur et
        /// remplir les cases random entre le parametre minimum et maximum avec le maximum inclu.
        /// Cette methode peut aussi inclure un premier nombre negatif.
        /// </summary>
        /// <param name="longueur">Nombre qui defini la longueur du tableau</param>
        /// <param name="premierNbr">Nombre 1 qui va servir a remplir le tableau en random</param>
        /// <param name="deuxiemeNbr">Nombre 2 qui va servir a remplir le tableau en random</param>
        /// <returns>retourne le tableau avec sa longueur et ses cases remplies aleatoirement</returns>
        public int[] Exercice11(int longueur, int premierNbr, int deuxiemeNbr)
        {
            int[] tableau = new int[longueur];

            if (premierNbr >= deuxiemeNbr || premierNbr > 0 || premierNbr < 0)
            { 
                for (int i = 0; i < tableau.Length; i++)
                {
                Random remplir = new Random();
                tableau[i] = remplir.Next(premierNbr, deuxiemeNbr+1);
            }
            }
            return tableau;
        }

        /// <summary>
        /// Exercice 12: Methode qui prend en parametre un nombre pour la longueur du
        /// tableau, un nombre qui joue le role du nombre minimum et un nombre quoi joue
        /// le role du maximum. La methode prend le premier parametre, cree la longueur et
        /// remplir les cases random entre le parametre minimum et maximum avec le maximum inclu.
        /// Cette methode peut aussi inclure un premier nombre negatif et le premier nombre peut ou
        /// pas etre plus petit ou egal au dexieme nombre
        /// </summary>
        /// <param name="longueur">Nombre qui defini la longueur du tableau</param>
        /// <param name="premierNbr">Nombre 1 qui va servir a remplir le tableau en random</param>
        /// <param name="deuxiemeNbr">Nombre 2 qui va servir a remplir le tableau en random</param>
        /// <returns>retourne le tableau avec sa longueur et ses cases remplies aleatoirement</returns>
        public int[] Exercice12(int longueur, int premierNbr, int deuxiemeNbr)
        {
            int[] tableau = new int[longueur];

            if (premierNbr >= deuxiemeNbr || premierNbr <= deuxiemeNbr || premierNbr > 0 || premierNbr < 0)
            {
                for (int i = 0; i < tableau.Length; i++)
                {
                    Random remplir = new Random();
                    tableau[i] = remplir.Next(premierNbr, deuxiemeNbr + 1);
                }
            }
            return tableau;
        }
        /// <summary>
        /// Exercice 13: Methode qui retourne la somme d'un tableau en
        /// utilisant une boucle for
        /// </summary>
        /// <param name="tableau">Tableau de nombres entiers</param>
        /// <returns>La somme du tableau de nombres</returns>
        public int Exercice13(int[] tableau)
        {
            int somme = 0;
            for(int i = 0;i < tableau.Length; i++)
            {
                somme += tableau[i];
            }
            return somme;
        }
        /// <summary>
        /// Exercice 14: methode qui calcule la somme avec une boucle for
        /// </summary>
        /// <param name="tableau">Tableau de nombres entiers</param>
        /// <returns>Retourne la somme calculer</returns>
        public int Exercice14(int[] tableau)
        {
            int i = 0;
            int somme = 0;
            while (i < tableau.Length)
            {
                somme += tableau[i];
                i++;
            }
            return somme;
        }

        public int Exercice15(int[] tableau)
        {
            int i = 0;
            int somme = 0;
            do
            {
                somme += tableau[i];
                i++;
            }
            while (i < tableau.Length);
            return somme;
        }

        /// <summary>
        /// Exercice 16: Methode qui affiche une forme 3 par 3
        /// </summary>
        public void Exercice16()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Exercice 17: Methode qui affiche une forme en ayant un parametre qui
        /// defini la longueur/largeur(Depend comment on le voit) a l'aide de 2 boucles
        /// for
        /// </summary>
        /// <param name="longueur">Defini la longueur/largeur de la forme</param>
        public void Exercice17(int longueur)
        {
            for (int i = 0; i < longueur; i++)
            {
                for(int j = 0;j < longueur; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Exercice 18: Methode qui affiche une forme en ayant un parametre qui
        /// defini la longueur/largeur(Depend comment on le voit) a l'aide d'une
        /// boucle for et d'une boucle while. La deuxieme boucle est la boucle while.
        /// Cet methode prend la valeur absolue de la longueur si elle est <0.
        /// </summary>
        /// <param name="longueur">Defini la longueur/largeur de la forme</param>
        public void Exercice18(int longueur)
        {
            if(longueur < 0)
            {
                Math.Abs(longueur);
            }
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                while (j < longueur)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                j = 0;
            }
        }
        /// <summary>
        /// Exercice 19: Methode qui affiche une forme en ayant des parametres qui
        /// definissent la longueur et largeur a l'aide de 2 boucles for et affiche
        /// un message d'erreur si la longueur ou largeur est <0.
        /// </summary>
        /// <param name="longueur">Defini la longueur de la forme</param>
        /// <param name="largeur">Defini la largeur de la forme</param>
        public void Exercice19(int longueur, int largeur)
        {
            if(largeur < 0 || longueur < 0)
            {
                Console.WriteLine("Impossible d'afficher parce que...");
            }
            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < longueur; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Exercice 20: Methode qui affiche une forme en ayant des parametres qui
        /// definissent la longueur et largeur a l'aide de 2 boucles for et affiche
        /// un message d'erreur si la longueur ou largeur est <0. Elle prend aussi
        /// un caractere en parametre pour afficher la forme.
        /// </summary>
        /// <param name="longueur">Defini la longueur de la forme</param>
        /// <param name="largeur">Defini la largeur de la forme</param>
        /// <param name="symbol">Defini le caractere a afficher lorsque la forme est dessiner</param>
        public void Exercice20(int longueur, int largeur, char symbol)
        {
            if (largeur < 0 || longueur < 0)
            {
                Console.WriteLine("Impossible d'afficher parce que...");
            }
            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < longueur; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Exercice 21: Methode qui affiche une forme en ayant des parametres qui
        /// definissent la longueur et largeur a l'aide de 2 boucles for et affiche
        /// un message d'erreur si la longueur ou largeur est <0. Elle prend aussi
        /// un caractere en parametre pour afficher la forme et le nombre de fois a
        /// refaire la forme.
        /// </summary>
        /// <param name="largeur">Defini la longueur de la forme</param>
        /// <param name="hauteur">Defini la largeur de la forme</param>
        /// <param name="repetition">Defini le nombre de fois que le programme de refaire la forme</param>
        /// <param name="symbol">Defini le caractere que le programme affichera pour la forme</param>
        public void Exercice21(int largeur, int hauteur, int repetition, char symbol)
        {
            if (largeur < 0 || largeur < 0)
            {
                Console.WriteLine("Impossible d'afficher parce que...");
            }
            for(int r = 0; r < repetition; r++) { 
            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Exercice 22: Methode qui affiche une forme en utilisant le parametre pour
        /// la derniere ranger a l'aide de 2 boucles for
        /// </summary>
        /// <param name="longueur">Defini la longueur que va avoir la derniere ligne de la forme</param>
        public void Exercice22(int longueur)
        {
            for (int i = 0; i <= longueur; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Exercice 23: Methode qui affiche une forme en utilisant le parametre pour
        /// la premiere ranger a l'aide de 2 boucles for
        /// </summary>
        /// <param name="longueur">Defini la longueur de le premiere ranger</param>
        public void Exercice23(int longueur)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < longueur - i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Exercice 24: methode qui affiche une forme en utilisant 2 boucle do while avec un parametre qui indique la longueur de la forme
        /// </summary>
        /// <param name="longueur">Defini la longueur de la forme</param>
        public void Exercice24(int longueur)
        {
            do
            {
                int largeur = longueur;
                do
                {
                    Console.Write('*');
                    largeur--;
                }
                while (largeur > 0);

                Console.WriteLine();
                longueur--;
            }
            while (longueur > 0);
        }
        /// <summary>
        /// Exercice 25: Methode qui utilise des methodes existantes pour former une forme
        /// </summary>
        /// <param name="longueur">Defini la longueur de la forme</param>
        public void Exercice25(int longueur)
        {
            for (int a = 0; a < longueur - 1; a++)
            {
                for (int j = 0; j < longueur - a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= longueur; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Exercice 26: methode qui affiche une forme en sapin en utilisant les boucles for et un parametre donne qui defini
        /// la longueur de la forme
        /// </summary>
        /// <param name="longueur">Defini la longueur de la forme</param>
        /// <returns>La chaine de caracteres qui va faire la forme</returns>
        public string Exercice26(int longueur)
        {
            for (int i = 1; i <= longueur; i++)
            {
                for (int j = 1; j <= longueur - i; j++)
                {
                    Console.Write(' ');
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(' ');
                    Console.Write('*');
                }
                Console.Write("\n");
            }

            string forme = " ";
            return forme;
        }
        /// <summary>
        /// Exercice 27: Methode qui prend un tableau en parametre et utlise les donnees de ce tableau pour faire la somme
        /// des nombres dans le tableau donne pour ensuite faire la moyenne.
        /// </summary>
        /// <param name="tableau">Un tableau de nombres</param>
        /// <returns>La moyenne du tableau donne en parametre</returns>
        public double Exercice27(int[] tableau)
        {
            double moyenne = 0;
            double somme = 0;
            for(int i = 0;i < tableau.Length; i++)
            {
                somme += i;
            }
            moyenne = somme / tableau.Length;
            return moyenne;
        }
        /// <summary>
        /// Exercice 28: methode qui prend un tableau en parametre, calcule la somme pour pouvoir faire la moyenne du tableau
        /// pour ensuite trouver l'ecart a la moyenne de chaque nombre du tableau et faire la moyenne de ces ecarts.
        /// </summary>
        /// <param name="tableau">un tableau de nombres</param>
        /// <returns>La moyenne des ecarts a la moyenne du tableau</returns>
        public double Exercice28(int[] tableau)
        {
            double moyenne = 0;
            double somme = 0;

            for (int i = 0; i < tableau.Length; i++)
            {
                somme += i;
            }
            moyenne = somme / tableau.Length;
            double[] ecart = new double[tableau.Length];
            double moyDiff = 0;

            for (int i = 0; i <= tableau.Length; i++)
            {
                ecart[i] = moyenne - tableau[i];
                if (ecart[i] < 0)
                {
                    ecart[i] = Math.Abs(ecart[i]);
                }
                moyDiff += ecart[i];
            }

            return moyDiff;
        }
        /// <summary>
        /// Exercice 29: Methode qui regarde dans un tableau et compare les nombres dans le tableau au index donnes en parametres pour
        /// retourner le nombre le plus grand.
        /// </summary>
        /// <param name="tableau">Tableau de nombres</param>
        /// <param name="index1">Nombre 1</param>
        /// <param name="index2">Nombre 2</param>
        /// <returns>Retourne le nombre le plus grand du tableau</returns>
        public int Exercice29(int[] tableau, int index1, int index2)
        {
            int plusGrand = 0;
            if (tableau[index1] > tableau[index2])
            {
                index1 = plusGrand;
            }
            else if (tableau[index2] > tableau[index1])
            {
                index2 = plusGrand;
            }

            return plusGrand;
        }
        /// <summary>
        /// Exercice 30: Methode qui prend en parametre 2 index qui va servire a echanger de place 2 nombres dans une tableau
        /// </summary>
        /// <param name="tableau">Tableau de nombres</param>
        /// <param name="index1">Index 1 utiliser pour l'echange</param>
        /// <param name="index2">Index 2 utiliser pour l'echange</param>
        public void Exercice30(int[] tableau, int index1, int index2)
        {
            int nombreDepartIndex = tableau[index1];
            tableau[index1] = tableau[index2];
            tableau[index2] = nombreDepartIndex;
        }
    }
}
