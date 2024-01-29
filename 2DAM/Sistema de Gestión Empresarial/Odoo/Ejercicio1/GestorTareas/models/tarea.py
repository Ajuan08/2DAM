from odoo import models, fields, api

class Tarea(models.Model):
    _name = 'gestor_tareas.tarea'
    _description = 'Descripcion de la Tarea'

    name = fields.Char(string="Nombre de la Tarea", required=True)
    description = fields.Text(string="Descripción", required=True)
    fecha_creacion = fields.Datetime(string='Fecha de Creación', default=fields.Datetime.now)
    assigned_to = fields.Many2many('GestorTareas.persona', string="Asignado a")

    total_personas_asignadas = fields.Integer(string="Total de Personas Asignadas", compute='_compute_total_personas')

    @api.depends('assigned_to')
    def _compute_total_personas(self):
        for tarea in self:
            tarea.total_personas_asignadas = len(tarea.assigned_to)
