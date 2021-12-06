using Regoin_Champ.db;
using Regoin_Champ.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Regoin_Champ.Views
{
    /// <summary>
    /// Interaction logic for LaborantView.xaml
    /// </summary>
    public partial class LaborantView : Window
    {
        public LaborantView(Laborant laborant)
        {
            InitializeComponent();
            DataContext = new LaborantViewModel(laborant);
        }
    }
}
