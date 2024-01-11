class OrdenCompra:
    def __init__(self, fecha):
        self.fecha = fecha
        self.productos = {}

    def agregar_producto(self, codigo, cantidad):
        self.productos[codigo] = cantidad

    def calcular_costo_total(self, almacen):
        costo_total = 0
        for codigo, cantidad in self.productos.items():
            costo_total += almacen.productos[codigo]["Precio"] * cantidad
        return costo_total

