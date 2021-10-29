import { getFromApi } from "../../services/DataApi"

export const IS_LOADING = 'IS_LOADING'
export const END_FETCHING_DATA = 'END_FETCHING_DATA'
export const ERROR_FETCHING_DATA = 'ERROR_FETCHING_DATA'
export const getWeater = (city) => {
    return (dispatch) => {
        dispatch({
            type : IS_LOADING,
            value: true
        })
        getFromApi(city).then(res => {
            dispatch({
                type : END_FETCHING_DATA,
                weather: res.data
            }) 
        }).catch(error => {
            dispatch({
                type : ERROR_FETCHING_DATA,
                error: error
            }) 
        })
        //Appel api weatch api
    }
}