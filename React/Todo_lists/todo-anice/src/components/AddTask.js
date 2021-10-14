import {useState} from 'react'

function AddTask({Tasks, setTasks}){
    
    const [TaskTemp, setTaskTemp] = useState('')

    function refreshInput(e){
        e.preventDefault()
        setTaskTemp(e.target.value)
    }

    function handleSubmit(e){
        e.preventDefault()
        setTasks([...Tasks,TaskTemp])
    }
    return (
        <div>
        <form>
            <div className="row g-3">
            <div className="form-group w-75 ms-5 col-auto">
                <input type="text" name="task" id="task" onChange={refreshInput} className="form-control"/>
            </div>
            <div className="col-auto ">
            <button type="submit" className="btn btn-secondary " onClick={handleSubmit} >Create</button>
            </div>
            </div>
        </form>
        </div>   
    )   
}

export default AddTask