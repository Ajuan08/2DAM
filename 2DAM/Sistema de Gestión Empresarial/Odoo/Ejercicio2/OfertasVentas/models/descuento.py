from odoo import models, fields, api

class Descuento(models.Model):
    _name = "model.descuento"
    _description = "Modulo de descuentos en Ventas"

    nombre = fields.Char('Nombre', required=True)
    tipo_descuento = fields.Selection(
        [('porcentaje', 'Porcentaje'), ('monto_fijo', 'Monto Fijo')], string='Tipo de descuento', required=True
    )
    valor = fields.Float('Valor del Descuento', required=True)

    @api.multi
    def aplicar_descuento_pedido(self,pedido):
        for linea in pedido.order_line:
            if self.tipo_descuento == 'porcentaje':
                linea.price_unit *= (1 - self.valor / 100)
            elif self.tipo_descuento == 'monto_fijo':
                linea.price_unit -= self.valor
                