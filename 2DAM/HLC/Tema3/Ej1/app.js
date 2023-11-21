const yargs = require('yargs')
const facturas = require('./factura.js')
const clientes = require('./clientes.js')

yargs.command({
    command: 'addCliente',
    describe: 'Añade un nuevo Cliente',
    builder: {
        id: {
            describe: 'ID Cliente',
            demandOption: true,
            type: 'string'
        },
        name: {
            describe: 'Nombre Cliente',
            demandOption: true,
            type: 'string'
        }
    },
    handler(argv) {
        clientes.addCliente(argv.id, argv.name);
    }
})

yargs.command({
    command: 'addFactura',
    describe: 'Añade una nueva Factura',
    builder: {
        idCliente: {
            describe: 'ID Cliente',
            demandOption: true,
            type: 'string'
        },
        idFactura: {
            describe: 'ID Factura',
            demandOption: true,
            type: 'string'
        },
        Total: {
            describe: 'Total',
            demandOption: true,
            type: 'string'
        },
        nombreCliente: {
            describe: 'Nombre del Cliente',
            demandOption: true,
            type: 'string'
        }
    },
    handler(argv) {
        facturas.addFactura(argv.idCliente, argv.idFactura, argv.Total, argv.nombreCliente);
    }
})

yargs.command({
    command: 'listaClientes',
    describe: 'Muestra la lista de los Clientes',
    handler() {
        clientes.mostrarListaClientes();
    }
})

yargs.command({
    command: 'listaFacturas',
    describe: 'Muestra la lista de las Facturas',
    handler() {
        facturas.mostrarListaFacturas();
    }
})

yargs.command({
    command: 'borrarCliente',
    describe: 'Elimina un cliente',
    builder: {
        idCliente: {
            describe: 'ID Cliente a eliminar',
            demandOption: true,
            type: 'string'
        }
    },
    handler(argv) {
        clientes.borrarCliente(argv.idCliente);
    }
})

yargs.command({
    command: 'borrarFactura',
    describe: 'Elimina una factura',
    builder: {
      idFactura: {
        describe: 'ID de la factura a borrar',
        demandOption: true,
        type: 'number'
      }
    },
    handler(argv) {
        facturas.borrarFactura(argv.idFactura);
    }
  })
  

  yargs.command({
    command: 'listaFacturasCliente',
    describe: 'Lista las facturas de un cliente determinado',
    builder: {
        idCliente: {
            describe: 'ID del cliente',
            demandOption: true,
            type: 'number'
        },
    },
    handler(argv) {
        facturas.listaFacturasCliente(argv.idCliente);
    }
});

  
  yargs.parse();