import './App.css';
import Banner from './components/Banner';
import AddTask from './components/AddTask';
import TasksList from './components/TasksList';
import { useState } from 'react';
function App() {

  const [Tasks,setTasks] = useState([])

  return (
    <div className="App">
      <Banner/>
      <AddTask Tasks={Tasks} setTasks={setTasks}/>
      <TasksList Tasks={Tasks} setTasks={setTasks}/>
    </div>
  );
}

export default App;
