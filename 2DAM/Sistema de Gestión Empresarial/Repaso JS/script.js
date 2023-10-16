//Seleccionamos todas las celdas de la tabla
let celdas = document.querySelectorAll("td");


let miBoton = document.getElementById("miBoton");
//let miBoton = document.querySelector("#miBoton");
let miTabla = document.querySelector("table");

//Hago un bucle para recorrer los objetos del array (celdas)

for (let i = 0; i < celdas.length; i++) 
{
    celdas[i].addEventListener("click", (e) => (e.target.classList.add("botonPulsado")));
}