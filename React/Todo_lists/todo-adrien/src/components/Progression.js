import '../styles/Progression.css'

function Progression(props,index){
    return(
        <span className="task row-1" key={index}>
            <div className="container nTask">
            <span className="col-2 p-2">{props.task}</span>
            </div>
            <button className="col-2 done m-1" onClick={(e) => e.target.innerHTML === "Done" ? e.target.innerHTML = "Undone" : e.target.innerHTML = "Done"}>Undone</button>
        </span>
    )
}

export default Progression 