using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conventions de disposition.

            var firstName = "Penti";
            var lastName = "Minax";

            if ((firstName != "test") && (lastName != "mdp"))
            {

            }

            #endregion

            #region Conventions de commentaires.

            // Ceci est un commentaire
            // sur deux lignes. 

            #endregion

            #region Directives du langage.

            #region Chaîne de caractères.
            Console.WriteLine("CHAINE DE CARACTERES");
            // Chaîne courte.

            string displayName1 = $"{firstName} {lastName}";
            string displayName2 = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(displayName1);
            Console.WriteLine(displayName2);

            // Chaînes dans des boucles.

            var phrase = "lala";
            var manyPhrases = new StringBuilder();

            for (var i = 0; i < 100; i++)
            {
                manyPhrases.Append(phrase);
            }

            Console.WriteLine("tra" + manyPhrases);

            #endregion

            #region Tableaux.

            string[] voyelles1 = { "a", "e", "i", "o", "u" };

            var voyelles2 = new string[] { "a", "e", "i", "o", "u" };

            var voyelles3 = new string[5];
            voyelles3[0] = "a";
            voyelles3[1] = "e";

            #endregion

            #region Délégués.

            Del exampleDel1 = new Del(DelMethod);

            // Préférer cette syntaxe.
            Del exampleDel2 = DelMethod;

            #endregion

            #region Instructions try-catch et using dans la gestion des exceptions.

            var index = 6;

            #region try-catch
            try
            {
                var voyelle = voyelles1[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index is out of range: {0}", index);
            }
            #endregion

            #region using
            FileStream fs1 = null;

            try
            {
                fs1 = new FileStream("fichier.txt", FileMode.Open);
            }
            finally
            {
                if (fs1 != null)
                {
                    fs1.Dispose();
                }
            }

            using (FileStream fs2 = new FileStream("fichier.txt", FileMode.Open))
            {

            }
            #endregion

            #endregion


            #endregion

            #region Opérateur New.

            // Préférer cette syntaxe.
            var example1 = new Example();

            Example example2 = new Example();

            // Préférer l'initialiseur d'objet.
            var example3 = new Example { FirstName = "Penti", LastName = "Minax", Old = 20};

            var example4 = new Example();
            example4.FirstName = "Penti";
            example4.LastName = "Minax";
            example4.Old = 20;
            #endregion

        }

        #region Délégués.
        public delegate void Del(string message);

        public static void DelMethod(string str)
        {
            Console.WriteLine("DelMethod argument: {0}", str);
        }
        #endregion
    }
}
