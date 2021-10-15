import './App.css';
import Banner from './components/Banner';
//import QuestionForm from './components/QuestionForm'
//import Formulaire from './components/Formulaire'
//import FormationList from './components/FormationList';
import MiddleBar from './components/MiddleBar';

import { useEffect, useState } from 'react';

function App() {
  const savedCard = localStorage.getItem('cart');
  const[cart , updateCart] = useState(savedCard? JSON.parse(savedCard):[])
  useEffect(() => {
    localStorage.setItem('cart', JSON.stringify(cart))
  })

  return (
    <div className="App">
      <Banner />
      
      {/* <Formulaire/> */}
      <MiddleBar cart={cart} updateCart={updateCart}/>
    </div>
  );
}

export default App;
