import '../styles/FormationList.css'
import { coursList } from '../datas/CoursList'
import FormationCard from '../components/FormationCard'


function FormationList({Quantity , setQuantityValue}) {
    return (
        <div className="card-container">
            {coursList.map((cours, index )=>
            <div key={index} onClick={()=>setQuantityValue(Quantity +1)}>
                <FormationCard
                    name={cours.name}
                    logo={cours.logo}
                    category={cours.category}
                    difficulte={cours.difficulte}
                    price={cours.price}
                    index={index}
                />
            </div>
            )}
        </div>
    )
}

export default FormationList