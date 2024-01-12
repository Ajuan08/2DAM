using System.Collections;

namespace EjercicioAhorcado
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        ArrayList listaPalabrasAbecedario;
        public MainPage()
        {
            InitializeComponent();
            listaPalabrasAbecedario = new ArrayList()
            {
                "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
            };
        }



        
    }

}
