import { combineReducers, createStore } from "redux";
import {TodoReducer} from './todoReducer'
import {filterReducer} from './filterReducer'

export default createStore(
    combineReducers({
        todos : TodoReducer,
        filter: filterReducer
    }),
    window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
)