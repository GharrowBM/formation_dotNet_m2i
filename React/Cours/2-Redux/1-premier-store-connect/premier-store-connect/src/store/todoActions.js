import { ADD_TODO_ACTION, UPDATE_TODO_ACTION } from '../store/todoReducer'

export const toggleTodoAction =(todo)=>({
    type: UPDATE_TODO_ACTION,
    payload:{...todo, completed : !todo.completed }
})