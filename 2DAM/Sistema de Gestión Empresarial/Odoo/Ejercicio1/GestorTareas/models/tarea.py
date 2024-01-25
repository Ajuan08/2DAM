from odoo import models, fields, api

class Tarea(models.Model):
    _name = 'GestorTareas.tarea'
    _description = 'GestorDeTareas'

    name = fields.Char(string="Nombre de la Tarea", required=True)
    description = fields.Text(string="Description", required=True)