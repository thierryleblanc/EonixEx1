using System;
using System.Collections.Generic;
using System.Text;

namespace Eonix_ex1
{

    /// <summary>
    /// Interface ITour, permet d'écrire un contrat pour les classes TourMusical et TourAcrobatique
    /// les classes TourMusical et TourAcrobatique doivent implémenter l'interface ITour
    /// </summary>
    public interface ITour
    {
        public string DescriptionTour { get; set; }
    }
}
