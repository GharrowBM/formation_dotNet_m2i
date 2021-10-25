import React, { Component } from "react"

export class FormToDo extends Component {
    constructor(props) {
        super(props)
        this.state= {
            contentTask : undefined
        }
    }

    submit = (e) => {
        e.preventDefault()
        // eslint-disable-next-line
        if(this.state.contentTask != undefined) {
            this.props.addToDo(this.state.contentTask)
            this.setState({
                contentTask : ''
            })
        }
    }

    changeField = (e) => {
        this.setState({
            contentTask : e.target.value
        })
    }
    
    render() {
        return (
            <form className='row m-1' onSubmit={this.submit}>
                <div className="col-9">
                    <input type='text' onChange={this.changeField} value={this.state.contentTask} className='form-control' placeholder="Content of task" />
                </div>
                <div className="col-3">
                    <button type="submit" className="form-control btn btn-secondary">Create</button>
                </div>
            </form>
        )
    }
}