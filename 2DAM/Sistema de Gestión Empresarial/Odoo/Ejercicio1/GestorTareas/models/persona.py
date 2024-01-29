from odoo import models, fields, api

class Persona(models.Model):
    _name = 'GestorTareas.persona'
    _description = 'GestorDeTareasPersonas'

    name = fields.Char(string="Nombre de la Persona", required=True)
    description = fields.Text(string="Descripción", required=True)

    tarea_ids = fields.Many2many('gestor_tareas.tarea.tarea', string="Tareas asignadas")

    total_tareas_asignadas = fields.Integer(string="Total de Tareas Asignadas", compute='_compute_total_tareas')

    @api.depends('tarea_ids')
    def _compute_total_tareas(self):
        for persona in self:
            persona.total_tareas_asignadas = len(persona.tarea_ids)
