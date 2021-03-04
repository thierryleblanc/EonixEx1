using System;
using System.Collections.Generic;
using System.Text;

namespace Eonix_ex1
{
    public class ApplaudirEventArgs:EventArgs
    {

        public Singe UnSinge { get; set; }
        public ITour Tour { get; set; }
        public List<Spectateur> Spectateurs { get; set; }
        public ApplaudirEventArgs(ITour tour)
            {
            Tour = tour;
            }






        }
}
