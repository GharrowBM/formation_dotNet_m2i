import Banner from './components/Banner';
import './App.css';
import TaskList from './components/TaskList';
import 'bootstrap/dist/css/bootstrap.min.css';
import { useState } from 'react'
import Input from './components/Input'

function App() {
    const [taskList, setTaskListValue] = useState([])
    return (
        <div className="App">
            <Banner 
                msg="React ToDo List"
            />
            <Input
                taskList={taskList}
                setTaskListValue={setTaskListValue}
            />
            <TaskList
                taskList={taskList}
                setTaskListValue={setTaskListValue}
            />
        </div>
    )
}

export default App;
