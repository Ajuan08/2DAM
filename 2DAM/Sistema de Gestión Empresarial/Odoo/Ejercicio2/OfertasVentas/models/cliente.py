from odoo import models, fields, api

class Cliente(models.Model):
    _inherit = "res.partner"

    descuentos_ids = fields.Many2many('model.descuento', string='Descuentos Personalizados')

    @api.multi
    def aplicar_descuentos_cliente(self):
        for descuento in self.descuentos_ids:
            descuento.aplicar_descuento_cliente(self)
