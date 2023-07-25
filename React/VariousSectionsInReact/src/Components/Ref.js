import React, { Component } from 'react'

export class Ref extends Component {
    constructor()
    {
        super()
        this.inref=React.createRef()
    }
    componentDidMount(){
        this.inref.current.focus();
        console.log(this.inref)
    }
  render() {
    return (
      <div>
        <input type='text' ref={this.inref}/>
      </div>
    )
  }
}

export default Ref
