
const ServicioGeocode = require("./servicio-geocode")
const ServicioWeather = require("./servicio-weather")

const servicioGeocode = new ServicioGeocode()
const servicioWeather = new ServicioWeather()

class Servicio{

    climaDatos(localizacion){
        return new Promise((resolve, reject) => {
        
            servicioGeocode.getForwardGeocoding(localizacion)
            .then(result => {

                servicioWeather.getWeather(result.latitud, result.longitud)
                .then(res =>{
                    const datos = {
                        datosGeocode: result,
                        datosWeather: res
                    }
                    
                    resolve(datos)
                }) 
                .catch(error => {
                    console.error('Error:', error.message);
                    reject(error);
                });

            })
            .catch(error => {
                console.error('Error:', error.message);
                reject(error);
            });
        })
    }
    
}


module.exports = Servicio
