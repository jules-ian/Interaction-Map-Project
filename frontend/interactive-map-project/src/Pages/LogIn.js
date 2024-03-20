
import { Box, Grid, Button } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect, useState } from "react";
import { useTranslation } from "react-i18next";
import TextInput from "../Components/TextInput";
import { isEmail } from "../utils/checkFunctions";
import { Text, Header } from "../Components/Label";

export default function LogIn({ setMenuTitel }) {
  const { t } = useTranslation(); //constante t -> alias pour useTranslation() (traduction de l'anglais vers le français)
  setMenuTitel(t("page.logIn"));
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();

  const [mail, setMail] = useState("");
  const [mailError, setMailError] = useState(false);


  const [description, setDescription] = useState("");
  const [descriptionError, setDescriptionError] = useState(false);
  const [accept, setAccept] = useState(false);
  const [acceptError, setAcceptError] = useState(false);

  const [errorMessage, setErrorMessage] = useState("");
  const [openErrorDialog, setOpenErrorDialog] = useState(false);

  const onSubmit = function () {
    let valid = checkEntries();
    if (!valid) { //A détailler, plusieurs types d'erreurs possibles
      setErrorMessage(t("form.errorMessageFE"));
      setOpenErrorDialog(true);
      return;
    }
    if (valid) { //todo : ajouter le navigate 
      navigate("/Search", { replace: true });
    }
  };

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
          multiline={true}
        />
        <TextInput
          label={t("professional.password")}
          multiline={true}
        />
        <Button variant="contained" fullWidth={true} onClick={() => navigate("/Search", { replace: true })} sx={{ marginTop: 2 }}>
          {t("page.logIn")}
        </Button>

        {/* 
        todo : vérifier que les identifiants sont corrects
        faire on Submit dans onClick qui vérifie password puis navigate vers carte
        */}
      </Box>
    </Box>
  );
}
