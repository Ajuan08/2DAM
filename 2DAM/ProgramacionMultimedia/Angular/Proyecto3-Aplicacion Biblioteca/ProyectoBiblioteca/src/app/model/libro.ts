export class Libro {
    private _titulo: string;
    private _autor: string;
    private _ISBN: string;
    private _fecha_prestamo: Date;

    constructor(titulo: string, autor: string, ISBN: string, fecha_prestamo: Date) {
        this._titulo = titulo;
        this._autor = autor;
        this. _ISBN = ISBN;
        this._fecha_prestamo = fecha_prestamo;
    }

    get titulo(): string{
        return this._titulo;
    }

    get autor(): string{
        return this._autor;
    }

    get ISBN(): string{
        return this._ISBN;
    }

    get fecha_prestamo(): Date{
        return this._fecha_prestamo;
    }



}
