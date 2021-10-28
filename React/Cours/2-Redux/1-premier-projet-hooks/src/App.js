import store from './store/index';
import { Provider } from 'react-redux';
import{TodoListStore} from './components/TodoList';
import { TodoFilterStore } from './components/TodoFilter';
import './App.css';

function App() {
  return (
    <div>
      <Provider store={store}>
        <TodoFilterStore/>
        <TodoListStore/>
      </Provider>
    </div>
  );
}

export default App;
