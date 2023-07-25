import React, { useState } from 'react'

const ControlledController = () => {
    const [inputValue,setInputValue]=useState('');
    const handleChange=(event)=>{
        setInputValue(event.target.value)
        console.log(event.target.value)
    }

    let [count,setCount]=useState(0)
    // const incrementFn=()=>{
    //     setCount(count+=1)
    // }
  return (
    <div>
        <div>
            <label htmlFor='inputField'>Enter a Value</label>
            <input type='text' id='inputField' value={inputValue} onChange={handleChange}></input>
            <div>
                <p>Entered Value:{inputValue}</p>
            </div>
        </div>
        <div>
            <p>Count:{count}</p>
            <button onClick={()=>{
               setCount( count=count+1);
            }}>Click me</button>
        </div>
    </div>
  )
}

export default ControlledController
