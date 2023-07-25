import React, { useState } from 'react'

const UseState = () => {
  const [car,carDetail]=useState({
    model:"Tata",
    engine:'Petrol',
    year:2023,
    color:'red'
  });
  const TapMe=()=>{
    carDetail(p=>{
      return {...p,color:'fffffff'}
    })
    }
  
  return (
    <div>
      <p>I have a {car.model} which is a {car.engine} car and it is {car.color} color one...{car.model}</p>
      <button onClick={TapMe}>Tap Here</button>
    </div>
  )
  }

export default UseState

