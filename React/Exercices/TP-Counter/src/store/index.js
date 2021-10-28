import { combineReducers, createStore, compose, applyMiddleware } from "redux";
import { counterReducer } from "./counterReducer";
import thunk from "redux-thunk"

const composeEnhancer = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

export default createStore(
    combineReducers({
        counter: counterReducer
    }),
    composeEnhancer(applyMiddleware(thunk))
    // applyMiddleware(thunk),
    // window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
)