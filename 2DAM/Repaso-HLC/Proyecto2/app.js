const yargs = require('yargs');
const Servicio = require("./servicio");

const servicio = new Servicio();

yargs.command({
    command: "mostrarClima",
    describe: "Muestra la latitud, longitud, localización, el clima y los grados centígrados",
    builder: {
        localizacion: {
            describe: "Localización de la que se desea conocer el clima",
            demandOption: true,
            type: "string"
        },
    },
    async handler(argv) {
        try {
            const response = await servicio.climaDatos(argv.localizacion);
            console.log('Latitud:', response.datosGeocode.latitud);
            console.log('Longitud:', response.datosGeocode.longitud);
            console.log('Localización:', response.datosGeocode.localizacion);
            console.log(`Temperatura actual en ${response.datosWeather.location.name}: ${response.datosWeather.current.temperature}℃ , Clima: ${response.datosWeather.current.weather_descriptions}`);
        } catch (error) {
            console.log("Error: " + error.message);
        }
    }
});

yargs.parse();