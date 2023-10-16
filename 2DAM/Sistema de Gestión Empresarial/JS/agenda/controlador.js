//Variable y Array
let arrayContactos = [new Contacto('Pepe'),new Contacto('Manolo'),new Contacto('Alvarito')]
let listaContacto //<ul>

function main(){
    //SELECCIONO ELEMENTOS DEL DOM
    //EL BOTON AÑADIR CONTACTO PARA PONERLE UN MANEJADOR DE EVENTOS
    let botonFormulario = document.querySelector('#botonFormulario');
    //EL <UL> PARA LUEGO AÑADIRLE UN <LI> PARA CADA CNTACTO
    listaContacto = document.getElementById('listado');
    //2.- AddEventListener
    botonFormulario.addEventListener('click',addContacto);
}

function addContacto(){
    //RECOGER LOS VALORES QUE EL USUARIO INTRODUZCA
    let nombre = document.querySelector('#nombre').value;

    //Voy a añadir un nuevo objeto contacto al array
    arrayContactos.push(new Contacto(nombre));
}

window.addEventListener('load', main);