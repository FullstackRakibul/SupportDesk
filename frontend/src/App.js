// import required files 
import { BrowserRouter, Outlet, Route, Router, Switch } from "react-router-dom";
// import style files ..........
import "./App.css";

// components starts from here ...............
import Ticket from "./containers/Ticket";
import Login from "./containers/Login";
import Header from "./containers/Header";
import Footer from "./containers/Footer";

// service files starts from here ...............

function App() {
  return (
    <div className="App">
      <Header />
      <Ticket />
      <Footer />
    </div>
  );
}

export default App;
