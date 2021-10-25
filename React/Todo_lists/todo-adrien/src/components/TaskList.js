import Edit from './Edit'
import Delete from './Delete'
import Progression from './Progression'


export default function TaskList(props){
    return(
        props.taskList.map((task, index) =>
            <div key={index}>
                <Progression
                    task={task}
                    index={index}
                />
                <Edit
                    setTaskListValue={props.setTaskListValue}
                    taskList={props.taskList}
                    index={index}
                />
                <Delete
                    setTaskListValue={props.setTaskListValue}
                    taskList={props.taskList}
                    index={index}
                />
            </div>)
    )
}
