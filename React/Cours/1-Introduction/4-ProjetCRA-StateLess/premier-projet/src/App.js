import './App.css';
import Banner from './components/Banner';
//import QuestionForm from './components/QuestionForm'
//import Formulaire from './components/Formulaire'
import FormationList from './components/FormationList';
import Cart from './components/Cart'
import { useState } from 'react';

function App() {
  const[Quantity , setQuantityValue] = useState(0)
  return (
    <div className="App">
      <Banner />
      <FormationList Quantity={Quantity} setQuantityValue={setQuantityValue}/>
      {/* <Formulaire/> */}
      <Cart Quantity={Quantity} setQuantityValue={setQuantityValue} />
    </div>
  );
}

export default App;
