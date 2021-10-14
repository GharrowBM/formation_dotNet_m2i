import '../style/Liste.css'

import ListeCard from '../components/ListeCard'


function Liste({ToDoList, setToDoList}){
    
    
    return(
        <div className="card-container">
            {ToDoList.map((todo)=>{
                console.log(todo);
                return(<div >
                    <ListeCard
                    todo={todo.text}
                    key={todo.id}
                    />
                </div>)})
            }
        </div>
    )
}

export default Liste;