
// Initial State
const initialState = 0;

// Définition des Actions
export const INCREASE_ACTION = 'INCREASE_ACTION';
export const DECREASE_ACTION = 'DECREASE_ACTION';


export function counterReducer(state = initialState, action) {
    switch (action.type) {
        // Création d'une action
        case INCREASE_ACTION:
            return state + action.payload;
        case DECREASE_ACTION:
            return state - action.payload;
        default:
            return state;
    }
};