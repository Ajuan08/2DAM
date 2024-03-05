export class Alumnos {
    public nombre: string;
    public curso: string;
    public nota1: number;
    public nota2: number;
    public nota3: number;
    public media: number;

    constructor(nombre: string, curso: string, nota1: number, nota2: number, nota3: number,media: number) {
        this.nombre = nombre;
        this.curso = curso;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
        this.media = media;
    }

    public getNombre(): string {
        return this.nombre;
    }

    public getCurso(): string {
        return this.curso;
    }

    public getMedia(): number {
        return this.media;
    }

    public setNombre(nombre: string): void {
        this.nombre = nombre;
    }

    public setCurso(curso: string): void {
        this.curso = curso;
    }

    public setMedia(media: number): void {
        this.media = media;
    }

    public getNota1(): number {
        return this.nota1;
    }

    public getNota2(): number {
        return this.nota2;
    }

    public getNota3(): number {
        return this.nota3;
    }

    public setNota1(nota1: number): void {
        this.nota1 = nota1;
    }

    public setNota2(nota2: number): void {
        this.nota2 = nota2;
    }

    public setNota3(nota3: number): void {
        this.nota3 = nota3;
    }
}
