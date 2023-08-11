import React from 'react';
import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Login from './component/login';
import TimeSheet from './component/timesheet';
import Layout from './component/layout';
import Dashboard from './component/dashboard';

function App() {
  return (
   <BrowserRouter>
   <Routes>
    <Route path='/' element ={<Layout/>}>
      <Route index  element={<Dashboard/>}/>

    </Route>
    <Route path='login' Component={Login} />
   </Routes>
   </BrowserRouter>
  );
}

export default App;



