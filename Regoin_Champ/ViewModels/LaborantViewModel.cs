using Regoin_Champ.db;
using Regoin_Champ.mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regoin_Champ.ViewModels
{
   public class LaborantViewModel : BaseViewModel
   {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Type { get; set; }
        public LaborantViewModel(Laborant laborant)
        {
            FirstName = laborant.FirstName;
            LastName = laborant.LastName;
            Type = laborant.Type;
        }
    }
}
