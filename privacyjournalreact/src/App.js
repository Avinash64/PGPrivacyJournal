import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Login from './login/login';
import Home from './home/home';


function App() {
  return (
    <div className='page'>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Login />} />
          <Route path="home" element={<Home />} />
          {/* <Route path="contact" element={<Contact />} /> */}
          {/* <Route path="*" element={<NoPage />} /> */}
        
      </Routes>
    </BrowserRouter>
    </div>
  );
}

export default App;
