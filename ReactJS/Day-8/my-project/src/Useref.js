import React, { useRef } from 'react';

export default function Useref() {
  const inputRef = useRef(null); // Step 1: Create a ref

  const handleFocus = () => {
    inputRef.current.focus(); // Step 3: Access the input and call focus
  };

  return (
    <div>
      <input type="text" ref={inputRef} /> {/* Step 2: Attach ref to input */}
      <button onClick={handleFocus}>Focus</button>
    </div>
  );
}
