import ToDoBtn from './ToDoBtn'
import Edit from './Edit'
import Delete from './Delete'

function TasksList({ Tasks, setTasks }) {

    return (
        <div>
            <div className="alert alert-success row" role="alert">
                <span className="text-center">{Tasks.length} task(s)</span>
            </div>
            <table className="table caption-top">
                <tbody>
                    {Tasks.map((task, index) =>
                        <tr key={index}>
                            <th scope="row">{index + 1}</th>
                            <td>{task}</td>
                            <ToDoBtn />
                            <Edit taskName={task} indexTask={index} Tasks={Tasks} setTasks={setTasks}/>
                            <Delete indexTask={index} Tasks={Tasks} setTasks={setTasks}/>
                        </tr>
                    )}
                </tbody>
            </table>
        </div>
    )
}

export default TasksList