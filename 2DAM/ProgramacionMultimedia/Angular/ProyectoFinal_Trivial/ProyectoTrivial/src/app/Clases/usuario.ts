export class Usuario {
    private _usuario: string;
    private _contrasena: string;

    constructor(usuario: string, contrasena: string) {
        this._usuario = usuario;
        this._contrasena = contrasena;
    }

    public get usuario(): string {
        return this._usuario;
    }
    public set usuario(value: string) {
        this._usuario = value;
    }

    public get contrasena(): string {
        return this._contrasena;
    }
    public set contrasena(value: string) {
        this._contrasena = value;
    }
}
