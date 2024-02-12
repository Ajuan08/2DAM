{
    'name': "apiOdoo",
    'summary': "Creacion de una API RestFul con Odoo",
    'description': "Este ejercicio consiste en la creacion de una API RestFul con Odoo",
    'author': "Antonio Juan Rios Fernandez",
    'version': '1.0',
    'depends': ['sale'],
    'data': [],
    'controllers': [
        'controllers/sales_controller.py',
    ],
    'installable' : True,
    'application': True
}