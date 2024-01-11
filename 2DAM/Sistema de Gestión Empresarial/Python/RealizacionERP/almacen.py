class Almacen:
    def __init__(self):
        self.productos = {}

    def agregar_producto(self, codigo, nombre, precio, stock):
        self.productos[codigo] = {"Nombre": nombre, "Precio": precio, "Stock": stock}

    def mostrar_inventario(self):
        for codigo, producto_info in self.productos.items():
            print(f"Código: {codigo}, {producto_info['Nombre']}, Precio: {producto_info['Precio']}, Stock: {producto_info['Stock']}")
