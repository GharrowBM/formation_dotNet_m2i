import '../styles/Delete.css'

function deleteTask(tab, index) {
    tab.splice(index, 1)
    return tab
}

export default function Delete(props) {
    return (
        <button className="delete m-1 col-2" onClick={() => {
            props.setTaskListValue([...deleteTask(props.taskList, props.index)])
        }}>Delete</button>
    )
}