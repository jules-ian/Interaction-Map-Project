import "./App.css";
import Form from "./Pages/Form";
import Search from "./Pages/Search";
import Home from "./Pages/Home";
import Test from "./Pages/Test";
import LogIn from "./Pages/LogIn";
import ForgotPassword from "./Pages/ForgotPassword";
import Profil from "./Pages/Profil";
import EditProfil from "./Pages/EditProfil";
import { Routes, Route, Navigate, useNavigate, Link as RouterLink, useLocation } from "react-router-dom";
import Admin from "./Pages/Admin";
import { Box, FormControl, IconButton, MenuItem, Paper, Select, Button } from "@mui/material";
import { useState } from "react";
import useWindowDimensions from "./utils/windowDimension";
import { Header } from "./Components/Label";
import HomeIcon from "@mui/icons-material/Home";
import DropMultiSelect from "./Components/DropMultiSelect";
import { useTranslation } from "react-i18next";


export default function App() {
  const defaultRoute = "Home";
  const location = useLocation();
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

  // Fonction pour rendre le bouton "Mon compte" uniquement sur la page de recherche
  const renderMonCompteButton = () => {
    if (location.pathname === "/Search") {
      return (
        <Button
          component={RouterLink}
          to="/Profil"
          variant="contained"
          sx={{ borderRadius: "20px" }}
        >
          {t("common.myAccount")}
        </Button>
      );
    }
  };

  const renderEditProfileButton = () => {
    if (location.pathname === "/Profil") {
      return (
        <Button
          component={RouterLink}
          to="/EditProfil"
          variant="contained"
          sx={{ borderRadius: "20px" }}
        >
          {t("profil.edit")}
        </Button>
      );
    }
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
        <Header >{menuTitel}</Header>

        {renderMonCompteButton()}
        {renderEditProfileButton()}

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
        <Route path="LogIn" element={<LogIn setMenuTitel={setMenuTitel} />} />
        <Route path="ForgotPassword" element={<ForgotPassword setMenuTitel={setMenuTitel} />} />
        <Route path="Profil" element={<Profil setMenuTitel={setMenuTitel} />} />
        <Route path="EditProfil" element={<EditProfil setMenuTitel={setMenuTitel} />} />
      </Routes>
    </Box>
  );
}
