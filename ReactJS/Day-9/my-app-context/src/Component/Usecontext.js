import React, { useContext } from 'react'
import { Context } from '../App'
export default function Usecontext() {
    const { theme, setTheme, count, setcount } = useContext(Context)
  return (
    <div>
        {theme}
        Gopal bhammar hello
        {theme}
        <button onClick={()=>setTheme("dark")}>Change theme</button>
      use Context
    </div>
  )
}
