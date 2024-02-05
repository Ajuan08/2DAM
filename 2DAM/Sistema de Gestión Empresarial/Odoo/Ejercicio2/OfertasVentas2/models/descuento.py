from odoo import models, fields, api

class Descuento(models.Model):
    _name = "model.descuento"
    _description = "Modulo de descuentos en Ventas"

    name = fields.Char('Nombre', required=True)
    tipo_descuento = fields.Selection([('porcentaje', 'Porcentaje'), ('monto_fijo', 'Monto Fijo')], string='Tipo de descuento', required=True)
    valor_descuento = fields.Float('Valor del Descuento', required=True)

    clientes_ids = fields.Many2many('model.cliente', string='Clientes')