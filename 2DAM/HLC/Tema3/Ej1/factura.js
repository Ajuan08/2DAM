class Facturas{
    fs = require('fs');


    addFactura(id, idCliente, nombreCliente, total){
        const factura = this.cargarFactura()
        const facturaDuplicada = factura.find((factura) => factura.id === id)

        if (!facturaDuplicada) {
            factura.push({
                id: id,
                idCliente: idCliente,
                nombreCliente: nombreCliente,
                total: total
            })
            this.guardarFactura(factura)
            console.log('Se ha añadido una nueva factura')
        }
    }

    borrarFactura = (id) => {
        const factura = this.cargarFactura()
        const facturaToKeep = factura.filter((factura) => factura.id === id)
    
        if (factura.length > facturaToKeep.length) {
            console.log('Factura Borrada!')
            this.guardarFactura(facturaToKeep)
        } else {
            console.log('La factura no se ha encontrado!')
        }    
    }

    mostrarListaFacturas = () => {
        const factura = this.cargarFactura()
    
        console.log('Estos son tus Facturas')
    
        factura.forEach((factura) => {
            console.log("ID:"+factura.id+"\nID_Cliente: "+ factura.idCliente+ "\nNombreCliente:"+factura.nombreCliente)
            console.log("------------------------------------------------");
        })
    }

    leerFactura = (id) => {
        const factura = this.cargarFactura()
        const factu = factura.find((factu) => factu.id === id)
    
        if (factu) {
            console.log("ID: " + factu.id + "Nombre: " + factu.name)
        }
    }

    guardarFactura = (factura) => {
        const dataJSON = JSON.stringify(factura)
        this.fs.writeFileSync('factura.json', dataJSON)
    }

    cargarFactura = () => {
        try {
            const dataBuffer = this.fs.readFileSync('factura.json')
            const dataJSON = dataBuffer.toString()
            return JSON.parse(dataJSON)
        } catch (e) {
            return []
        }
    }

    listaFacturasCliente(id)
    {
        const factura = this.cargarFactura()
        const factu = factura.filter((factu) => factu.idCliente == id);
        factu.forEach((factu) =>{
            console.log(factu)})
    }

    
}
module.exports = new Facturas();
