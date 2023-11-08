import React from "react";
import { Link } from "react-router-dom";

export default function NavBar() {
    return (
        <nav className="p-4">
            <ul className="flex space-x-4">
                <li><Link to="/" className="text-white">Home</Link></li>
                <li><Link to="/ticket" className="text-white">Ticket</Link></li>
                <li><Link to="/agent" className="text-white" >Agent</Link></li>
                <li><Link to="/user" className="text-white" >User</Link></li>
            </ul>
      </nav>
    );
  }



