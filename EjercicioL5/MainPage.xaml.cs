using EjercicioL5_DAL;
using EjercicioL5_ENT;
using System.Collections.ObjectModel;

namespace EjercicioL5
{
    public partial class MainPage : ContentPage
    {

       

        ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona>(clsListadoPersonasDAL.GetListadoPersonas());
        
        public ObservableCollection<clsPersona> Personas { get { return personas; } }

        public MainPage()
        {
            InitializeComponent();
            
            PersonasListView.ItemsSource = personas;
        }

        
    }

}
