export class Usuario {
    private _username: string;
    private _password: string;

    constructor(usuario: string, contrasena: string) {
        this._username = usuario;
        this._password = contrasena;
    }

    public get usuario(): string {
        return this._username;
    }
    public set usuario(value: string) {
        this._username = value;
    }

    public get contrasena(): string {
        return this._password;
    }
    public set contrasena(value: string) {
        this._password = value;
    }
}
