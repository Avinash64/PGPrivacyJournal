import React, {useState} from 'react'
import "./login.css"
import { useNavigate } from "react-router-dom";
function Login() {
    const [username, setUsername] = useState("")
    const [password, setPassword] = useState("")
    const navigate = useNavigate();
  return (
    <div className='loginPage'>
        <div className='loginBox'>
            <div className='loginBoxTitle'>Login</div>
            <div className='username'>Username</div>
            <input type={"text"} 
                id="usernameText"
                onChange={(e)=>{setUsername(e.target.value); console.log(e.target.value)}} 
                >
            </input>
            <div className='password'>password</div>
            
            <input 
                type={"password"} 
                onChange={(e)=>{setPassword(e.target.value); console.log(e.target.value)}} 
                id="passwordText">
            </input>
            
            <div id='error'></div>
            
            <button className='submit' onClick={()=> {
                const options = {
                    method: 'POST',
                    headers: {'Content-Type': 'application/json'},
                    body: `{"username":"${username}","password":"${password}"}`
                  };
                  
                  fetch('http://localhost:5224/api/login', options)
                    .then(response => response.json())
                    .then(response => {
                        console.log(response);
                        window.document.getElementById("error").innerHTML = response.success?"":"Username or password invalid";
                        if (response.success){
                            navigate("/home");
                        }
                        })
                    .catch(err => console.error(err));
            }}>submit</button>
            <div className='register'>register</div>
        </div>
    </div>
  )
}

export default Login