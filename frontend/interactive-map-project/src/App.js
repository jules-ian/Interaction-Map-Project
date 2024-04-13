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
import { Box, FormControl, IconButton, MenuItem, Select, Button, Toolbar, Typography } from "@mui/material";
import AppBar from "@mui/material/AppBar";
import ToolbarGroup from "@mui/material/Toolbar";
import { useState } from "react";
import useWindowDimensions from "./utils/windowDimension";
import { Header } from "./Components/Label";
import HomeIcon from "@mui/icons-material/Home";
import LogoutIcon from '@mui/icons-material/Logout';
import ArrowBackIcon from "@mui/icons-material/ArrowBack";
import DropMultiSelect from "./Components/DropMultiSelect";
import { useTranslation } from "react-i18next";
import { PopUpDialog } from "./Components/AlertDialog";


export default function App() {
  const defaultRoute = "Home";
  const location = useLocation();
  const { t, i18n } = useTranslation();
  const navigate = useNavigate();

  const [menuTitel, setMenuTitel] = useState("");
  const { width, height } = useWindowDimensions();
  const testStyle = {
    margin: 0,
  };
  const [currentLanguage, setCurrentLanguage] = useState("fr");


  const onHomeClick = function () {
    console.log("Back to Homepage");
    navigate("/Search", { replace: true });
  };
  //déconnecter l'utilisateur ici
  const onLogOutClick = function () {
    console.log("Disconnection");


  };

  const onChangeLanguage = function (languageString) {
    setCurrentLanguage(languageString);
    i18n.changeLanguage(languageString);
  };

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

    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="sticky" sx={{ backgroundColor: 'lightblue' }}>
        <Toolbar sx={{ justifyContent: "space-between" }}>
          <ToolbarGroup firstChild={true} float="left" >
            <IconButton
              sx={{ backgroundColor: "white", marginRight: 2 }}
              onClick={onHomeClick}
              title={t("common.returnHome")}
            >
              <HomeIcon />
            </IconButton>

            <IconButton
              sx={{ backgroundColor: "white", marginRight: 2 }}
              onClick={onLogOutClick}
              title={t("common.disconnection")}
            >
              <LogoutIcon />
            </IconButton >

            <a href="https://accueilpourtous31.fr/">
              <Button sx={{ backgroundColor: "white" }} startIcon={<img src="https://accueilpourtous31.fr/favicon-32x32.png" />} title={t("common.returnAPT")}>
                Retour à APT31
              </Button>
            </a>
          </ToolbarGroup>

          <ToolbarGroup sx={{
            left: "50%", transform: "translateX(-50%);", position: "absolute"
          }}>
            < Header > {menuTitel}</Header>
          </ToolbarGroup>

          <ToolbarGroup lastChild={true} float="right">
            {renderMonCompteButton()}
            {renderEditProfileButton()}
            <Select
              variant="standard"
              sx={{ marginLeft: 2, backgroundColor: "white", padding: 0.5, borderRadius: 1, justifyContent: "right" }}
              value={currentLanguage}
              onChange={function (event) {
                onChangeLanguage(event.target.value);
              }}
              label="Language"
            >
              <MenuItem value="en">en</MenuItem>
              <MenuItem value="fr">fr</MenuItem>
            </Select>
          </ToolbarGroup>


        </Toolbar >
      </AppBar >

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

    </Box >
  );
}
