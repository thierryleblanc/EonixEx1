using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eonix_ex1
{
    /// <summary>
    /// Spectateur, classe qui va s'abonner aux évenement lancé par Singe. En fonction du type de tour du singe, soit applaudir, soit siffler.
    /// </summary>
    public class Spectateur
    {

        public string Nom { get; set; }


        public Spectateur(string nom) {
            this.Nom = nom;
        }


        /// <summary>
        /// Méthode éxécutée lorsque un singe lance u applaudissement. Le spectateur est abonné à cet evenement dans l'objet Singe.
        /// </summary>
        /// <param name="source">source est un objet de type singe</param>
        /// <param name="args">de type ApplaudirEventArgs, contient le tour exécuté par le singe</param>
        public void OnApplauseRequested(object source, ApplaudirEventArgs args) {

            string typeTourSinge = string.Empty;
            string typeActionSpectateur = string.Empty;

            if (args.Tour is TourAcrobatique) {
                typeTourSinge = "acrobatique";
                typeActionSpectateur = "applaudit";
            } else if (args.Tour is TourMusical) {
                typeTourSinge = "musical";
                typeActionSpectateur = "siffle";
            }


            Console.WriteLine(
            BuildText(typeTourSinge, typeActionSpectateur, (source as Singe).Nom, args.Tour.DescriptionTour)
                );

            Thread.Sleep(1000);
          
        }

        /// <summary>
        /// Construit un texte
        /// </summary>
        /// <param name="typeTourSinge">le type de tour exécuté par le singe (acrobatique, musical)</param>
        /// <param name="typeActionSpectateur">un spectateur applaudit ou siffle lorsque le singe exécute son tour</param>
        /// <param name="nomSinge">nom du singe</param>
        /// <param name="descriptionTour">description du tour</param>
        /// <returns></returns>
        string BuildText(string typeTourSinge, string typeActionSpectateur, string nomSinge, string descriptionTour) {
            StringBuilder txt = new StringBuilder();
            txt.Append("\t\tle spectateur ");
            txt.Append("(" + Nom + ")");
            txt.Append(typeActionSpectateur);
            txt.Append(" pendant le tour ");
            txt.Append(typeTourSinge);
            txt.Append(" '");
            txt.Append(descriptionTour);
            txt.Append("' ");
            txt.Append("du singe ");
            txt.Append("'");
            txt.Append(nomSinge);
            txt.Append("'");

            return txt.ToString();
        }
    }
}
