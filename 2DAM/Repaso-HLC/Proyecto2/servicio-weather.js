const axios = require('axios');

class ServicioWeather {
  getWeather(latitud, longitud) {
      return new Promise((resolve, reject) => {
          const params = {
              access_key: 'c1502982da265b631be416b5ea333af1',
              query: `${latitud}, ${longitud}`
          };

          axios.get('http://api.weatherstack.com/current', { params })
              .then(response => {
                  const datos = response.data;
                  resolve(datos);
              })
              .catch(error => {
                  reject(error.message);
              });
      });
  }
}


module.exports = ServicioWeather
