class Producto:
    def __init__(self, nombre, precio, stock):
        self.nombre = nombre
        self.precio = precio
        self.stock = stock

    def actualizar_stock(self, cantidad):
        self.stock += cantidad

    def mostrar_informacion(self):
        print(f"Nombre: {self.nombre}, Precio: {self.precio}, Stock: {self.stock}")

