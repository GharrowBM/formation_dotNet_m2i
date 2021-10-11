import CareScale from './CareScale'
import '../styles/FormationCard.css'


function handleClick(cours){
    console.log(cours);
    alert(`Ceci est un click sur : ${cours}`);
}

function FormationCard(cours, index) {
    return (
        <div className="card" key={index} onClick={()=>handleClick(cours)}>
            <div className="card-title">
                {cours.name}
            </div>
            <div>
                <img src={cours.logo} alt={`${cours.name} logo`} className="img" />
            </div>
            <div className="category">
                <span className="cat-label">Catégorie : </span>
                {cours.category}
            </div>
            <div className="difficulte">
                <span className="dif-label">Difficulté : </span>
                <CareScale scaleValue={cours.difficulte} careType="difficulte" className="stars" />
            </div>
            <div className="price">
                {cours.price}€
            </div>
        </div>
        
    )
}

export default FormationCard