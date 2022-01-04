import { useEffect, useState } from "react"
import '../styles/ToDoList.css'
import {baseTasks} from '../datas/baseTasks'
import Task from './Task'
import { getAllTodos, postTodo } from "../services/data"

export default function ToDoList() {
    function addTask(taskName) {
        postTodo({
            name: taskName,
            isDone : false,
            isEdited : false
        }).then(res => {
            setTasks([...tasks, res.data.todo])

        })
    }

    const [tasks, setTasks] = useState([])
    const [firstLoading, setFirstLoading] = useState(true);
    const [newTaskName, setNTN] = useState('')
    useEffect(() => {
       getAllTodos().then(res => {
           setTasks([...res.data])
       }) 
    },[firstLoading])
    return (<>
        <div className="todo-list">
            <h1>ToDo List</h1>
            <div className="todo-head">
                <span id="task-number">{tasks.length}</span>
                <input type="text" name="new-task" id="new-task" placeholder="Nouvelle tâche..." value={newTaskName} onChange={(e) => setNTN(e.currentTarget.value)}/>
                <button onClick={() => {if (!(tasks.some(task => task.name === newTaskName))) addTask(newTaskName)}}>+</button>
            </div>
            <div className="todo-body">
                {tasks.map((task, index) => <Task key={index} id={index} tasks={tasks} setTasks={setTasks}/>
                )}
            </div>
        </div>
    </>)
}