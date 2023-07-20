using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    class Etudiant : Personne
    {

        string infoEtudes;
        public Personne profPrincipale { get; init; }

        public Etudiant(string nom, int age, string infoEtudes, Personne profPrincipale = null) : base(nom, age, "Etudiant")
        {
            this.infoEtudes = infoEtudes; 
            this.profPrincipale = profPrincipale;

        }

        public override void Afficher()
        {

            AfficherNomAge();


            Console.WriteLine("  Etudiant en: " + infoEtudes);
            if(profPrincipale != null)
            {
                Console.WriteLine("  Professeur principal: " );
                profPrincipale.Afficher();

            }

            Console.WriteLine();
        }

        
    }



    class Personne
    {
        static int nb_personne = 0;

        string nom;
        int age;
        string emploi;
        int num_personne;



        public Personne(string nom, int age, string emploi = null) 
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nb_personne++;
            this.num_personne = nb_personne;

        }

        protected void AfficherNomAge()
        {

            Console.WriteLine("Personne N°: " + num_personne);
            Console.WriteLine("  Nom: " + nom);
            Console.WriteLine("  Age: " + age);
        }
        

        public virtual void Afficher()
        {
            AfficherNomAge();

            if (emploi == null)
            {
                Console.WriteLine("  Emploi: " + ("(non spécifié)"));

            }
            else
            {
                Console.WriteLine("  Emploi: " + emploi);
            }
            
            Console.WriteLine();

        }
            
        public static void AfficherNbPersonne()
        {
            Console.WriteLine("Nombre de personne: " + Personne.nb_personne);
        }
    }


    

    internal class Program
    {

        static void Main(string[] args) {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*var noms = new List<string>() { "paul", "Jacques", "David" };
            var ages = new List<int>() { 30, 35, 20 };
            var emplois = new List<string>() { "Développeur", "Professeur", "Etudiant" };
            */

            var personne1 = new Etudiant("Jean", 23, "Informatique")
            {
              profPrincipale =  new Personne("Paul", 25, "Professeur")
            };
         
            personne1.Afficher();
        }
    }
}