from odoo import models, fields, api

class Tarea(models.Model):
    _name = "tareas.tarea"
    _description = "Gestor de Tareas - Tareas"

    nombre = fields.Char('Nombre', required=True)
    descripcion = fields.Text('Descripcion')
    fecha_creacion = fields.Datetime('Fecha Creacion', default=lambda self: fields.Datetime.now())
    contador_personas_asignadas = fields.Integer(compute='_compute_total')
    personas_ids = fields.Many2many('tarea.persona')
    estado = fields.Selection([
        ('porHacer', 'Por Hacer'),
        ('enProgreso', 'En Progreso'),
        ('hecho', 'Hecho')],
        string='Estado', default='porHacer', required=True)

    @api.depends("personas_ids")
    def _compute_total(self):
        for record in self:
            record.contador_personas_asignadas = len(record.personas_ids) if record.personas_ids else 0
