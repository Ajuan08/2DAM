export class Curso {
    private nombre: string;
    private puntos: number;

    constructor(nombre: string, puntos: number) {
        this.nombre = nombre;
        this.puntos = puntos;
    }

    getNombre(): string {
        return this.nombre;
    }

    setNombre(nombre: string): void {
        this.nombre = nombre;
    }

    getPuntos(): number {
        return this.puntos;
    }

    setPuntos(puntos: number): void {
        this.puntos = puntos;
    }
}
