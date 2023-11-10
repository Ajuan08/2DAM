import { Libro } from "./libro";

export class Servicio {

    private libros !: Libro[];

    constructor() {
        this.libros = [
            new Libro("El Lazarillo de Thormes", "Anónimo", "Mateo Fernández", new Date(1554, 12, 2)),
            new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", "Juan de la Cuesta", new Date(1615, 8, 20)),
            new Libro("Geronimo Stilton", "Elissabetta Dami", "Reino Fantastico", new Date(2003, 6, 30))
        ];
    }

    getLibrosId(id: Number){
        let libro: any;
        for(let li of this.libros){
            if(li.getId() == id){
                libro = {titulo:li.getTitulo(), 
                autor:li.getAutor(), 
                editorial:li.getEditorial(), 
                fechaPublicacion: li.getFechaPublicacion()};
            }
          }
        return libro;
    }

    getLibros(){
        let libro = this.libros.map((libro: any) => ({
            id: libro.getId(),
            titulo: libro.getTitulo()
          }));
        return libro;
    }


}





