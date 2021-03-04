using System;
using System.Collections.Generic;
using System.Threading;

namespace Eonix_ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            //toursSinge1: contient une liste de tours acrobatiques ou musicales
            List<ITour> toursSinge1 = new List<ITour> {
                new TourAcrobatique("marcher sur les mains"),
                new TourMusical("tenir une flute avec les pieds")
             };

            //tourSinge2: contient une liste de tours acrobatiques ou musicales
            List<ITour> toursSinge2 = new List<ITour> {
                new TourAcrobatique("se rouler en boule"),
                new TourMusical("tapoter sur un piano")
             };

            //spectateur1 
            Spectateur spectateur1 = new Spectateur("spectateur n° 1");
            
            //singe1 et singe2
            Singe Singe1 = new Singe("singe n° 1");
            Singe Singe2 = new Singe("singe n° 2");
            
            // dresseur1 et dresseur2
            Dresseur Dresseur1 = new Dresseur("Dresseur n° 1");
            Dresseur Dresseur2 = new Dresseur("Dresseur n° 2");

            // on attache les tours du singe1 et du singe2
            Singe1.AttachTours(toursSinge1);
            Singe2.AttachTours(toursSinge2);

            // on attache les spectateurs en vue de pouvoir les abonnés aux tours
            // et ainsi les spectateurs pouront réagir aux tours (siffler ou applaudir)
            Singe1.AttachSpectateur(spectateur1);
            Singe2.AttachSpectateur(spectateur1);
            

            // on attache les singes aux dresseurs respectifs
            Dresseur1.AttachSinge(Singe1);
            Dresseur2.AttachSinge(Singe2);


            // on demande au dresseur de faire faire executer les tours aux singes
            Console.WriteLine(Dresseur1.Nom + " va ordonner à son Singe d'executer des tours...");
            Thread.Sleep(2000);
            Dresseur1.ExecuterTour();
            
            Console.WriteLine();Thread.Sleep(2000);
            Console.WriteLine(Dresseur2.Nom + " va ordonner à son Singe d'executer des tours...");
            Thread.Sleep(2000);
            Dresseur2.ExecuterTour();
        }
    }
}
