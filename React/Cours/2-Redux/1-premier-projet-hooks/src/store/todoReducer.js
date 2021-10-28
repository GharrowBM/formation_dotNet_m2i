
let id = 2;

const initialState = [
    {
        id: 1,
        title: 'Apprendre React',
        completed: false
    },
    {
        id: 2,
        title: 'Pratiquer React',
        completed: true
    },
    {
        id: 3,
        title: 'Créer des composants',
        completed: true
    },
    {
        id: 4,
        title: 'Créer un store',
        completed: true
    },
    {
        id: 5,
        title: 'Muter les state avec les actions',
        completed: true
    },
    {
        id: 6,
        title: 'Utilisr les state avec les Selectors',
        completed: true
    }
]


export const ADD_TODO_ACTION = 'ADD_TODO_ACTION';
export const UPDATE_TODO_ACTION = 'UPDATE_TODO_ACTION';
export const DELETE_TODO_ACTION = 'DELETE_TODO_ACTION';


export function TodoReducer(state = initialState, action) {
    switch (action.type) {
        case ADD_TODO_ACTION:
            return [...state, { id: ++id, ...action.payload, completed: false }]
        case UPDATE_TODO_ACTION:
            return state.map(todo => {
                if (todo.id === action.payload.id) {
                    return { ...todo, ...action.payload }
                } else {
                    return todo
                }
            })
        case DELETE_TODO_ACTION:
            return state.filter(todo => todo.id !== action.payload)
        default:
            return state;
    }
}
