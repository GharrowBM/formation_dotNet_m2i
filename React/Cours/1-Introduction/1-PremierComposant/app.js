const nom ="Anthony Di Persio";
const element= <h2> Bonjour, {nom}</h2>


/**
 * Création d'un composant
 */
function MyComponent(){
    return <h2> Bonjour, {nom}</h2>
}


/**
 * Rendu
 */
ReactDOM.render(
    element,
    document.getElementById('root')
)

/**
 * Rendu d'un composant
 */

 ReactDOM.render( <MyComponent/> ,document.getElementById('app')
)

