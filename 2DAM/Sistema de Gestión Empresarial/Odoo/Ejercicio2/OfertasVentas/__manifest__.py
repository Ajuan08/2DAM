{
    'name': "OfertasVentas",
    'summary': "Integración de un Módulo Propio Ofertas Con el módulo Ventas(Sales) ",
    'description': "Este modulo consiste en la gestion y creacion de un modulo propio de ofertas con el modulo existente de ventas",
    'author': "Antonio Juan Rios Fernandez",
    'version': '1.0',
    'depends': ['base', 'product', 'sale'],
    'data': [
        'views/descuento_views.xml',
        'views/producto_views.xml',
        'views/cliente_views.xml',
    ],
    'installable' : True,
    'application': True
}