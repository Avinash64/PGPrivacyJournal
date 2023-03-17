import React, {useState} from 'react'
import "./register.css"
import { useNavigate } from "react-router-dom";
function Register() {
    const [username, setUsername] = useState("")
    const [password, setPassword] = useState("")
    const [confirmPassword, setConfirmPassword] = useState("")
    const navigate = useNavigate();
  return (
    <div className='registerPage'>
        <div className='registerBox'>
            <div className='registerBoxTitle'>Register</div>
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
            
            <div className='confirmPassword'>confirm password</div>
            
            <input 
                type={"password"} 
                onChange={(e)=>{setConfirmPassword(e.target.value); console.log(e.target.value)}} 
                id="confirmPasswordText">
            </input>
            

            <div id='error'></div>
            
            <button className='submit' onClick={()=> {
                if (password == confirmPassword){
                const options = {
                    method: 'POST',
                    headers: {'Content-Type': 'application/json'},
                    body: `{"username":"${username}","password":"${password}"}`
                  };
                  
                  fetch('http://localhost:5224/api/register', options)
                    .then(response => response.json())
                    .then(response => {
                        console.log(response);
                        window.document.getElementById("error").innerHTML = response.success?"":"Username or password invalid";
                        if (response.success){
                            navigate("/home");
                        }
                        })
                    .catch(err => console.error(err));
            }}}>submit</button>
            <div className='login'
            onClick={()=> navigate("/")}
            >login</div>
        </div>
    </div>
  )
}

export default Register