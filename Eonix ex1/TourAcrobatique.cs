using System;
using System.Collections.Generic;
using System.Text;

namespace Eonix_ex1
{

    /// <summary>
    /// classe TourAcrobatique, représente un tour acrobatique. il implémente l'interface ITour pour pouvoir décrire un tour (descriptionTour)
    /// </summary>
    public class TourAcrobatique:ITour
    {
        private string descriptionTour;
        public TourAcrobatique(string descriptionTour) {
            this.DescriptionTour = descriptionTour;
        }

        public string DescriptionTour {
            get { return this.descriptionTour; }
            set => this.descriptionTour = value; }
    }
}
