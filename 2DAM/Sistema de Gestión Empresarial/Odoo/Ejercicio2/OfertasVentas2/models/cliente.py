from odoo import models, fields, api

class Cliente(models.Model):
    _name = "model.cliente"
    _inherit = "res.partner"

    descuentos_ids = fields.Many2many('model.descuento', 'relacion_descuento_cliente', 'cliente_id','descuento_id', string='Clientes')
