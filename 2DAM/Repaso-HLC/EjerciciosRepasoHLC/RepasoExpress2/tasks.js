class Tasks {
    tasks = [
        {titulo: "Tarea 1", descripcion: "Descripción de la tarea 1"},
        {titulo: "Tarea 2", descripcion: "Descripción de la tarea 2"},
        {titulo: "Tarea 3", descripcion: "Descripción de la tarea 3"},
        {titulo: "Tarea 4", descripcion: "Descripción de la tarea 4"}
    ];

    getTasks() {
        return this.tasks.slice();
    }

    getTasksN(nTask) {
        var sendTasks = [];
        for (let i = 0; i < nTask; i++) {
            sendTasks.push(this.tasks[i]);
        }
        return sendTasks.slice();
    }

    removeTasks(nTask) {
        this.tasks.splice(nTask, 1);
        return "Tarea eliminada";
    }
}

module.exports = new Tasks();
