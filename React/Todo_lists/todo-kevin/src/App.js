import Header from './components/Header';
import './App.css';
import Formulaire from './components/Formulaire';
import Liste from './components/Liste';
import { useState } from 'react';
import { coursList } from './datas/CoursList'


function App() {
  const coursListJson = coursList
  const [ToDoList, setToDoList] = useState(coursListJson ? coursListJson : [])
  console.log(ToDoList);

  // componentDidMount=()=>{
  //   setToDoList(coursList);
  // }
  return (
    <div className="App">
      <Header />
      <Formulaire ToDoList={ToDoList} setToDoList={setToDoList} />
      <Liste ToDoList={ToDoList} setToDoList={setToDoList} />
    </div>
  );
}

export default App;
