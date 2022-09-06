import React from 'react'
import ReactDOM from 'react-dom/client'
import { BrowserRouter } from 'react-router-dom';

import { TinyPockerApp } from './TinyPockerApp'
import './index.css'

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <BrowserRouter>
      <TinyPockerApp />
    </BrowserRouter>
  </React.StrictMode>
)
