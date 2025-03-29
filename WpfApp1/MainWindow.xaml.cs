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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<Profesor> profesors = new List<Profesor>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Profesor> profesors = new List<Profesor>();
            profesors.Add(new Profesor { Apellidos = "Gomez", Nombres ="Jaime"});
            profesors.Add(new Profesor { Apellidos = "Torrico", Nombres = "Hugo " });

            dgProfesores.ItemsSource = profesors;
            MessageBox.Show("Arriba la U");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)


        {
            List<Curso> cursos = new List<Curso>();
            cursos.Add(new Curso { Nombres = "React", Descripcion = "Curso de react" });
            cursos.Add(new Curso { Nombres = "Node", Descripcion = "Curso de Node" });

            dgCursos.ItemsSource = cursos;


              
            MessageBox.Show("Tricampeon");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        { 
            profesors.Add(new Profesor { Apellidos = name.Text, Nombres = lastname.Text });

            if (name.Text == "" || lastname.Text == "")
            {
                MessageBox.Show("Los campos estan vacios");
                return;
            }


            dgProfesores.ItemsSource = null;

            dgProfesores.ItemsSource = profesors;
           
        }
    }
}
