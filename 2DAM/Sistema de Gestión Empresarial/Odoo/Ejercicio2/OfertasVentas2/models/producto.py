from odoo import models, fields, api

class Producto(models.Model):
    _name = "model.producto"
    _inherit = "product.product"

    descuentos_ids = fields.Many2many('model.descuento', string='Descuentos Aplicables')
