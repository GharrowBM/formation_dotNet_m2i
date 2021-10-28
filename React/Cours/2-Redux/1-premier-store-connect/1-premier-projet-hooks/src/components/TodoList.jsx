import { useDispatch, useSelector } from "react-redux"
//import { UPDATE_TODO_ACTION } from '../store/todoReducer'
import { todoSelector } from "../store/todoSelector";
import { toggleTodoAction ,deleteTodoAction} from "../store/todoActions";
import { useCallback } from "react";

export function TodoItem({ todo, onToggle, onDelete }) {
    console.log(todo.title);
    return <li>
        <label>
            <input type="checkbox" checked={todo.completed} onChange={() => onToggle(todo)} />
            {todo.title}
            <button onClick={()=> onDelete(todo)}>X</button>
        </label>
    </li>
}
// Gardonc un composant découplé du store
export function TodoList({ todos, onToggle, onDelete }) {
    return <ul>
        {todos.map(todo => <TodoItem todo={todo} onToggle={onToggle} key={todo.id} onDelete={onDelete}/>)}
    </ul>
}


export function TodoListStore(){
    const todos = useSelector(todoSelector)
    const dispatch = useDispatch()
    // Toggle completed
    const onToggle = useCallback((todo) => {
        dispatch(toggleTodoAction(todo))
    }, [])
    // Ajout de l'action Delete
    const onDelete = useCallback(todo =>{
        dispatch(deleteTodoAction(todo))
    })
    return <TodoList todos={todos} onToggle={onToggle} onDelete={onDelete} />
}

// Component fortement couplé avec le store
// export function TodoList() {
//     const todos = useSelector(todoSelector)
//     const dispatch = useDispatch()
//     const onToggle = useCallback((todo) => {
//         dispatch(toggleTodoAction(todo))
//     }, [])
//     return <ul>
//         {todos.map(todo => <TodoItem todo={todo} onToggle={onToggle} key={todo.id} />)}
//     </ul>
// }




// export const TodoListStore = connect(
//     (state) => ({
//         //todos: state.todos
//         todos: todoSelector(state)
//     }),
//     (dispatch) => ({
//         // onToggle: (todo) => dispatch({
//         //     type: UPDATE_TODO_ACTION,
//         //     payload: { ...todo, completed: !todo.completed }
//         // })
//         onToggle:todo => dispatch(toggleTodoAction(todo))
//     })
// )(TodoList)