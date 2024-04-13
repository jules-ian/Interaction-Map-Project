import { useCallback } from "react";
import { Box, Grid, Button, Link } from "@mui/material";
import { useNavigate, Link as RouterLink } from "react-router-dom";
import useWindowDimensions from "../utils/windowDimension";
import { useState } from "react";
import { useTranslation } from "react-i18next";
import TextInput from "../Components/TextInput";
import PasswordInput from "../Components/PasswordInput";
import { isEmail } from "../utils/checkFunctions";
import { Text } from "../Components/Label";


export default function LogIn({ setMenuTitel }) {
  const { t } = useTranslation(); //t -> alias pour useTranslation() (traduction en vers fr)
  setMenuTitel(t("page.logIn"));
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();


  const [mail, setMail] = useState("");

  const [mailError, setMailError] = useState(false);

  const [passwd, setPswd] = useState("");

  const [description, setDescription] = useState("");
  const [descriptionError, setDescriptionError] = useState(false);
  const [accept, setAccept] = useState(false);
  const [acceptError, setAcceptError] = useState(false);

  const [errorMessage, setErrorMessage] = useState("");
  const [openErrorDialog, setOpenErrorDialog] = useState(false);

  const onSubmit = function () {
    console.log("Form submitted");
    let valid = checkEntries();
    if (!valid) { //A détailler, plusieurs types d'erreurs possibles
      setErrorMessage(t("login.errorMessageFE"));
      setOpenErrorDialog(true);
      return;
    }
    if (valid) {
      navigate("/Search", { replace: true });
    };
  }

  const checkEntries = function () { //todo : différencier les types de forms invalides
    let checkSuccess = true;
    // Mail
    if (!isEmail(mail)) {
      setMailError(true);
      checkSuccess = false;
    }
  }

  const catergoryHeaderProps = {
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
    fontSize: 35,
    marginBottom: 3
  };

  const handleKeyDown = (event) => {
    if (event.key === "Enter") {
      console.log("Enter key pressed");
      onSubmit();
    }
  };

  return (
    <Box
      sx={{
        height: height * 0.9,
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
      }}
    >
      <Box sx={{ width: 0.55 }}>
        <Text sx={catergoryHeaderProps}>{t("login.logInDescription")}</Text>
        <TextInput
          label={t("professional.email")}
          setTextState={setMail}
          multiline={true}
          onKeyDown={handleKeyDown}
        />
        <PasswordInput
          setTextState={setPswd}
          multiline={true}
          onKeyDown={handleKeyDown}
        />
        <Button variant="contained" fullWidth={true} onClick={onSubmit} sx={{ marginTop: 2, marginBottom: 2 }}>
          {t("page.logIn")}
        </Button>
        <Box sx={{ textAlign: "center", marginBottom: 1 }}>
          <Link component={RouterLink} to="/forgotPassword" color="primary" sx={{ textDecoration: "none" }}>
            {t("login.forgotPassword")}
          </Link>
        </Box>
        {/* 
        todo : vérifier que les identifiants sont corrects
        faire on Submit dans onClick qui vérifie password puis navigate vers carte
        */}
      </Box>
    </Box >
  );
}
