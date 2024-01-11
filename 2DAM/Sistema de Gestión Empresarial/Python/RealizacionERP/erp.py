from almacen import Almacen

class ERP:
    def __init__(self):
        self.almacen = Almacen()
        self.ordenes_compra = []

    def agregar_producto_al_almacen(self, codigo, nombre, precio, stock):
        self.almacen.agregar_producto(codigo, nombre, precio, stock)

    def procesar_orden_compra(self, orden):
        costo_total = orden.calcular_costo_total(self.almacen)
        print(f"Costo total de la orden: {costo_total}")

        for codigo, cantidad in orden.productos.items():
            self.almacen.productos[codigo]["Stock"] -= cantidad