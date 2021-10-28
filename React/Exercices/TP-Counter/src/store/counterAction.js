import { DECREASE_ACTION, INCREASE_ACTION } from './counterReducer.js'
export * as actionCreators from "./counterAction";


export const increaseCounterAction = (value) => {
    return (dispatch) => {
        dispatch({
            type: INCREASE_ACTION,
            payload: value
        });
    }
}


export const decreaseCounterAction = (value) => {
    return (dispatch) => {
        dispatch({
            type: DECREASE_ACTION,
            payload: value
        });
    }
}