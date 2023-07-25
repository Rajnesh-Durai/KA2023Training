import React from 'react'

// function Greet()
// {
//     return <h1>Hii All!!</h1>
// }
let Greet= (props)=>{
   
    return(
        <div>
        <h1>Hii {props.name} and his age is {props.age}</h1>
            {props.children}
        </div>)
}
export default Greet