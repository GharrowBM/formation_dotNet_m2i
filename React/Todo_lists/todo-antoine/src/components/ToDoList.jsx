import { useEffect, useState } from "react"
import '../styles/ToDoList.css'
import {baseTasks} from '../datas/baseTasks'
import Task from './Task'
import { getAllTodos, postTodo, postTodoData } from "../services/data"

export default function ToDoList() {
    function addTask(taskName) {
        const formdata = new FormData()
        formdata.append('name', taskName)
        
        formdata.append('file', file)
        postTodoData(formdata).then(res => {
            setTasks([...tasks, res.data.todo])

        })
    }

    const [tasks, setTasks] = useState([])
    const [firstLoading, setFirstLoading] = useState(true);
    const [newTaskName, setNTN] = useState('')
    const [file, setFile] = useState(undefined)
    const onChangeFile = (e) => {
        console.log(e.target.files)
        setFile(e.target.files[0])
    }
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
                <input type="file" name="task-file" id="task-file"  onChange={onChangeFile}/>                
                <button onClick={() => {if (!(tasks.some(task => task.name === newTaskName))) addTask(newTaskName)}}>+</button>
            </div>
            <div className="todo-body">
                {tasks.map((task, index) => <Task key={index} id={index} tasks={tasks} setTasks={setTasks}/>
                )}
            </div>
        </div>
    </>)
}