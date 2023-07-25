import React,{Component} from 'react'
import tiger from './siberian-tiger-snow_708_600x450.jpg'

class Welcome extends Component{
    render(){
        const {name,age}=this.props
        return (
            <div>
        <h1>Class Components</h1>
        <h1>This is {name} and my age is {age}</h1>
        <p>This is in para tag</p>
        <img src={tiger}  alt="logo"></img>
        </div>
        )
    }
}
export default Welcome