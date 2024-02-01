from odoo import models, fields, api

class Descuento(models.Model):
    _name = "model.descuento"
    _description = "Modulo de descuentos en Ventas"

    nombre = fields.Char('Nombre', required=True)
    tipo_descuento = fields.Selection(
        [('porcentaje', 'Porcentaje'), ('monto_fijo', 'Monto Fijo')], string='Tipo de descuento', required=True
    )
    valor = fields.Float('Valor del Descuento', required=True)

    producto_ids = fields.Many2many('product.product', string='Productos Aplicables')
    cliente_ids = fields.Many2many('res.partner', string='Clientes Aplicables')

    @api.multi
    def aplicar_descuento_cliente(self, cliente):
        if cliente in self.cliente_ids:
            cliente_sale_orders = self.env['sale.order'].search([('partner_id', '=', cliente.id), ('state', '=', 'sale')])
            for order in cliente_sale_orders:
                self.aplicar_descuento_pedido(order)

    @api.multi
    def aplicar_descuento_producto(self, producto):
        if producto in self.producto_ids:
            producto_sale_orders = self.env['sale.order.line'].search([('product_id', '=', producto.id), ('order_id.state', '=', 'sale')])
            for order_line in producto_sale_orders:
                order_line.order_id.recalculate_descuentos()

    @api.multi
    def aplicar_descuento_pedido(self, pedido):
        for linea in pedido.order_line:
            if self.tipo_descuento == 'porcentaje':
                linea.price_unit *= (1 - self.valor / 100)
            elif self.tipo_descuento == 'monto_fijo':
                linea.price_unit -= self.valor
                pedido.recalculate_descuentos()
