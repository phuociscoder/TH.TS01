import React from 'react';
import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Login from './component/login';

function App() {
  return (
   <BrowserRouter>
   <Routes>
    <Route path='login' Component={Login} />
   </Routes>
   </BrowserRouter>
  );
}

export default App;



