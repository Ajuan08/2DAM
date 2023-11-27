const GeocodeService = require('./GeocodeService.js');
const WeatherService = require('./WeatherService.js');

class Servicio {
    constructor() {
        this.geocodeService = new GeocodeService();
        this.weatherService = new WeatherService();
    }

    async getLocationData(location) {
        return await this.geocodeService.getLocationData(location);
    }

    async getWeatherData(location) {
        let locationData = await this.geocodeService.getLocationData(location);

        return await this.weatherService.getWeatherData(locationData.latitude, locationData.longitude);
    }
}

module.exports = Servicio;