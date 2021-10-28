export const UPDATE_FILTER = 'UPDATE_FILTER'

export function filterReducer(state = null, action) {
    switch (action.type) {
        case UPDATE_FILTER:
            console.log("Update :"+state);
            return action.payload;
        default:
            console.log("default: "+state);
            return state;
    }
}