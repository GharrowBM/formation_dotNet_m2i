/**
 * Reducer
 */
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
     completed: false
   }
 ]
 
 
 const ADD_TODO_ACTION = 'ADD_TODO_ACTION';
 
 
 function TodoReducer(state = initialState, action) {
   switch (action.type) {
     case ADD_TODO_ACTION:
       return [...state,{id:  ++id , ...action.payload, completed:false}]
     default:
       return state;
   }
 }
 
 // Affichage de la liste de state initialState
 const state = TodoReducer(undefined, {})
 
 // Ajout d'une todo par le reducer
 const newState = TodoReducer(state, {type:ADD_TODO_ACTION, payload:{title:"J'ajoute une Todo"}})
 
 console.log(state,newState);
