from odoo import http
from odoo.http import request
import json

class VentasController(http.Controller):

    @http.route('/ventas_controller_endpoint', type='http', auth='public', methods=['GET'], website=True)
    def obtener_ordenes_ventas(self, **kw):
        sale_orders = request.env['sale.order'].search([('amount_total', '>', 1000)])
        orders_data = [{'name': order.name} for order in sale_orders]
        return json.dumps(orders_data)
