import { useState } from 'react'
import QuestionForm from './QuestionForm'
import '../styles/Formulaire.css'


function handleSubmit(e) {
    e.preventDefault()
    alert(e.target['nom'].value)
}

function Formulaire() {
    const [inputValue, setInputValue] = useState('Saisissez votre question')
    const [nom, setNomValue] = useState('')
    const [prenom, setPrenomValue] = useState('')
    const [email, setEmailValue] = useState('')
    const [type, setTypeValue] = useState('')
    const [text, setTextValue] = useState('')

    return (

        <div>
            <div className="card">
                <h1>Demande de renseignements</h1>
                <QuestionForm />
                <form onSubmit={handleSubmit}>
                    <div className="form-control formulaire">
                        <div className="mb-3">
                            <label htmlFor="nom" className='form-label'>Nom :</label>
                            <input type="text" name="nom" id="nom" onChange={(e) => setNomValue(e.target.value)} className='form-control' />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="nom" className='form-label'>Prenom :</label>
                            <input type="text" name="prenom" id="prenom" onChange={(e) => setPrenomValue(e.target.value)} className='form-control' />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="nom" className='form-label'>Email Adress</label>
                            <input type="email" name="email" id="email" onChange={(e) => setEmailValue(e.target.value)} className='form-control' />
                        </div>
                        <select className="form-select" aria-label="Default select example" onChange={(e) => setTypeValue(e.target.value)}>
                            <option selected disabled>Choisissez le type de demande</option>
                            <option value="1">Renseignements à propos d'une formation</option>
                            <option value="2">Demande de rendez-vous</option>
                            <option value="3">Autre...</option>
                        </select>

                        <div className="mb-3">
                            <label htmlFor="userText" className='form-label'>Rédigez votre demande</label>
                            <textarea className='form-control' name='userText' id='userText' cols="30" rows="10" onChange={(e) => setTextValue(e.target.value)}></textarea>
                        </div>
                        <button type='submit' className='btn btn-secondary'>Valider</button>
                    </div>
                </form>
            </div>
            <div className="card">
            <h1>Affichage résultats</h1>
                <div className="form-control">
                    <div>
                        <textarea cols="30" rows="10"
                            value={inputValue}
                            onChange={(e) => setInputValue(e.target.value)}
                        ></textarea>
                    </div>
                    <div className="mb-3">
                        <label htmlFor="nom" className='form-label'>Nom :</label>
                        <input type="text" name="nom" id="nom" placeholder={nom} className='form-control' />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="nom" className='form-label'>Prenom :</label>
                        <input type="text" name="nom" id="nom" placeholder={prenom} className='form-control' />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="nom" className='form-label'>Email Adress</label>
                        <input type="email" name="nom" id="nom" placeholder={email} className='form-control' />
                    </div>
                    <select className="form-select" aria-label="Default select example" value={type}>
                        <option selected disabled>Choisissez le type de demande</option>
                        <option value="1">Renseignements à propos d'une formation</option>
                        <option value="2">Demande de rendez-vous</option>
                        <option value="3">Autre...</option>
                    </select>

                    <div className="mb-3">
                        <label htmlFor="userText" className='form-label'>Rédigez votre demande</label>
                        <textarea className='form-control' name='userText' id='userText' cols="30" rows="10" placeholder={text}></textarea>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Formulaire