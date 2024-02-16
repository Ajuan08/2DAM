from odoo import models, fields, api

class Persona(models.Model):
    _name = "tarea.persona"
    _description = "Gestor de Tareas - Personas"

    nombre = fields.Char('Nombre', required=True)
    edad = fields.Integer('Edad')
    contador_Tareas_Asignadas = fields.Integer(compute='_compute_total')
    tareas_ids = fields.Many2many('tareas.tarea')

    @api.depends("tareas_ids")
    def _compute_total(self):
        for record in self:
            record.contador_Tareas_Asignadas = len(record.tareas_ids) if record.tareas_ids else 0
