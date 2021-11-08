import React from 'react';
import logo from './logo.svg';
import FormContainer from "./containers/FormContainer"
import ResultContainer from './containers/ResultContainer';
import './App.css';
import 'antd/dist/antd.css';
function App() {
  return (
    <div className="App">
      <FormContainer />
      <ResultContainer></ResultContainer>
    </div>
  );
}

export default App;
