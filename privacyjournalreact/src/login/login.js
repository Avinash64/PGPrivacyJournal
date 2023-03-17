import React from 'react'
import "./login.css"
function Login() {
  return (
    <div className='loginPage'>
        <div className='loginBox'>
            <div className='loginBoxTitle'>Login</div>
            <div className='username'>Username</div>
            <input type={"text"} id="usernameText"></input>
            <div className='password'>password</div>
            <input type={"text"} id="passwordText"></input>
            <button className='submit'>submit</button>
            <div className='register'>register</div>
        </div>
    </div>
  )
}

export default Login