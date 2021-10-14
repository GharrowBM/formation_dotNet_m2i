import '../styles/Edit.css'

function editTask(tab, index) {
        let edit = prompt("Edit")
        tab.splice(index, 1, edit)
        return tab
}

export default function Edit(props){
        return(
                <button className="edit m-1 col-2" onClick={() => {
                        props.setTaskListValue([...editTask(props.taskList,props.index)])
                }}>Edit</button>
        )
}
