import { Libro } from "../libro/libro";

export class Servicio {

    private libros !: Libro[];

    constructor() {
        this.libros = [
            new Libro("Libro 1", "Autor 1", "Editorial 1", new Date(1998, 1, 1)),
            new Libro("Libro 2", "Autor 2", "Editorial 2", new Date(2004, 2, 2)),
            new Libro("Libro 3", "Autor 3", "Editorial 3", new Date(2008, 3, 3))
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




