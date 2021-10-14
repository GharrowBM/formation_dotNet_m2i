import '../style/ListeCard.css'

function ListeCard({todo,index}){
    return(
        <div className="card" key={index}>
            {todo}
        </div>
    )
}

export default ListeCard;