class Clientes{
    fs = require('fs');

    addCliente(id, name){
        const cliente = this.cargarClientes()
        const clienteDuplicado = cliente.find((cliente) => cliente.id === id)

        if (!clienteDuplicado) {
            cliente.push({
                id: id,
                name: name,
            })
            this.guardarClientes(cliente)
            console.log('Se ha añadido un nuevo cliente')
        }
    }

    borrarCliente = (idCliente) => {
        let clientes = this.cargarClientes();
    
        const clientesFiltrados = clientes.filter((cliente) => cliente.id !== idCliente);
    
        if (clientes.length > clientesFiltrados.length) {
            console.log('Cliente Borrado!');
            this.guardarClientes(clientesFiltrados);
        } else {
            console.log('El Cliente no se ha encontrado.');
        }
    }

    mostrarListaClientes = () => {
        const cliente = this.cargarClientes()
    
        console.log('Estos son tus Clientes')
    
        cliente.forEach((cliente) => {
            console.log("ID:"+cliente.id+"\nNombre: "+ cliente.name)
            console.log("------------------------------------------------");
        })
    }

    leerClientes = (id) => {
        const cliente = this.cargarClientes()
        const client = cliente.find((client) => client.id === id)
    
        if (client) {
            console.log("ID: " + client.id + "Nombre: " + client.name)
        }
    }

    guardarClientes = (cliente) => {
        const dataJSON = JSON.stringify(cliente)
        this.fs.writeFileSync('cliente.json', dataJSON)
    }

    cargarClientes = () => {
        try {
            const dataBuffer = this.fs.readFileSync('cliente.json')
            const dataJSON = dataBuffer.toString()
            return JSON.parse(dataJSON)
        } catch (e) {
            return []
        }
    }

}
module.exports = new Clientes();
