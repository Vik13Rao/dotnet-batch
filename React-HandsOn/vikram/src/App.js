import logo from './logo.svg';
import './App.css';
import React from 'react';
import { ReactDOM } from 'react-dom/client';




function App(){
  return <div>
    <AppChild name="Matt" />
    <App2 name = "Successful"/>
    </div>
}
function AppChild(props){
  return <span>
      My name is {props.name}
    </span>
}

function App2(props){
  return <p>Functional component : {props.name} </p>
}
// ReactDOM.render(<App />, document.getElementById('app'));

export default App;
