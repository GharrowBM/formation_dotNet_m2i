const initialState = {
    etablissement: undefined,
    isLoading: false
}
export const entrepriseReducer = (state = initialState,action) => {
    switch(action.type) {
        case 'START_FETCHING_DATA':
            return {
                ...state,
                isLoading : true
            }    
        break;
        case 'END_FETCHING_DATA':
            return {
                ...state,
                isLoading : false,
                etablissement : action.data
            }    
        break;
        default: {
            return {...initialState}
        }
    }
}