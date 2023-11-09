// import required files 
import { Switch } from 'react-router-dom';
// import style files ..........
import './App.css';


// components starts from here ...............
import Ticket from './containers/Ticket';
import Login from './containers/Login';
import Header from './containers/Header';
import Footer from './containers/Footer';

// service files starts from here ...............


function App() {
  return (
    <div className="App">
      <Header/>
      <Login/>
      <Footer/>
    </div>
  );
}

export default App;
