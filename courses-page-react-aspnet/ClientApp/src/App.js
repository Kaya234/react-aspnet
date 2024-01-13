import "bootstrap/dist/css/bootstrap.min.css";

import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import './custom.css';

import Navigation from "./components/Navbar/Navbar";
import Footer from "./components/Footer/Footer";

export default class App extends Component {

  render() {
    return (
      <div className="App">
            <div className="content-wrap">
                <Navigation />
        <Routes>
          {AppRoutes.map((route, index) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })}
        </Routes>
        </div>
        <Footer />
      </div>
    );
  }
}
