export class Curso {

    private id: number;
    private nombre: string;
    private puntos: number;
    private static sumaId: number = 0

    constructor(nombre:string, puntos: number){
        Curso.sumaId++;
        this.id = Curso.sumaId;
        this.nombre= nombre;
        this.puntos = puntos;
    }

    public getId(){
        return this.id;
    }
    
    public getNombreCurso(){
        return this.nombre;
    }

    public setNombreCurso(nombre: string){
        this.nombre = nombre;
    }

    public getPuntos(){
        return this.puntos;
    }

    public setPuntos(puntos: number){
        this.puntos = puntos;
    }

}
