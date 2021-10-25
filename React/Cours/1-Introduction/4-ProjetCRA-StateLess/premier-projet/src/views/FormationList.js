import '../styles/FormationList.css'
import { coursList } from '../datas/CoursList'
import FormationCard from '../components/FormationCard'
import Category from '../components/Category'
import { useState } from 'react'
import Cart from '../components/Cart'


function FormationList({ cart, updateCart }) {
    const [activeCategory, setActiveCategory] = useState('')

    const categoryList = coursList.reduce(
        (acc, elem) =>
            acc.includes(elem.category) ? acc : acc.concat(elem.category),
        []
    )
    function addToCart(name, price){
        const currentCoursAdded = cart.find((cours) => cours.name === name)
        if (currentCoursAdded) {
            const cartFilteredCurrentCours = cart.filter(
                (cours) => cours.name !== name
            )
            updateCart([
                ...cartFilteredCurrentCours,
                { name, price, amount: currentCoursAdded.amount + 1 }
            ])
        }
        else {
            updateCart([...cart, { name, price, amount: 1 }])
        }
        alert(`Le cours ${name} a été ajouté!`)
    }

    return (
        <div className="formation">
            <h2>Nos Formation</h2>
            <div className="search">
                <div className="row">
                    <div className="col-9">
                        <Category
                            categoryList={categoryList}
                            setActiveCategory={setActiveCategory}
                            activeCategory={activeCategory}
                        />
                    </div>
                    <div className="col-3">
                        <Cart cart={cart} updateCart={updateCart} />
                    </div>
                </div>
            </div>
            <div className='card-container'>
                {coursList.map((cours, index) =>
                    !activeCategory || activeCategory === cours.category ? (
                        <div key={index} onClick={() => addToCart(cours.name, cours.price)}>
                            <FormationCard
                                name={cours.name}
                                logo={cours.logo}
                                category={cours.category}
                                difficulte={cours.difficulte}
                                price={cours.price}
                                index={index}
                            />
                        </div>
                    ) : null
                )}
            </div>
        </div>
    )
}

export default FormationList