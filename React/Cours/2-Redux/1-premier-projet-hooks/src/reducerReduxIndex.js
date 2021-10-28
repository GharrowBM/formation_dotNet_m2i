/**
 * Créaton d'un store Redux
 * 
 * npm install react-redux redux
 */

 import {createStore} from 'redux'


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
 
 /**
  * Création d'un store 
  */
 
 const store = createStore(TodoReducer);
 
 // Abonnement au store grace à la fonction subscribe qui est déclenché à chaque changement d'etat d'un state du store
 // Grace à la lambda, nous retourne le store => getState()
 store.subscribe(()=> console.log(store.getState()))
 
 // Interraction avec le store
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});
 store.dispatch({type:ADD_TODO_ACTION , payload:{title:"J'ajoute une todo"}});