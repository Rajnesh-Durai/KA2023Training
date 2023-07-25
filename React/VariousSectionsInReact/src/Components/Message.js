import React,{Component} from 'react'

class Message extends Component{
    constructor()
    {
        super()
        this.state={
            count:0
        }
        this.changeMessage = this.changeMessage.bind(this)
    }

    changeMessage()
    {
        this.setState({
            count:this.state.count+1
        }
        )
    }

    render()
    {
        return (
            <div>
                <h1>{this.state.count}</h1>
                <button onClick={this.changeMessage}>Subscribe</button>
            </div>
        )
    }
}
export default Message