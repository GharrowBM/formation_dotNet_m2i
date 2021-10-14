import { useState , useEffect} from 'react'
import '../styles/Cart.css'


function Cart({ cart, updateCart }) {

    const [isOpen, setIsOpen] = useState(false)
    const total = cart.reduce((acc, cours)=>acc+ cours.amount * cours.price,0)

    useEffect(() => {
		document.title = `Panier: ${total}€ `
	}, [total]);

    return isOpen ? (
        <div className="relative">
            <div className='cart-list over'>
                {cart.length > 0 ? (
                    <div>
                        <h2>Panier</h2>
                        <div className="inner-card">
                            <div>
                                {cart.map(({ name, price, amount }, index) => (
                                    <div key={`${name}-${index}`}>
                                        {name} : {price}€ x {amount}
                                        <hr />
                                    </div>
                                ))}
                            </div>

                            <h3>Total :{total}€</h3>
                        </div>
                        <button className="btn btn-secondary" onClick={() => updateCart([])}>Vider le panier</button>
                    </div>
                ) : (
                    <div className="vide">Votre panier est vide</div>
                )}
                <button className="btn btn-secondary" onClick={() => setIsOpen(false)}>Fermer le Panier</button>
            </div>
        </div>
    ) : (
        <button className="btn btn-secondary" onClick={() => setIsOpen(true)}>Ouvrir le Panier</button>)
}

export default Cart