export class Libro {
    
    private id!: number;
    private titulo!: String;
    private autor!: String;
    private editorial!: String;
    private fechaPublicacion!: Date;
    private static sumaId = 1;

    constructor(titulo:String, autor: String, editorial: String, fechaPublicacion:Date){
        this.id = Libro.sumaId;
        this.titulo = titulo;
        this.autor = autor;
        this.editorial = editorial;
        this.fechaPublicacion = fechaPublicacion;
        Libro.sumaId++;
    }

    getId(){
        return this.id;
    }

    getTitulo(){
        return this.titulo;
    }

    getAutor(){
        return this.autor;
    }

    getEditorial(){
        return this.editorial;
    }

    getFechaPublicacion(){
        return this.fechaPublicacion;
    }

}
