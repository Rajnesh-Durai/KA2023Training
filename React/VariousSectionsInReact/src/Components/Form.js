import React, { Component } from 'react'

export class Form extends Component {
    constructor()
    {
        super()
        this.state={
            username:''
        }
    }
    Changeto=(event)=>{
        this.setState({
            username:event.target.value
        })
    }
  render() {
    return (
      <div>
        <label>UserName</label>
        <input type='text' value={this.state.username} onChange={this.Changeto}></input>
      </div>
    )
  }
}

export default Form
