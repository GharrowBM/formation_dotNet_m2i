import axios from "axios"

export const getSiretData = (siret) => {
    return (dispatch) => {
        dispatch({type:'START_FETCHING_DATA'})
        axios.get("https://api.insee.fr/entreprises/sirene/V3/siret/"+siret, {headers : {'Authorization' : 'Bearer '+ process.env.REACT_APP_API_KEY}})
        .then(res => {
            if(res.data.header.statut === 200) {
                dispatch({type:'END_FETCHING_DATA', data: res.data.etablissement})
            }
            console.log(res.data);
        }).catch(err => {
            console.log(err)
        })
    }
}