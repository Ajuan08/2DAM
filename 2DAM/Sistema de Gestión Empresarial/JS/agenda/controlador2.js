//Version buena

//INSTANCIO EL SERVICIO
let servicio = new servicioContacto();
//Variable
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

    //LLamo al metodo correspondiente de la APi del servicio
    servicio.addContacto(nombre);
}

window.addEventListener('load', main);