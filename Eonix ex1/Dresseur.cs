using System;
using System.Collections.Generic;
using System.Text;

namespace Eonix_ex1
{
    /// <summary>
    /// Dresseur, dispose d'un singe. Le dresseur ordonne au singe d'exécuter des tours musicales ou acrobatiques. 
    /// </summary>
    public class Dresseur
    {

        private Singe singe;
        public string Nom { get; set; }
        
        
        
        public Dresseur(string nom)
        {
            Nom = nom;
        }

        public void AttachSinge(Singe singe)
        {
            this.singe = singe;
        }

        public void ExecuterTour()
        {
            singe.TourRequest();
        }
    }
}
