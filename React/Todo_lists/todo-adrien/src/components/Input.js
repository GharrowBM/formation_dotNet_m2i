import '../styles/Input.css'

export default function Input(props) {
    return (
        <div>
            <div className="form-control formulaire">
                <form className='' onSubmit={(e) => {
                    //empéche la page de se rafraichir
                    e.preventDefault()
                    props.taskList.includes(e.target["addTask"].value) ? alert("Tâche déjà prévue") : props.setTaskListValue([...props.taskList, e.target["addTask"].value])
                    }}>
                    <input className="add m-2" type="text" name="addTask" id="addTask" />
                    <button className='submit m-2' type='submit'>Ajouter une tâche</button>
                </form>
            </div>
            <h2 className="compteur">{props.taskList.length} tâches prévues</h2>
        </div>
    )
}