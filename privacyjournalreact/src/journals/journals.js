import React, {useState, useEffect} from 'react'
import "./journals.css"
function Journals() {
  const [journalList, setJournalList] = useState([]);
  useEffect(() => {
    const options = {
        method: 'GET',
        headers: {'Content-Type': 'application/json'},
      };
      
      fetch('http://localhost:5224/api/journal/', options)
        .then(response => response.json())
        .then(response => {console.log(response);
                           setJournalList(response)
        })
        .catch(err => console.error(err));
  }, [])
  
  return (
    <div className='journals'>
        {/* {JSON.stringify(journalList)} */}
        {journalList.map(e => {
            return (
            <div>
            {e.title}
                {/* {Date.parse(e.date)} */}
                {e.entry}
            </div>)
        })}
    </div>
  )
}

export default Journals