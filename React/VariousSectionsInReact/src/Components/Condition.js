import React, { Component } from 'react'

export class Condition extends Component {
    constructor()
    {
        super()
        this.state={
            isLoggedIn:false
        }
    }
  render() {

//     if( this.state.isLoggedIn=="true"){
//         return (
//             <div>
//                 <h1>Hello Rajnesh</h1>
//             </div>
//         )
//     }
//     else{
//     return (
//       <div>
//         <h1>Hello Haseena</h1>
//       </div>
//     )
//   }
    return this.state.isLoggedIn=="true"? (<div><h1>Hello Rajnesh</h1></div> ): (<div><h1>Hello Laxmeesh</h1></div>)
}
}

export default Condition
