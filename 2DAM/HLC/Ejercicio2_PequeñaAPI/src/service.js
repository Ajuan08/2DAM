const { MongoClient, ObjectId } = require('mongodb');

class Servicio {
    constructor() {
        this.connectionURL = 'mongodb://127.0.0.1:27017';
        this.databaseName = 'Contactos';
        this.conectar();
    }

    async conectar() {
        try {
            const client = await MongoClient.connect(this.connectionURL);
            this.db = client.db(this.databaseName);
            console.log('Conectado a la base de datos');
        } catch (error) {
            console.error('Error al conectar a la base de datos:', error);
        }
    }

    async crearContacto(datos) {
        try{
            if(!this.db){
                await this.conectar();
            }
            const result = await this.db.collection('contactos').insertOne(datos);
            return result;
        }catch(error){
            console.error('Error al conectar a la base de datos:', error);
        }
    }

    async buscarContacto(id) {
        try{
            if(!this.db){
                await this.conectar();
            }
            const result = await this.db.collection('contactos').findOne({ _id: new ObjectId(id) });
            return result;
        }catch(error){
            console.error('Error al conectar a la base de datos:', error);
        }
    }

    async actualizarContacto(id, datos) {
        try{
            if(!this.db){
                await this.conectar();
            }
            const result = await this.db.collection('contactos').updateOne({ _id: new ObjectId(id) }, { $set: datos });
            return result;
        }catch(error){
            console.error('Error al conectar a la base de datos:', error);
        }
    }

    async eliminarContacto(id) {
        try{
            if(!this.db){
                await this.conectar();
            }
            const result = await this.db.collection('contactos').deleteOne({ _id: new ObjectId(id) });
            return result;
        }catch(error){
            console.error('Error al conectar a la base de datos:', error);
        }
    }
}

module.exports = new Servicio();
