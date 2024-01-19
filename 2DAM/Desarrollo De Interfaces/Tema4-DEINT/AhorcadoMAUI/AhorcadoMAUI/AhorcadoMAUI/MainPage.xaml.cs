using AhorcadoMAUI.Model;

namespace AhorcadoMAUI
{
    public partial class MainPage : ContentPage
    {
        private ItemModel _itemModel;
        private List<char> _letras = new() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private List<string> _palabras = new() { "LIBRO", "PEZ", "RATON", "JUGAR", "SOL"};
        private string _palabra;
        private List<char> _letrasAdivinadas = new();
        private int _numeroErrores;


        public MainPage()
        {
            InitializeComponent();

            _itemModel = new ItemModel();
            _itemModel.Letras = _letras;

            BindingContext = _itemModel;

            startGame();
        }

        private void startGame()
        {
            _itemModel.Imagen = "img0.jpg";
            _itemModel.Palabra = "";
            _itemModel.Mensaje = "";
            _itemModel.BotonesActivos = true;
            _itemModel.ContadorErrores = 0;
            _letrasAdivinadas.Clear();

            foreach (var a in flexLayout.Children)
            {
                if (a is Button boton)
                {
                    boton.IsEnabled = true;
                }
            }

            _palabra = _palabras[new Random().Next(0, _palabras.Count)];

            foreach (char letra in _palabra)
            {
                _itemModel.Palabra += "- ";
            }
        }

        private void botonLetraPresionado(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            char letraSeleccionada = Convert.ToChar(botonPresionado.Text);
            botonPresionado.IsEnabled = false;

            if (_palabra.Contains(letraSeleccionada))
            {
                _letrasAdivinadas.Add(letraSeleccionada);
                _itemModel.Palabra = "";

                foreach (char letra in _palabra)
                {
                    if (_letrasAdivinadas.Contains(letra))
                    {
                        _itemModel.Palabra += $"{letra} ";
                    }
                    else
                    {
                        _itemModel.Palabra += "- ";
                    }
                }

                if (!_itemModel.Palabra.Contains('-'))
                {
                    _itemModel.Mensaje = "¡Has ganado!";
                    disableButtons();
                }
            }
            else
            {
                _numeroErrores++;
                _itemModel.ContadorErrores = _numeroErrores; 

                _itemModel.Imagen = $"img{_numeroErrores}.jpg";

                if (_numeroErrores == 6)
                {
                    _itemModel.Mensaje = "¡Has perdido!";
                    disableButtons();
                }
            }
        }

        private void disableButtons()
        {
            foreach (var a in flexLayout.Children)
            {
                if (a is Button boton)
                {
                    boton.IsEnabled = false;
                }
            }
        }

        private void botonReset(object sender, EventArgs e)
        {
            startGame();
        }
    }

}
