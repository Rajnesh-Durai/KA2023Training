import React, { Component } from 'react'

export class ClassClick extends Component {
    
  render() {
    function clickEvent(){
        console.log("Clicked!!")
     }
    return (
      <div>
        <button onClick={clickEvent}>Click</button>
      </div>
    )
  }
}

export default ClassClick
