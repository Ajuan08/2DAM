const yargs = require('yargs');
const Servicio = require('./Servicio.js');


const service = new Servicio();

yargs.command({
    command: 'ObtenerPosicion',
    describe: 'Obtiene la latitud, longitud y altitud de un sitio',
    builder: {
        location: {
            describe: 'Lo que desees',
            demandOption: true,
            type: 'string'
        }
    },
    async handler(argv) {
        const response = await service.getLocationData(argv.location);

        if (response != null) {
            console.log('Latitud: ' + response.latitude + '\nLongitud: ' + response.longitude + '\nAltitud: ' + response.altitude);
        } else {
            console.log('Error al obtener los datos');
        }
    }
}),
yargs.command({
    command: 'ObtenerTiempo',
    describe: 'Obtiene el tiempo de una localización',
    builder: {
        location: {
            describe: 'Lo que desees',
            demandOption: true,
            type: 'string'
        }
    },
    async handler(argv) {
        const response = await service.getWeatherData(argv.location);

        if (response != null) {
            console.log('Temperatura: ' + response.temperature + 'ºC\nDescripción del tiempo: ' + response.description);
        } else {
            console.log('Error en la obtención de datos');
        }
    }
})

yargs.parse();