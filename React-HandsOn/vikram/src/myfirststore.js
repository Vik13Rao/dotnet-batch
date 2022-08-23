 import { configureStore } from 'redux';

 // Reducer
function counter (state = { value: 0 }, action) {
    switch (action.type) {
    case 'INCREMENT':
      return { value: state.value + 1 }
    case 'DECREMENT':
      return { value: state.value - 1 }
    default:
      return state
    }
  }
let store = configureStore(counter)
  // Optional - you can pass `initialState` as a second arg
// let store = configureStore(counter, { value: 0 })

 
// Dispatches an action; this changes the state
store.dispatch({ type: 'INCREMENT' })
store.dispatch({ type: 'DECREMENT' })
// Gets the current state
store.getState()
// Listens for changes
store.subscribe(() => { ... })
