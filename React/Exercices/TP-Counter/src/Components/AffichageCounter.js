export function AffichageCounter({ counter, loading }) {
    return (
        <div>
            <h1>Le compteur affiche :</h1>
            {(loading) ? (<div>En cours de clacule</div>) : null}
            <h1> {counter}</h1>
        </div>
    )
}