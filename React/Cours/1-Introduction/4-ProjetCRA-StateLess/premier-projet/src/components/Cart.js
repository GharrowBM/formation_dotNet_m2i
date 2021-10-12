import { useState } from 'react'
import '../styles/Cart.css'

function Cart({Quantity , setQuantityValue}){
    
    const[isOpen, setIsOpen] = useState(false)
    const price = 199

    
    return isOpen? (
        <div className="card">
            <h2>Panier</h2>
            <div>
                Prix : {price}
            </div>
            <button onClick={()=> setQuantityValue(Quantity +1)}>Ajouter</button>
            <hr/>
            <h3>Total : { price * Quantity}€</h3>
            <hr/>
            <button onClick={()=> setIsOpen(false)}>Fermer</button>
        </div>
    ) : (<button onClick={()=> setIsOpen(true)}>Ouvrir</button>)
}

export default Cart