import React, { useState } from 'react'

export default function Logincomponent1() {
    const [Loginstate,setLoginstate]=useState({
        username:"",
        password:""
    });
    const onusernamechangehandler=(e)=>{
        setLoginstate({
            ...Loginstate,
            username:e.target.value
        })
    };
    const onpasswordchangehandler=(e)=>{
        setLoginstate({
            ...Loginstate,
            password:e.target.value
        })
    };
    const loginhandler=(e)=>{
        e.preventDefault();
        console.log(e)
    }
  return (
    <div>
      <h1>Welcome to Login form</h1>
      <form onSubmit={loginhandler} onReset={(e)=>{setLoginstate({username:"",password:""})}}>
            <br />
          <input value={Loginstate.username} type="text" id="username" name="username" onChange={onusernamechangehandler} />
        <br />
          <input value={Loginstate.password} type="password" id="password" name="password" onChange={onpasswordchangehandler} />
        <br />
        <button type="submit">Login</button>
         <button type="reset">Reset</button>
      </form>
    </div>
  )
}
