import './App.css';
import { BrowserRouter,Route,Routes, Link, useNavigate } from 'react-router-dom';
import Home from './Navigation/Home';
import About from './Navigation/About';
import Contact from './Navigation/Contact';
import User from './Navigation/User';
import { useState } from 'react';
import StudentCRUDWithUI from './Departmental Stores/StudentCRUDWithUI';


function App() {
  // const [id,setId]=useState('');
  // const navigate=useNavigate();

  // const sendId=(event)=>{
  //   setId(event.target.value)
  // }

  // const handleNavigation=()=>{
  //   navigate(`/user/${id}`)
  // }

  return (
    <div className="App">
      {/* <h1>Route in React</h1>
      <BrowserRouter>
         <div>
           <nav>
            
             <ul>
               <li>
                 <Link to="/">Home</Link>
               </li>
               <li>
                 <Link to="/about">About</Link>
               </li>
               <li>
                 <Link to="/contact">Contact</Link>
               </li>
               <li>
                 <Link to="/user/54">User</Link>
               </li>
             </ul>
           </nav>
          {/* <input type='text' value={id} onChange={sendId}/>
          <button type='button' onClick={handleNavigation}>Navigate Button</button>
            
            <hr/>
            <Routes>
               <Route exact path="/" element={<Home />} />
               <Route path="/about" element={<About />} />
             <Route path="/contact" element={<Contact />} />
             <Route path="/user/:id" element={<User/>} />
            </Routes> 
            
         </div>
     </BrowserRouter> */}
     {/* <Product/> */}
     <StudentCRUDWithUI/>
    </div>
  );
}

export default App;
