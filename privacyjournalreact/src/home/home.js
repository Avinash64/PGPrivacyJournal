import React, {useState, useEffect} from 'react'
import "./home.css"
function Home() {
  const [data, setData] = useState({})
  const datas = async() =>{
    const options = {
        method: 'GET',
        headers: {'Content-Type': 'application/json'}
      };
      
      fetch('http://localhost:5224/api/profile/', options)
        .then(response => response.json())
        .then(response => setData(response))
        .catch(err => console.error(err));
  }
  useEffect(() => {


    datas()
  

  }, [])
  
  return (
    <div className='homePage'>{JSON.stringify(data)}</div>
  )
}

export default Home