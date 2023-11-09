import { BrowserRouter } from 'react-router-dom';
import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';      
import Header from './containers/Header';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <BrowserRouter>
      <Header/>
      <App/>
  </BrowserRouter>,document.getElementById("root")
  
);


