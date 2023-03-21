import React from 'react'
import "./journalEntry.css"
const openpgp = require("openpgp")
function JournalEntry() {

    const generateKeyPair = async () => {
        const { publicKey, privateKey } = await openpgp.generateKey({
            curve: 'ed25519',
            userIDs: [
                {
                    name: 'Jon Smith', email: 'jon@example.com',
                    comment: 'This key is for public sharing'
                }
            ],
            passphrase: 'super long and hard to guess secret'
        });

        console.log(publicKey);
        console.log(privateKey)
        return {    
        publicKey : publicKey,
        privateKey: privateKey
    }
    }
    

    var save = async () => {
        var  privateKey = await generateKeyPair();
        console.log(privateKey)
        const privateKeyWindow = window.document.getElementById("privateKey")
        console.log(privateKey)
        console.log(privateKey)
        privateKeyWindow.value = privateKey.privateKey;
    }

    return (
        <div className='journalEntryPage'>
            {/* <h1>JournalEntry</h1> */}
            <div className='heading'>
                <div>Title:</div>
                <input className='head journalTitle'></input>
                <div>Date:</div>
                <input className='head journalDate' type={"date"}></input>
            </div>
            <textarea className='journalEntry'></textarea>
            <button onClick={ () =>  save()}>Save</button>
            <div className='prk'>
                <textarea id='privateKey'></textarea>
            </div>
        </div>
    )
}

export default JournalEntry