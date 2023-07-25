import logo from './logo.svg';
import './App.css';
import Greet from './Components/Greet'
import Welcome from './Components/Welcome';
import Message from './Components/Message';
import FunctionClick from './Components/FunctionClick';
import ClassClick from './Components/ClassClick';
import Condition from './Components/Condition';
import ListRendering from './Components/ListRendering';
import UseState from './UseState';

function App() {
  return (
    <div className="App">
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Hello-World
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}
<UseState/>
       {/* <Greet name="Thomas" age='24'/> */}

      {/*<Welcome name='John' age='37'></Welcome>

      <Message/> */}

      {/* <FunctionClick/>
      <ClassClick/> */}

      {/* <Condition/> */}

      {/* <ListRendering/> */}
    </div>
  );
}

export default App;
