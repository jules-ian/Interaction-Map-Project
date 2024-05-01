import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
//import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter } from "react-router-dom";

import "./utils/i18n";
const root = ReactDOM.createRoot(document.getElementById('content'));
root.render(
  <React.StrictMode>
    <BrowserRouter>
      <App />
    </BrowserRouter>
  </React.StrictMode>
);
