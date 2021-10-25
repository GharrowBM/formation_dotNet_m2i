import { useState } from 'react'

function ToDoBtn(){

    const [isDone, setIsDone] = useState(false)

    return !isDone?(
        <td><button type="submit" className="btn btn-dark" onClick={()=> setIsDone(true)}>To do</button></td>                 
    ):(<td><button type="submit" className="btn btn-success" onClick={()=> setIsDone(false)}>Done</button></td>)
}

export default ToDoBtn