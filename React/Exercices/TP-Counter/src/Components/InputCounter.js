// export function InputCounter({ setUserValue , IncreaseCounter, DecreaseCounter }) {
//     return (
//         <div>
//             <input type="number" onChange={(e) => setUserValue(parseFloat(e.target.value))} />
//             <button onClick={IncreaseCounter}>+</button>
//             <button onClick={DecreaseCounter}>-</button>
//         </div>
//     )
// }

import { PureComponent } from "react";

export class InputCounter extends PureComponent {
    constructor(props) {
        this.state = {
            userValue : 0
        }
    }

    render() {
        return(
            <div>
             <input type="number" onChange={(e) => this.setState({userValue: e.target.value})} />
             <button onClick={() => this.props.IncreaseCounter(this.state.userValue)}>+</button>
             <button onClick={() => this.props.DecreaseCounter(this.state.userValue)}>-</button>
         </div>
        )
    }
}