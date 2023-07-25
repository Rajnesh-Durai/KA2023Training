import React from 'react'
import Button from './Button'

const ModuleHandling = () => {
    const OpenButton=()=>{
        console.log("Clicked...!!");
    }
    const openButton2=()=>{
        console.log("ClickedForCase2...!!");
    }
  return (
    <div>
        <label>Module Handling case 1: </label>
      <Button onClick={OpenButton} text="Hello"/>
      <label>case 2 : </label>
      <Button onClick={openButton2} text="case2"/>
    </div>
  )
}

export default ModuleHandling
