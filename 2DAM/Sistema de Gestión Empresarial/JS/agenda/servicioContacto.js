//LA INSTANCIAREMOS SOLO 1 VEZ (SINGLETON)

class servicioContacto{

    //Propedades. Encapsulo el array para protegerlo del controlador.
    arrayContactos = [new Contacto('Pepe'),new Contacto('Manolo'),new Contacto('Alvarito')]

    //Establezco una API pública para que el controlador manipule los datos indirectamente
    //El controlador no tiene que saber que se ha hecho dentro  esta clase será reciclable
    //Si se modifica el funcionamiento no afectará.

    addContacto(nombre){
        arrayContactos.push(new Contacto(nombre));
    }
}