import "./App.css";
import { useState } from "react";
import { useTranslation } from "react-i18next";
import { Routes, Route, Navigate, useNavigate, Link as RouterLink, useLocation } from "react-router-dom";

import Form from "./Pages/Form";
import Search from "./Pages/Search";
import Home from "./Pages/Home";
import LogIn from "./Pages/LogIn";
import ForgotPassword from "./Pages/ForgotPassword";
import Profil from "./Pages/Profil";
import EditProfil from "./Pages/EditProfil";
import Admin from "./Pages/Admin";
import EditPassword from "./Pages/EditPassword";

import { Box, FormControl, IconButton, MenuItem, Select, Button, Toolbar, Typography } from "@mui/material";
import AppBar from "@mui/material/AppBar";
import ToolbarGroup from "@mui/material/Toolbar";
import HomeIcon from "@mui/icons-material/Home";
import LogoutIcon from '@mui/icons-material/Logout';
import ArrowBackIcon from "@mui/icons-material/ArrowBack";

import useWindowDimensions from "./utils/windowDimension";
import { isAdmin } from "./utils/BackendFunctions";
import { Header } from "./Components/Label";
import DropMultiSelect from "./Components/DropMultiSelect";
import { PopUpDialog } from "./Components/AlertDialog";
import GuardedRoute from "./Components/GuardedRoute";

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


  const [openPopUpDialog, setOpenPopUpDialog] = useState(false);
  const onClosePopUpDialog = function () {
    setOpenPopUpDialog(false);
  };

  const onHomeClick = function () {
    navigate("/Search", { replace: true });
  };

  //déconnecter l'utilisateur ici
  const onLogOutClick = function () {
    setOpenPopUpDialog(true);
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

  const renderHomeButton = () => {
    if ((location.pathname === "/Search") || (location.pathname === "/Profil") || (location.pathname === "/Admin") || (location.pathname === "/EditProfil") || (location.pathname === "/EditPassword")) {
      return (
        <IconButton
          sx={{ backgroundColor: "white", marginRight: 2 }}
          onClick={onHomeClick}
          title={t("common.returnHome")}
        >
          <HomeIcon />
        </IconButton>
      );
    }
  }

  const renderLogOutButton = () => {
    if ((location.pathname === "/Search") || (location.pathname === "/Profil") || (location.pathname === "/Admin") || (location.pathname === "/EditProfil") || (location.pathname === "/EditPassword")) {
      return (
        <IconButton
          sx={{ backgroundColor: "white", marginLeft: 2 }}
          onClick={onLogOutClick}
          title={t("common.disconnection")}
        >
          <LogoutIcon />
        </IconButton >
      );
    }
  }

  const [loggedIn, setIsLoggedIn] = useState(false);
  const [user, setUser] = useState("");

  const isAuthenticated = () => {
    return loggedIn;
  }
  const loggedAdmin = () => {
    return true;
    //TODO : return isAdmin(user);
  }

  return (

    <Box sx={{ flexGrow: 1 }}>
      <PopUpDialog
        onClose={onClosePopUpDialog}
        open={openPopUpDialog}
      />
      <AppBar position="sticky" sx={{ backgroundColor: '#5DD3E4' }}>
        <Toolbar sx={{ justifyContent: "space-between" }}>
          <ToolbarGroup firstChild={true} float="left" >
            {renderHomeButton()}

            <a href="https://accueilpourtous31.fr/">
              <Button sx={{ backgroundColor: "white", color: "primary" }} startIcon={<img src="https://accueilpourtous31.fr/favicon-32x32.png" />} title={t("common.returnAPT")}>
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
            {renderLogOutButton()}
          </ToolbarGroup>


        </Toolbar >
      </AppBar >

      <Routes>
        <Route path="/" element={<Navigate to={defaultRoute} />} />
        <Route path="Form" element={<Form setMenuTitel={setMenuTitel} />} />
        <Route path="Home" element={<Home setMenuTitel={setMenuTitel} />} />
        <Route path="LogIn" element={<LogIn setMenuTitel={setMenuTitel} loggedIn={setIsLoggedIn} user={setUser} />} />
        <Route path="ForgotPassword" element={<ForgotPassword setMenuTitel={setMenuTitel} />} />
        <Route path="EditPassword" element={<EditPassword setMenuTitel={setMenuTitel} />} />

        {/*Routes Gardées*/}
        <Route path="Search" element={<Search setMenuTitel={setMenuTitel} />} />
        <Route path="Admin" element={<Admin setMenuTitel={setMenuTitel} />} />
        <Route path="Profil" element={<Profil setMenuTitel={setMenuTitel} />} />
        <Route path="EditProfil" element={<EditProfil setMenuTitel={setMenuTitel} />} />
        {/*
        <GuardedRoute path="Admin" element={<Admin setMenuTitel={setMenuTitel} />} hasAccess={loggedAdmin} />
        <GuardedRoute path="Profil" element={<Profil setMenuTitel={setMenuTitel} />} hasAccess={isAuthenticated} />
        <GuardedRoute path="EditProfil" element={<EditProfil setMenuTitel={setMenuTitel} />} hasAccess={isAuthenticated} />
        */}
      </Routes>

    </Box >
  );
}
