using System.Windows.Forms;

namespace ExamenRecuDEINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCRUDLibros_Click(object sender, EventArgs e)
        {
            CRUDLibrosForm crud = new CRUDLibrosForm();
            crud.ShowDialog();
        }

        private void buttonCRUDEditorial_Click(object sender, EventArgs e)
        {
            CRUDEditorialForm crud2 = new CRUDEditorialForm();
            crud2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            List<Libro> libros = new List<Libro>();
            libros.Add(new Libro(1234567890,"Titulo1","Autor1",DateTime.Now,21,TipoGenero.LITERARURA));
            libros.Add(new Libro(0987654321, "Titulo2", "Autor2", DateTime.Now, 22, TipoGenero.CLASICA));
            libros.Add(new Libro(1234567899, "Titulo3", "Autor3", DateTime.Now, 24, TipoGenero.OBRA_MAESTRA));

            Biblioteca bibl = new Biblioteca();

            bibl.SerializarLibros();
            */
        }
    }
}
