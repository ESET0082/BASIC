import React from 'react'
import { Link } from 'react-router-dom'
export default function NavBar() {
  return (
    <div>
        NavBar &nbsp;
         &rarr;
        {/* <a href='/'>home</a>
         <a href='/about'>About</a> */}
         
         <Link to='/'> home </Link>&nbsp;
          <Link to='/about'> about </Link>&nbsp;
      <p>navbar</p>
    </div>
  )
}
