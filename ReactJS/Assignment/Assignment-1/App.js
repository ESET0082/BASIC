// src/App.js
import { useState } from 'react';
import Counter from './Counter';

function App() {
  const [count, setCount] = useState(0);

  const handleIncrement = () => {
    setCount(prevCount => prevCount + 1);
    console.log("Increment clicked");
  };

  const handleDecrement = () => {
    setCount(prevCount => prevCount - 1);
    console.log("Decrement clicked");
  };

  return (
    <div>
      <h1>Counter Application</h1>
      <p>Count: {count}</p>
      <button onClick={handleIncrement}>Increment</button>
      <button onClick={handleDecrement}>Decrement</button>
    </div>
  );
}

export default App;