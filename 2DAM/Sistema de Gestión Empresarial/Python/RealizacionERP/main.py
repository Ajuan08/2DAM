from producto import Producto
from almacen import Almacen
from orden_compra import OrdenCompra
from erp import ERP

erp = ERP()

producto1 = Producto("P1", "Producto 1", 10.0, 100)
producto2 = Producto("P2", "Producto 2", 15.0, 50)
producto3 = Producto("P3", "Producto 3", 5.0, 200)
producto4 = Producto("P4", "Producto 4", 8.0, 75)

almacen = Almacen()
almacen.agregar_producto(producto1)
almacen.agregar_producto(producto2)
almacen.agregar_producto(producto3)
almacen.agregar_producto(producto4)

while True:
    print("\n--- Menú ---")
    print("1. Agregar Producto al Inventario")
    print("2. Realizar Orden de Compra")
    print("3. Mostrar Inventario")
    print("4. Salir")

    opcion = input("Seleccione una opción: ")

    if opcion == "1":
        codigo = input("Ingrese el código del producto: ")
        nombre = input("Ingrese el nombre del producto: ")
        precio = float(input("Ingrese el precio del producto: "))
        stock = int(input("Ingrese la cantidad en stock del producto: "))

        producto = Producto(codigo, nombre, precio, stock)
        almacen.agregar_producto(producto)

    elif opcion == "2":
        fecha = input("Ingrese la fecha de la orden de compra: ")
        orden = OrdenCompra(fecha)

        while True:
            codigo = input("Ingrese el código del producto (0 para finalizar): ")
            if codigo == "0":
                break
            cantidad = int(input("Ingrese la cantidad: "))
            orden.agregar_producto(almacen.productos[codigo], cantidad)

        erp.procesar_orden_compra(orden)

    elif opcion == "3":
        almacen.mostrar_inventario()

    elif opcion == "4":
        print("Saliendo")
        break

    else:
        print("Opción no válida. Inténtelo de nuevo.")
