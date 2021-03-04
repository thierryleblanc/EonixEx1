using System;
using System.Collections.Generic;
using System.Text;

namespace Eonix_ex1
{
    /// <summary>
    /// classe TourMusical, représente un tour musical. il implémente l'interface ITour pour pouvoir décrire un tour (descriptionTour)
    /// </summary>
    public class TourMusical : ITour
    {
        private string descriptionTour;
        public TourMusical(string descriptionTour)
        {
            this.DescriptionTour = descriptionTour;
        }

        public string DescriptionTour {
            get { return this.descriptionTour; }
            set => this.descriptionTour = value; }
    }
}
