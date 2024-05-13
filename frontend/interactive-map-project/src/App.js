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
import InitPassword from "./Pages/InitPassword";
import { Box, IconButton, MenuItem, Select, Button, Toolbar } from "@mui/material";
import AppBar from "@mui/material/AppBar";
import ToolbarGroup from "@mui/material/Toolbar";
import HomeIcon from "@mui/icons-material/Home";
import MapIcon from '@mui/icons-material/Map';
import LogoutIcon from '@mui/icons-material/Logout';

import useWindowDimensions from "./utils/windowDimension";
import { Header } from "./Components/Label";
import { PopUpDialog } from "./Components/AlertDialog";

export var tokenUser = null;
export function setTokenUser(tok) {
  tokenUser = tok;
}
export default function App() {
  const defaultRoute = "Home";
  const location = useLocation();
  const { t, i18n } = useTranslation();
  const navigate = useNavigate();

  const [menuTitel, setMenuTitel] = useState("");
  const { width, height } = useWindowDimensions();
  const testStyle = { margin: 0 };
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

  // Bouton Profil n'est présent dans la barre de menu que sur la page Search
  const renderMonCompteButton = () => {
    if (location.pathname === "/Search") {
      return (
        <Button
          component={RouterLink}
          to="/Profil"
          variant="outlined"
          sx={{ borderRadius: "3px", backgroundColor: "white", marginRight: 2 }}
        >
          {t("common.myAccount")}
        </Button>
      );
    }
  };

  // Bouton Home affiché seulement sur les pages où l'utilisateur est connecté
  const renderHomeButton = () => {
    if ((location.pathname === "/Search") || (location.pathname === "/Profil") || (location.pathname === "/Admin") || (location.pathname === "/EditProfil") || (location.pathname === "/EditPassword")) {
      return (
        <IconButton
          sx={{ backgroundColor: "white", marginRight: 2 }}
          onClick={onHomeClick}
          title={t("pages.search")}
        >
          <HomeIcon />
        </IconButton>
      );
    }
  }

  // Affiche le bouton (icone) pour qu'un admin accède à la page de recherche (seulement sur la page Admin)
  const renderSearchButton = () => {
    if ((location.pathname === "/Admin")) {
      return (
        <IconButton
          sx={{ backgroundColor: "white", marginRight: 2 }}
          onClick={onHomeClick}
          title={t("common.returnHome")}
        >
          <MapIcon />
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

  return (

    <Box sx={{ flexGrow: 1 }}>
      <PopUpDialog
        onClose={onClosePopUpDialog}
        open={openPopUpDialog}
      />
      <AppBar position="sticky" sx={{ backgroundColor: "#3EBBCD" }}>
        <Toolbar sx={{ justifyContent: "space-between" }}>
          <ToolbarGroup firstchild={true} float="left" >
            {renderHomeButton()}

            <a href="https://accueilpourtous31.fr/">
              <Button sx={{ backgroundColor: "white" }} variant="outlined" startIcon={<img src="https://accueilpourtous31.fr/favicon-32x32.png" />} title={t("common.returnAPT")}>
                {t("common.buttonAPT")}
              </Button>
            </a>
          </ToolbarGroup>

          <ToolbarGroup sx={{
            left: "50%", transform: "translateX(-50%);", position: "absolute"
          }}>
            <Header> {menuTitel}</Header>
          </ToolbarGroup>

          <ToolbarGroup lastchild={true} float="right">
            {renderMonCompteButton()}
            {renderSearchButton()}
            <Select
              variant="standard"
              sx={{ backgroundColor: "white", padding: 0.5, borderRadius: 1, justifyContent: "right" }}
              value={currentLanguage}
              onChange={function (event) {
                onChangeLanguage(event.target.value);
              }}
              label="Langage"
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
        <Route path="Search" element={<Search setMenuTitel={setMenuTitel} />} />
        <Route path="Admin" element={<Admin setMenuTitel={setMenuTitel} />} />
        <Route path="Profil" element={<Profil setMenuTitel={setMenuTitel} />} />
        <Route path="EditProfil" element={<EditProfil setMenuTitel={setMenuTitel} />} />
        <Route path="initPassword" element={<InitPassword setMenuTitel={setMenuTitel} />} />

      </Routes>

    </Box >
  );
}
