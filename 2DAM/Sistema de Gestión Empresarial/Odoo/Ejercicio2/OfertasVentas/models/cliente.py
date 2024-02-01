from odoo import models, fields, api

class Cliente(models.Model):
    _inherit = "res.partner"


descuentos_ids = fields.Many2many('model.descuento', string='Descuentos Personalizados')