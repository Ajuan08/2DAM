const request = require('request');

const url = 'https://api.mapbox.com/geocoding/v5/mapbox.places/Jerez%20de%20la%20Frontera.json?proximity=-6.132352327047869%2C36.689332215681944&access_token=pk.eyJ1IjoiYWp1YW4yNCIsImEiOiJjbHA4ZG95MjQyaGJnMmlzNnZocXBkaWNmIn0.rodqKL5KSAuazeViFduVsA';

request({ url: url }, (error, response) => {
    const data = JSON.parse(response.body)
    console.log(data.current)
})