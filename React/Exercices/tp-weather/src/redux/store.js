import { combineReducers, createStore, compose, applyMiddleware } from "redux";
import thunk from "redux-thunk"
import { weatherReducer } from "./reducers";

const composeEnhancer = compose
export default createStore(
    combineReducers({
        weather: weatherReducer
    }),
    composeEnhancer(applyMiddleware(thunk))
)