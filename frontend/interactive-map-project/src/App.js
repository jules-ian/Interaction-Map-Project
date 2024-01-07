import "./App.css";
import Form from "./Pages/Form";
import Search from "./Pages/Search";
import Home from "./Pages/Home";
import Test from "./Pages/Test";
import { Routes, Route, Navigate, useNavigate } from "react-router-dom";
import Admin from "./Pages/Admin";
import FormSuccess from "./Pages/FormSuccess";
import {
  Box,
  FormControl,
  IconButton,
  MenuItem,
  Paper,
  Select,
} from "@mui/material";
import { useState } from "react";
import useWindowDimensions from "./utils/windowDimension";
import { Header } from "./Components/Label";
import HomeIcon from "@mui/icons-material/Home";
import DropMultiSelect from "./Components/DropMultiSelect";
export default function App() {
  const defaultRoute = "Home";
  const navigate = useNavigate();

  const [menuTitel, setMenuTitel] = useState("");
  const { width, height } = useWindowDimensions();
  const testStyle = {
    margin: 2,
  };
  const onBackButtonClick = function () {
    console.log("blub");
    navigate("/Home", { replace: true });
  };
  const onChangeLanguage = function () {};
  return (
    <Box style={testStyle}>
      <Paper
        elevation={3}
        sx={{
          backgroundColor: "lightblue",
          minHeight: width * 0.075,
          alignItems: "center",
          justifyContent: "space-between",
          color: "lightblack",
          display: "flex",
          paddingX: 5,
        }}
      >
        <IconButton
          sx={{ backgroundColor: "white" }}
          onClick={onBackButtonClick}
        >
          <HomeIcon />
        </IconButton>
        <Header>{menuTitel}</Header>

        <FormControl
          variant="standard"
          sx={{ backgroundColor: "white", padding: 0.4, borderRadius: 1 }}
        >
          <Select value={"en"} onChange={onChangeLanguage} label="Language">
            <MenuItem value="en">en</MenuItem>
            <MenuItem value="fr">fr</MenuItem>
          </Select>
        </FormControl>
      </Paper>
      <Routes>
        <Route path="/" element={<Navigate to={defaultRoute} />} />
        <Route path="Form" element={<Form setMenuTitel={setMenuTitel} />} />
        <Route
          path="FormSuccess"
          element={<FormSuccess setMenuTitel={setMenuTitel} />}
        />
        <Route path="Search" element={<Search setMenuTitel={setMenuTitel} />} />
        <Route path="Home" element={<Home setMenuTitel={setMenuTitel} />} />
        <Route path="Admin" element={<Admin setMenuTitel={setMenuTitel} />} />
        <Route path="Test" element={<Test setMenuTitel={setMenuTitel} />} />
      </Routes>
    </Box>
  );
}
