export class Usuario {
    nombre: string;
    apellido: string;
    usuario: string;
    contrasena: string;

    constructor(nombre: string, apellido: string, usuario: string, contrasena: string) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.usuario = usuario;
        this.contrasena = contrasena;
    }

    public getUsuario(): string {
        return this.usuario;
    }

    public setUsuario(usuario: string): void {
        this.usuario = usuario;
    }

    public getContrasena(): string {
        return this.contrasena;
    }

    public setContrasena(contrasena: string): void {
        this.contrasena = contrasena;
    }
}
