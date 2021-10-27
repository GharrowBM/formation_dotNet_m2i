import store from './store/index'
import { Provider } from 'react-redux'
import{TodoListStore} from './components/TodoList'
import './App.css';

function App() {
  return (
    <div className="App">
      <Provider store={store}>
        <TodoListStore/>
      </Provider>
    </div>
  );
}

export default App;
