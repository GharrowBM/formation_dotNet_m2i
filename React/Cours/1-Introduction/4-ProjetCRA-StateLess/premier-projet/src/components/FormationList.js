import '../styles/FormationList.css'
import { coursList } from '../datas/CoursList'
import FormationCard from '../components/FormationCard'


function FormationList() {
    return (
        <div className="card-container">
            {coursList.map((cours, index )=>
            <div key={index}>
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