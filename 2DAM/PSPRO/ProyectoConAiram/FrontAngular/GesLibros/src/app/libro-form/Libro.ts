import { Autor } from "../autor-form/Autor";
import { Categoria } from "../categoria-form/Categoria";

export class Libro{
    id: number;
    titulo: string;
    autor: Autor;
    categorias: Categoria[] = [];

    constructor(id: number, titulo: string, autor: Autor, categorias: Categoria[]) {
        this.id = id;
        this.titulo = titulo;
        this.autor = autor;
        this.categorias = categorias;
    }
}