const axios = require('axios');

class WeatherService {
    async getWeatherData(latitude, longitude) {
        const apiKey = 'd47ce2181766d353b29227ade05f9d6a';
        const url = `http://api.weatherstack.com/current?access_key=${apiKey}&query=${latitude},${longitude}`;
      
        try {
          const response = await axios.get(url);
          const data = response.data;
      
          if (data.error) {
            throw new Error(`Error: ${data.error.info}`);
          }
      
          return {
            temperature: data.current.temperature,
            description: data.current.weather_descriptions[0],
          };
        } catch (error) {
          throw error;
        }
      }
}

module.exports = WeatherService;