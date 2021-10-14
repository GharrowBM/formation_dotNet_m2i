import { useState } from 'react';
import '../style/Formulaire.css'



function Formulaire({ ToDoList, setToDoList }) {
    const [todo, setTodo] = useState("")


    // function handleSubmit(e){
    //     e.preventDefault()
    //     setToDoList([
    //         ...ToDoList,
    //          todo
    //         ])
    //         console.log(todo);
    //         console.table(ToDoList);
    // }

    function addToDo() {
        //... => opérateur spread qui permet de recuperer la totalité des éléments du tableau
        let tmpTodos = [...ToDoList]
        console.log("tmpTodos[0] : " + tmpTodos[0]['text']);
        console.log("tmpTodos[1] : " + tmpTodos[1]['text']);
        console.log("tmpTodos[2] : " + tmpTodos[2]['text']);
        console.log("ToDoList.Length = " + ToDoList.length);
        console.log("ToDoList[0].id = " + ToDoList[0].id);
        
        let newTodo = {
            id: (ToDoList[ToDoList.length - 1] !== undefined) ? (ToDoList[ToDoList.length - 1].id + 1) : 1,
            text: todo,
            done: false            
        }

        console.log("newTodo.id : " + newTodo.id);
        console.log("newTodo.text : " + newTodo.text);
        console.log("newTodo.done : " + newTodo.done);
        console.log("newTodo : " + newTodo);
        tmpTodos.push(newTodo)
        console.log("ToDoList : "+ToDoList);

        console.table("tmpTodos: "+tmpTodos);
        
        setToDoList(tmpTodos)
        console.log("ToDoList"+ToDoList);

        
        setTodo("")
    }

    return (
        <div className="display">
            <div className="form">
                <input type="text" onChange={(e) => setTodo(e.target.value)} className='form-control' />
            </div>
            {/* <button className="btn btn-dark" onClick={handleSubmit}>Créer</button> */}
            <button className="btn btn-dark" onClick={() => addToDo()}>Créer</button>
        </div>
    )
}
export default Formulaire;