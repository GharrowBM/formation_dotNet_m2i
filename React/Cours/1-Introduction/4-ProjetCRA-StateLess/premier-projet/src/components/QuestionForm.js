import {useState} from 'react'


function QuestionForm(){
    const[inputValue , setInputValue] = useState('Poser votre question')
    return(
        <div>
            <textarea cols="30" rows="10"
                value={inputValue}
                onChange={(e)=> setInputValue(e.target.value)}
            ></textarea>
        </div>
    )
}

export default QuestionForm