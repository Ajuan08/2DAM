export class Proyecto {
    nombre: string;
    descripcion: string;
    fechaCreacion: Date;

    constructor(nombre: string, descripcion: string, fechaCreacion: Date) {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.fechaCreacion = fechaCreacion;
    }

    getNombre() {
        return this.nombre;
    }

    getDescripcion() {
        return this.descripcion;
    }

    getFechaCreacion() {
        return this.fechaCreacion;
    }
}
