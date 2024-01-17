import "./App.css";
import Form from "./Pages/Form";
import Search from "./Pages/Search";
import Home from "./Pages/Home";
import Test from "./Pages/Test";
import { Routes, Route, Navigate, useNavigate } from "react-router-dom";
import Admin from "./Pages/Admin";
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
import { useTranslation } from "react-i18next";
export default function App() {
  const defaultRoute = "Home";
  const { t, i18n } = useTranslation();
  const navigate = useNavigate();

  const [menuTitel, setMenuTitel] = useState("");
  const { width, height } = useWindowDimensions();
  const testStyle = {
    margin: 2,
  };
  const [currentLanguage, setCurrentLanguage] = useState("fr");
  const onBackButtonClick = function () {
    console.log("blub");
    navigate("/Home", { replace: true });
  };
  const onChangeLanguage = function (languageString) {
    setCurrentLanguage(languageString);
    i18n.changeLanguage(languageString);
  };
  return (
    <Box style={testStyle}>
      <Paper
        elevation={3}
        sx={{
          backgroundColor: "lightblue",
          minHeight: height * 0.07,
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

        <Select
          variant="standard"
          sx={{ backgroundColor: "white", padding: 0.5, borderRadius: 1 }}
          value={currentLanguage}
          onChange={function (event) {
            onChangeLanguage(event.target.value);
          }}
          label="Language"
        >
          <MenuItem value="en">en</MenuItem>
          <MenuItem value="fr">fr</MenuItem>
        </Select>
      </Paper>
      <Routes>
        <Route path="/" element={<Navigate to={defaultRoute} />} />
        <Route path="Form" element={<Form setMenuTitel={setMenuTitel} />} />
        <Route path="Search" element={<Search setMenuTitel={setMenuTitel} />} />
        <Route path="Home" element={<Home setMenuTitel={setMenuTitel} />} />
        <Route path="Admin" element={<Admin setMenuTitel={setMenuTitel} />} />
        <Route path="Test" element={<Test setMenuTitel={setMenuTitel} />} />
      </Routes>
    </Box>
  );
}
