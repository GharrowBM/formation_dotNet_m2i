import React, { Component } from "react"
import { FormToDo } from "./FormToDo"
import { NotificationToDo } from "./NotificationToDo"
import { ToDo } from "./ToDo"

export class ListToDos extends Component {
    constructor(props) {
        super(props)
        this.state = {
            todos: []
        }
    }

    addToDo = (text) => {
        //... => opérateur spread qui permet de recuperer la totalité des éléments du tableau
        let tmpTodos = [...this.state.todos]
        let newTodo = {
            // eslint-disable-next-line
            id: (this.state.todos[this.state.todos.length - 1] != undefined) ? (this.state.todos[this.state.todos.length - 1].id + 1) : 1,
            status: 'undone',
            content: text
        }
        tmpTodos.push(newTodo)

        // console.log("NewTodo: "+newTodo);
        // console.log(this.state.todos);
        this.setState({
            todos: tmpTodos
        })
        //console.log(this.state.todos);
    }

    deleteToDo = (id) => {
        let tmpTodos = []
        for (let todo of this.state.todos) {
            // eslint-disable-next-line      
            if (todo.id != id) {
                tmpTodos.push(todo)
            }
            // console.log(todo);
            // console.log(this.state.todos);
        }
        this.setState({
            todos: tmpTodos
        })
        //console.log(this.state.todos);
    }

    changeStatus = (id, newStatus) => {
        let tmpTodos = []
        for (let todo of this.state.todos) {
            // eslint-disable-next-line
            if (todo.id == id) {
                todo.status = newStatus
            }
            tmpTodos.push(todo)
        }
        this.setState({
            todos: tmpTodos
        })

    }

    editToDo = (id, newContent) => {
        let tmpTodos = []
        for (let todo of this.state.todos) {
            // eslint-disable-next-line
            if (todo.id == id) {
                todo.content = newContent
            }
            tmpTodos.push(todo)
            //console.log(todo);
            //console.log(this.state.todos);
        }
        this.setState({
            todos: tmpTodos
        })
        //console.log(this.state.todos);
    }

    render() {
        return (
            <div className="container">
                <h1 className="text-center">React ToDo List</h1>
                <FormToDo addToDo={this.addToDo} />
                <NotificationToDo numberTask={this.state.todos.length} />
                {this.state.todos.map((todo, key) => {
                    return (
                        <div key={key}>
                            <ToDo editToDo={this.editToDo} deleteToDo={this.deleteToDo} changeStatus={this.changeStatus} todo={todo} />
                        </div>
                    )
                })}
            </div>
        )
    }
}