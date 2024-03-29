import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Login from './login/login';
import Home from './home/home';
import Register from './register/register';
import JournalEntry from './journalEntry/journalEntry';
import Journals from './journals/journals';


function App() {
  return (
    <div className='page'>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Login />} />
          <Route path="home" element={<Home />} />
          <Route path="register" element={<Register />} />
          <Route path="journalentry" element={<JournalEntry />} />
          <Route path="journals" element={<Journals />} />
        
      </Routes>
    </BrowserRouter>
    </div>
  );
}

export default App;
