import { useState } from "react"

function Edit({ taskName, indexTask, Tasks, setTasks }) {

    const [TaskTemp, setTaskTemp] = useState('')
    const [isOpen, setIsOpen] = useState(false)

    function refreshInput(e) {
        e.preventDefault()
        setTaskTemp(e.target.value)
    }

    function handleSubmit(e) {
        e.preventDefault()
        TaskTemp?Tasks.splice(indexTask,1,TaskTemp):setTasks([...Tasks])
        setTasks([...Tasks])
        setIsOpen(false)
    }
    return isOpen?(
        <div>
            <form>
                <div className="row g-3">
                    <div className="form-group w-75 ms-5 col-auto">
                        <input type="text" name="task" id="task" onChange={refreshInput} className="form-control" placeholder={taskName}/>
                    </div>
                    <div className="col-auto">
                        <button type="submit" className="btn btn-primary" onClick={handleSubmit}>Edit</button>
                    </div>
                </div>
            </form>
        </div>
    ) : (<div className="col-auto"> <button type="submit" className="btn btn-primary" onClick={()=>setIsOpen(true)}>Edit</button> </div>)
}

export default Edit