import '../styles/Task.css'

export default function Task({id, tasks, setTasks}) {
    function deleteTask(id) {
        let tmpArray = [...tasks]
        tmpArray.splice(id, 1)
        setTasks(tmpArray)
    }

    function switchCompletion(id) {
        let tmpArray = [...tasks]
        tmpArray[id].isDone = !tmpArray[id].isDone
        setTasks(tmpArray)
    }

    function switchEdition(id) {
        let tmpArray = [...tasks]        
        tmpArray[id].isEdited = !tmpArray[id].isEdited
        setTasks(tmpArray)
    }

    function changeTaskName(id, newName) {
        let tmpArray = [...tasks]
        tmpArray[id].name = newName
        setTasks(tmpArray)
    }

    return(
        <div className="todo-task">
            <div className="task-actions">
            <button className={tasks[id].isDone ? "btn-task-checked" : "btn-task-unchecked"} onClick={() => switchCompletion(id)}>
                {tasks[id].isDone? "Done" : "To Do"}
            </button>            
            <button className="btn-task-edit" onClick={() => switchEdition(id)}>
                {tasks[id].isEdited? "Confirm" : "Edit"}
            </button>
            <button className="btn-task-delete" onClick={() => deleteTask(id)}>
                Delete
            </button>
            </div>
            <div className="task-content">
                {tasks[id].isEdited? <textarea rows="3" value={tasks[id].name} onChange={(e) => changeTaskName(id, e.currentTarget.value)}/> : tasks[id].name}
            </div>
                     
        </div>
    )
}