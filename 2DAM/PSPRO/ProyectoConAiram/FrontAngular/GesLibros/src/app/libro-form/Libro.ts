import { Autor } from "../autor-form/Autor";
import { Categoria } from "../categoria-form/Categoria";

export class Libro{
    id!: number;
    titulo: string;
    autor: Autor;
    categorias: Categoria[] = [];

    constructor(titulo: string, autor: Autor, categorias: Categoria[]) {
        this.titulo = titulo;
        this.autor = autor;
        this.categorias = categorias;
    }
}