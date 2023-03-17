import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Login from './login/login';
import Home from './home/home';
import Register from './register/register';


function App() {
  return (
    <div className='page'>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Login />} />
          <Route path="home" element={<Home />} />
          <Route path="register" element={<Register />} />
          {/* <Route path="*" element={<NoPage />} /> */}
        
      </Routes>
    </BrowserRouter>
    </div>
  );
}

export default App;
