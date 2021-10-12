
const difficultyLevel = {
    1: 'Débutant',
    2: 'Averti',
    3: 'Confirmé',
    4: 'Chevronné',
    5: 'Expert'
}


function CareScale({ scaleValue, careType }) {
    const range = [1, 2, 3, 4, 5]
    const scaleType = <img src="./img/Star.png" alt="star-icon" height="20px"></img>

    return (
        <div
            onClick={() =>
                alert(`Cette formation requiert un niveau ${difficultyLevel[scaleValue]}
             ${careType === "difficulte"} `)}
        >
            {range.map((rangeElem) =>
                scaleValue >= rangeElem ? (<span key={rangeElem.toString()}>{scaleType}</span>) : null
            )}
        </div>
    )
}

export default CareScale