import { useState } from "react"

function Delete({ indexTask, Tasks, setTasks }) {

    const [isOpen, setIsOpen] = useState(false)

    function handleSubmit(e) {
        Tasks.splice(indexTask, 1)
        setTasks([...Tasks])
        setIsOpen(true)
    }

    return isOpen ? (
        (<td><button type="submit" className="btn btn-danger" onClick={setIsOpen(false)}>Delete</button></td>)
    ) : (<td><button type="submit" className="btn btn-danger" onClick={handleSubmit}>Delete</button></td>)
}

export default Delete