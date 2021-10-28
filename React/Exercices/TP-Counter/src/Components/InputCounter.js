export function InputCounter({ setUserValue , IncreaseCounter, DecreaseCounter }) {
    return (
        <div>
            <input type="number" onChange={(e) => setUserValue(parseFloat(e.target.value))} id="usrValue" />
            <button onClick={IncreaseCounter}>+</button>
            <button onClick={DecreaseCounter}>-</button>
        </div>
    )
}