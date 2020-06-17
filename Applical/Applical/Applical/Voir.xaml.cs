using Applical.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Applical
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Voir : ContentPage
    {
        public Voir()
        {
            InitializeComponent();

            Notes MesNotes = new Notes() { };
            
        }
    }
}