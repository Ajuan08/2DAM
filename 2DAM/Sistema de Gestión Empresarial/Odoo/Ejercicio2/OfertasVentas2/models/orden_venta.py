from odoo import models, fields, api

class OrdenVentapersonalizada(models.Model):
    
    _inherit = "sale.order"
    _description = "Orden de Venta Personalizada"

    cliente_id = fields.Many2one('model.cliente', string='Cliente')

    @api.onchange('cliente_id')
    def _onchange_cliente_id(self):
        if self.cliente_id:
           descuentos = self.cliente_id.descuentos_ids

           total_descuentos_porcentaje = sum(descuento.valor_descuento for descuento in descuentos if descuento.tipo_descuento == 'porcentaje')
           total_descuento_monto_fijo = sum(descuento.valor_descuento for descuento in descuentos if descuento.tipo_descuento == 'monto_fijo')

           descuento_porcentaje = (total_descuentos_porcentaje / 100) * self.amount_untaxed

           self.amount_total -= total_descuento_monto_fijo + descuento_porcentaje
