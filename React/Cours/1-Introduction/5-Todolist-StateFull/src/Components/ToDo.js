import React, { Component } from "react"

export class ToDo extends Component {
    constructor(props) {
        super(props)
        this.state = {
            edit : false,
            editToDoContent : undefined
        }
        //Dans les props, on va avoir un objet todo avec content, status
    }

    changeStatus = () => {
        const status = this.props.todo.status === 'done' ? 'undone' : 'done'
        this.props.changeStatus(this.props.todo.id, status)
    }
    renderDoneOrUnDoneButton = () => {
        if (this.props.todo.status === 'done') {
            return (
                <button onClick={this.changeStatus} className='btn btn-success m-1'>done</button>
            )
        }
        else {
            return (
                <button onClick={this.changeStatus} className='btn btn-danger m-1'>undone</button>
            )
        }
    }
    validEditToDo = (e) => {
        e.preventDefault()
        this.props.editToDo(this.props.todo.id,this.state.editToDoContent)
        this.setState({
            edit:false
        })
    }
    editToDo = () => {
        return (
            <form onSubmit={this.validEditToDo} className='col-6'>
                <input onChange= {(e) => {
                    this.setState({
                        editToDoContent : e.target.value
                    })
                }} type="text" className="form-control" defaultValue={this.props.todo.content} />
            </form>
        )
    }
    renderToDo = () => {
        if(!this.state.edit) {
           return this.renderContentToDo()
        }
        else {
           return this.editToDo()
        }
    }
    renderContentToDo = () => {
        return (
            <div onClick={this.changeStatus} className={(this.props.todo.status === 'done') ? 'btn col-6 text-success' : 'btn col-6 text-danger'}>
                {this.props.todo.content}
            </div>
        )
    }
    render() {
        return (
            <div className="row">
                {this.renderToDo()}
                <div className='col-2'>
                    {this.renderDoneOrUnDoneButton()}
                </div>
                <div className='col-2'>
                    <button className='btn btn-primary' onClick={() => {
                        this.setState({
                            edit : true
                        })
                    }}>edit</button>
                </div>
                <div className='col-2'>
                    <button className='btn btn-primary' onClick={() => {
                        this.props.deleteToDo(this.props.todo.id)
                    }}>delete</button>
                </div>
            </div>
        )
    }
}