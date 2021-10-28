import { combineReducers, createStore } from "redux";
import {TodoReducer} from './todoReducer'

export default createStore(
    combineReducers({
        todos : TodoReducer,
        filter:(state=0,action)=>state
    }),
    window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
)