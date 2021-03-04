using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eonix_ex1
{
    /// <summary>
    /// Singe, classe qui fait des tours musicales ou acrobatique. Emet un évenement. Abonne un spectateur pour réagir à l'évenement.
    /// </summary>
    public class Singe
    {
        List<ITour> Tours;
        List<Spectateur> spectateurs;
        public string Nom { get; set; }
        //delegué générique
        public event EventHandler<ApplaudirEventArgs> ApplauseRequested;

        /// <summary>
        /// constructeur de l'objet singe
        /// </summary>
        /// <param name="nom">nom du singe</param>
        public Singe(string nom)
        {
            this.Nom = nom;
        }

        /// <summary>
        /// permet d'abonner un(des) spectateur(s) au tour, et d'executer un tour
        /// </summary>
        internal void TourRequest()
        {
            foreach (Spectateur spectateur in spectateurs)
            {
                // le spectateur s'abonne à l'evenement Applaudir
                this.ApplauseRequested += spectateur.OnApplauseRequested;
            }


            if (Tours != null)
            {
                foreach (ITour tour in Tours)
                {
                    Console.WriteLine("\tLe singe '" + this.Nom + "' réalise le tour '" + tour.DescriptionTour +"'" );
                    Thread.Sleep(1000);


                    // lancer l'évenemment
                    OnApplauseRequested(tour);
                }

              
            }

        }

        /// <summary>
        /// évenement 
        /// </summary>
        /// <param name="tour">prévenir les spectateurs qu'un tour ient d'être exécuter. on passe le tour en argument d'évenement. Le spectateur réagira à cet évenement</param>
      protected virtual void OnApplauseRequested(ITour tour) {
            if (ApplauseRequested != null) {
                ApplauseRequested(this, new ApplaudirEventArgs(tour));
            }
        }

        public void AttachTours(List<ITour> tours)

        {
            this.Tours = tours;
        }

        public void AttachSpectateur(Spectateur spectateur)
        {
            if (spectateurs == null) { 
                spectateurs = new List<Spectateur>(); 
            }
            spectateurs.Add(spectateur);
        }
    }
}
