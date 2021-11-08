import { combineReducers, createStore, compose, applyMiddleware } from "redux";
import thunk from "redux-thunk"
import { entrepriseReducer } from "../reducers/Entreprise";

const composeEnhancer = compose
export default createStore(
    combineReducers({
        entreprise: entrepriseReducer
    }),
    composeEnhancer(applyMiddleware(thunk))
)