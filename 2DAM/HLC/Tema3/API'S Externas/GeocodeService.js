const axios = require('axios');

class GeocodeService {
    async getLocationData(location) {
        const apiKey = 'pk.eyJ1IjoiYWp1YW4yNCIsImEiOiJjbHA4ZG95MjQyaGJnMmlzNnZocXBkaWNmIn0.rodqKL5KSAuazeViFduVsA';
        const url = `http://api.mapbox.com/geocoding/v5/mapbox.places/${encodeURIComponent(location)}.json?access_token=${apiKey}`;

        try {
            const response = await axios.get(url);
            const data = response.data;
        
            if (data.features.length === 0) {
              throw new Error('Localización no encontrada');
            }
        
            const [longitude, latitude] = data.features[0].center;
            const altitude = 0;
        
            return { latitude, longitude, altitude };
        } catch (error) {
            throw new Error('Error, no se encontraron datos');
        }
    }
}

module.exports = GeocodeService;