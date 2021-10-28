export const todoSelector = ({ todos }) => todos

export const filtreredTodoSelector=({todos,filter})=>{
    if(filter === null){
        return todos
    }
    return todos.filter(todo => todo.completed === filter)
}