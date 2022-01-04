import axios from "axios"
const baseUrl = "http://localhost:5000/api/v1"
export const getAllTodos = () => {
    return axios.get(baseUrl + '/todo')
}

export const getTodo = (id) => {
    return axios.get(baseUrl + '/todo/'+id)
}

export const postTodo = (todo) => {
    return axios.post(baseUrl + '/todo', {...todo})
}