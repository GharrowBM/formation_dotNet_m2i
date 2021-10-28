import { connect } from "react-redux"
//import { UPDATE_TODO_ACTION } from '../store/todoReducer'
import { todoSelector } from "../store/todoSelector";
import { toggleTodoAction } from "../store/todoActions";

export function TodoItem({todo, onToggle}) {
    console.log(todo.title);
    return <li>
        <label>
            <input type="checkbox" checked ={todo.completed} onChange={()=>onToggle(todo)}/>
            {todo.title}
        </label>
    </li>
}

export function TodoList({todos, onToggle}) {
    //return 'Todolist Component'
    // return JSON.stringify(todos)
    return <ul>
        {todos.map(todo => <TodoItem todo={todo} onToggle={onToggle} key={todo.id} />)}
    </ul>
}

export const TodoListStore = connect(
    (state) => ({
        //todos: state.todos
        todos: todoSelector(state)
    }),
    (dispatch) => ({
        // onToggle: (todo) => dispatch({
        //     type: UPDATE_TODO_ACTION,
        //     payload: { ...todo, completed: !todo.completed }
        // })
        onToggle:todo => dispatch(toggleTodoAction(todo))
    })
)(TodoList)