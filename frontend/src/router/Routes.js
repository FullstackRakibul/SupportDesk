import React from "react";
import { Route, Switch } from "react-router-dom";

// All Container start from here .........

import Home from "../containers/Home";
import Ticket from "../containers/Ticket";
import User from "../containers/User";
import Agent from "../containers/Agent";



const routes = (
  <Switch>
    <Route
      exact
      path="/"
      component={Home}
    />
    <Route
      path="/ticket"
      component={<Ticket />}
    />
    <Route
      path="/agent"
      component={Agent}
    />
    <Route
      path="/user"
      component={User}
    />
  </Switch>
);

export default routes;
