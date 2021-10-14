import React, { Component } from "react"

export class NotificationToDo extends Component {
    
    render() {
        return (
            <div className="row ">
                <div className="col alert alert-primary">
                    {this.props.numberTask} {this.props.numberTask > 1 ? 'tasks' : 'task'}
                </div>
            </div>
        )
    }
}