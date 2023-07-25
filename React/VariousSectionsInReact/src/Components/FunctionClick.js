import React from 'react'

function FunctionClick() {
    function ClickEvent()
    {
        console.log("Button Clicked")
    }
    
  return (
    <div>
      <button onClick={()=>ClickEvent()}>Click</button>
    </div>
  )
}

export default FunctionClick
