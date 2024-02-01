from odoo import models, fields, api

class SaleOrder(models.Model):
    _inherit = "sale.order"

    @api.multi
    def recalculate_descuentos(self):
        for line in self.order_line:
            line.product_id.aplicar_descuentos_producto()
        for cliente in self.partner_id:
            cliente.aplicar_descuentos_cliente()
