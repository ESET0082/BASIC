import logo from './logo.svg';
import './App.css';
import React from 'react';
import {useState,createContext} from 'react';
import Usecontext from './Component/Usecontext';
import GopalComponent from './Component/GopalComponent';
import Usereducer from './Component/Usereducer';
import Callanapi from './Component/Callanapi'

const Context = React.createContext(null);
export {Context};

function App() {
  
  const [theme, setTheme] = useState("light");
  const [count, setcount] = useState();
  return (
    <div className="App">
      
      {/* <Context.Provider value={{ 
      theme, 
      setTheme, 
      count, 
      setcount 
      }}>
        <>Welcome to react app</>
      <Usecontext/>
      <GopalComponent/>
     
      </Context.Provider> */}
      <Usereducer/>
      <Callanapi/>

    </div>
  );
}

export default App;
