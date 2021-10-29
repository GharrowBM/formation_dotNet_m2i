
// Initial State
const initialState =  {
    isLoading : false,
    value:0,
};

// Définition des Actions
export const INCREASE_ACTION = 'INCREASE_ACTION';
export const DECREASE_ACTION = 'DECREASE_ACTION';
export const ISLOADING_ACTION = 'ISLOADING_ACTION';


export function counterReducer(state = initialState, action) {
    switch (action.type) {
        // Création d'une action
        case INCREASE_ACTION:
            return {
                ...state,
                value: state.value + parseInt(action.payload),
                isLoading: false
            };
        case DECREASE_ACTION:
            return {
                ...state,
                value: state.value - parseInt(action.payload),
                isLoading: false
            };
        case  ISLOADING_ACTION:
            return {
                ...state,
                isLoading: action.payload
            }
        default:
            return state;
    }
};