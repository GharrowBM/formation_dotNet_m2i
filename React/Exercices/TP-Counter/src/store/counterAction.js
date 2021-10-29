import { DECREASE_ACTION, INCREASE_ACTION, ISLOADING_ACTION } from './counterReducer.js'
export * as actionCreators from "./counterAction";


export const increaseCounterAction = (value) => {
    // return (dispatch) => {
    //     dispatch({
    //         type: INCREASE_ACTION,
    //         payload: value
    //     });
    // }

    // fetch("").then(res => {
    //     return ({
    //         type: INCREASE_ACTION,
    //         payload: value -1
    //     })
    // }).catch(() => {
    //     return ({
    //         type: INCREASE_ACTION,
    //         payload: value
    //     })
    // })

    return dispatch => {
        dispatch({
            type: ISLOADING_ACTION,
            payload: true
        })
        setTimeout(() => {
            dispatch({
                type: INCREASE_ACTION,
                payload: value
            })
        },2000)
    }
    // return ({
    //     type: INCREASE_ACTION,
    //     payload: value
    // })
}


export const decreaseCounterAction = (value) => {
    // return (dispatch) => {
    //     dispatch({
    //         type: DECREASE_ACTION,
    //         payload: value
    //     });
    // }
    return ({
        type: DECREASE_ACTION,
        payload: value
    });
}