// import { createBrowserRouter } from "react-router-dom";
// import { createBrowserRouter } from "react-router-dom";
// import routes from "./Routes";
// const router = createBrowserRouter(routes);

// export default router;


import { BrowserRouter } from "react-router-dom";
import routes from "./Routes";

const router = (
  <BrowserRouter>
    {routes}
  </BrowserRouter>
);

export default router;
