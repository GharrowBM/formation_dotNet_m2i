import './App.css';
import { useState, useEffect} from 'react'

function App() {

  useEffect(()=>{
    async function fetchPrices(){
      const response = await fetch('https://api.coindesk.com/v1/bpi/currentprice.json')
      const data = await response.json()
      console.log(data);
    }
    fetchPrices();
  },[])
  return (
    <div className="App">
      
    </div>
  );
}

export default App;
