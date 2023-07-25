import React from 'react'

function ListRendering() {
    let arr=[1,2,3,4]
    let arr2=[{
        name:"raja",
        age:24,
        prof:"Developer"
    },
{
    name:"rajnesh",
    age:54,
    prof:"Cloud" 
},
{
    name:"rajEESH",
        age:22,
        prof:"DB"
}]
let mapping1=arr.map(obj=>obj+1)
    let mapping=arr2.map(obj=> <h1>I am {obj.name} and I am {obj.age} with a profession of {obj.prof}</h1>)
  return (
    <div>
      {mapping1}
      {mapping}
    </div>
  )
}

export default ListRendering
