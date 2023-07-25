import React from 'react';
import './App.css'

import ControlledController from './components/Additional/ControlledController';
import ModuleHandling from './components/Additional/ModuleHandling';
import Footer from './components/Additional/Footer';
import Header from './components/Additional/Header';
function App() {

  // expenses -> helper constants
  const expenses = [
    { edate:new Date(2023, 5, 19), expname: 'Groceries', expamount: 1000 },
    { edate:new Date(2023, 6, 19), expname: 'Food', expamount: 2000 }
  ];
  return (
    <div>
      <Header/>
      <br></br>
      <br></br>
      <div>
        <h1>React Learning</h1> <h2>React Example</h2>
      </div>

      <ControlledController/>
      <br></br>
      <br></br>
      <ModuleHandling/>
      <br></br>
      <br></br>
      <Footer/>
    </div>
  );
}

export default App;
