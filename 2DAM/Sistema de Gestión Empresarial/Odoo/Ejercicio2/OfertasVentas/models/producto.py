from odoo import models, fields, api

class Producto(models.Model):
    _inherit = "product.product"

    descuentos_ids = fields.Many2many('model.descuento', string='Descuentos Aplicables')

    @api.multi
    def aplicar_descuentos_producto(self):
        for descuento in self.descuentos_ids:
            descuento.aplicar_descuento_producto(self)
