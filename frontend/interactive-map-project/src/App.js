import "./App.css";
import Form from "./Pages/Form";
import Search from "./Pages/Search";
import Home from "./Pages/Home";
import Test from "./Pages/Test";
import { Routes, Route, Navigate } from "react-router-dom";
import Admin from "./Pages/Admin";
import FormSuccess from "./Pages/FormSuccess";
export default function App() {
  const testStyle = {
    margin: 2,
  };
  const defaultRoute = "Home";
  return (
    <div className="App" style={testStyle}>
      <Routes>
        <Route path="/" element={<Navigate to={defaultRoute} />} />
        <Route path="Form" element={<Form />} />
        <Route path="FormSuccess" element={<FormSuccess />} />
        <Route path="Search" element={<Search />} />
        <Route path="Home" element={<Home />} />
        <Route path="Admin" element={<Admin />} />
        <Route path="Test" element={<Test />} />
      </Routes>
    </div>
  );
}
