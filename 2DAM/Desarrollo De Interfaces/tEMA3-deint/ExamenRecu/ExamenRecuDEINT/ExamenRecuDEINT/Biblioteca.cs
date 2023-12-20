using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExamenRecuDEINT
{
    public class Biblioteca
    {
        public List<Libro> listaLibro = new List<Libro>();

        public void SerializarLibros()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Libro));
            using (FileStream stream = new FileStream("Libros.xml", FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }

        public Biblioteca DeserializarLibros()
        {
            XmlSerializer serializer = new XmlSerializer (typeof(Libro));
            Biblioteca biblioteca = new Biblioteca();
            using(FileStream stream = new FileStream("Libros.xml", FileMode.Open))
            {
                biblioteca = (Biblioteca)serializer.Deserialize(stream);
            }
            return biblioteca;
        }
    }
}
