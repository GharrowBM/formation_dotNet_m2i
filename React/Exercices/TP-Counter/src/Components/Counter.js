import { useSelector, useDispatch, connect } from "react-redux"
import { bindActionCreators } from 'redux'
import { PureComponent, useState } from 'react'
import { actionCreators } from "../store/counterAction"
import { counterSelector } from '../store/counterSelector'
import { AffichageCounter } from "./AffichageCounter"
import { InputCounter } from "./InputCounter"


// export function Counter({ counter, IncreaseCounter, DecreaseCounter, setUserValue }) {
//     return (
//         <div>
//             <InputCounter IncreaseCounter={IncreaseCounter} DecreaseCounter={DecreaseCounter} setUserValue={setUserValue} />
//             <AffichageCounter counter={counter}/>
//         </div>
//     )
// }

// export function CounterStore() {

//     const counter = useSelector(counterSelector)

//     //console.log(counter);

//     const [userValue, setUserValue] = useState(0)

//     const dispatch = useDispatch();

//     const { increaseCounterAction, decreaseCounterAction } = bindActionCreators(actionCreators, dispatch);

//     function IncreaseCounter() {
//         if (document.getElementById("usrValue").value !== '') {
//             increaseCounterAction(userValue)
//             document.getElementById("usrValue").value = '';
//         } else {
//             alert("Veuillez saisir un nombre.")
//         }
//     }

//     function DecreaseCounter() {
//         console.log(document.getElementById("usrValue").value);
//         if (document.getElementById("usrValue").value !== '') {
//             decreaseCounterAction(userValue)
//             document.getElementById("usrValue").value = '';
//         } else {
//             alert("Veuillez saisir un nombre.")
//         }
//     }

//     // Utilisation de notre composant sans logique store
//     return <Counter counter={counter} IncreaseCounter={IncreaseCounter} DecreaseCounter={DecreaseCounter} setUserValue={setUserValue} />
// }


class Counter extends PureComponent {
    
    constructor(props) {
    }
}

const mapStateToProps = (state) => {
    return {
        counter : state.counter.value,
        loading : state.counter.isLoading
    }
}
const mapActionToProps = (dispatch) => {
    return {

    }
}
export default connect(mapStateToProps, mapActionToProps)(Counter)