const initialState = {
    isLoading: false,
    weather: undefined,
    error: undefined
}

export const weatherReducer = (state = initialState, action) => {
    switch (action.type) {
        case 'IS_LOADING':
            return {
                ...state,
                isLoading: action.value
            }
            break;
        case 'END_FETCHING_DATA':
            return {
                ...state,
                isLoading: false,
                weather: action.weather,
                error: undefined
            }
            break;
        case 'ERROR_FETCHING_DATA':
            return {
                ...state,
                isLoading: false,                
                error: action.error
            }
            break;
        default:
            return {...initialState}
            break
    }
}