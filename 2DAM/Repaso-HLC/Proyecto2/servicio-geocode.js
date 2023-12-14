const https = require('https');

const TOKEN = 'pk.eyJ1IjoibW9ucm91eDk5IiwiYSI6ImNscDhxZjRtbTA0YmcyaW9meGxjNjdtaDUifQ.pXp-DFvG8KIY7C0Ae-CXrA';

class ServicioGeocode {
    getForwardGeocoding(localizacion) {
        return new Promise((resolve, reject) => {
            const encodedAddress = encodeURIComponent(localizacion);
            const url = `https://api.mapbox.com/geocoding/v5/mapbox.places/${encodedAddress}.json?access_token=${TOKEN}&limit=1`;

            const req = https.get(url, (res) => {
                let data = '';

                res.on('data', (datos) => {
                    data += datos;
                });

                res.on('end', () => {
                    try {
                        const response = JSON.parse(data);

                        if (response.features.length === 0) {
                            reject('No encuentra la localizacion');
                        } else {
                            const longitud = response.features[0].center[0];
                            const latitud = response.features[0].center[1];
                            const localizacion = response.features[0].place_name;
                            
                            const result = {
                                latitud: latitud,
                                longitud: longitud,
                                localizacion: localizacion
                            };

                            resolve(result);
                        }
                    } catch (error) {
                        reject(`Error: ${error.message}`);
                    }
                });
            });

            req.on('error', (error) => {
                reject(`Error: ${error.message}`);
            });

            req.end();
        });
    }
}


module.exports = ServicioGeocode