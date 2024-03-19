
import { Box } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect, useState } from "react";
import { useTranslation } from "react-i18next";
import TextInput from "../Components/TextInput";
import {isEmail} from "../utils/checkFunctions";
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



  return (
    
    <Box
      sx={{
        height: height * 0.5,
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
      }}
    >
      <Box sx={{ padding: 5 }}>
        <Header>{t("form.header")}</Header>
        <Text>{t("form.descriptionOfForm")}</Text>
      </Box>
      <Box sx={{ width: 0.3 }}>
      <TextInput
            error={descriptionError}
            setTextState={setDescription}
            setErrorState={setDescriptionError}
            label={t("professional.email")}
            multiline={true}
          />
          <TextInput
            error={descriptionError}
            setTextState={setDescription}
            setErrorState={setDescriptionError}
            label={t("professional.password")}
            multiline={true}
          />
        <ButtonComponent
          label={t("page.logIn")}
          onClick={onSubmit} //todo : vérifier que les identifiants sont corrects
        />
        
       
      </Box> 
    </Box>
  );
}
