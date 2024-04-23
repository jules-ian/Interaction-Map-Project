import { useEffect } from "react";
import { Box, Button, Link } from "@mui/material";
import { useNavigate, Link as RouterLink } from "react-router-dom";
import useWindowDimensions from "../utils/windowDimension";
import { useState } from "react";
import { useTranslation } from "react-i18next";
import TextInput from "../Components/TextInput";
import PasswordInput from "../Components/PasswordInput";
import { isEmail } from "../utils/checkFunctions";
import { Text } from "../Components/Label";
import { checkIdentifiants } from "../utils/BackendFunctions";
import { ErrorDialog } from "../Components/AlertDialog";

export default function LogIn({ setMenuTitel, loggedIn, user }) {
  useEffect(() => {
    function handleKeyDown(e) {
      if (e.key === "Enter") {
        console.log("Enter key pressed");
        logInClick();
      }
    }
    document.addEventListener('keydown', handleKeyDown);
    return function cleanup() {
      document.removeEventListener('keydown', handleKeyDown);
    }
  }, []);

  const { t } = useTranslation(); //t -> alias pour useTranslation() (traduction en vers fr)
  setMenuTitel(t("page.logIn"));
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();


  const [mail, setMail] = useState("");
  const [mailError, setMailError] = useState(false);

  const [passwd, setPswd] = useState("");

  const [errorMessage, setErrorMessage] = useState("");
  const [openErrorDialog, setOpenErrorDialog] = useState(false);
  const onCloseErrorDialog = function () {
    setOpenErrorDialog(false);
  };


  const logInClick = function () {
    console.log("Connexion submitted");
    if (!isEmail(mail)) {
      setMailError(true);
    }
    checkIdentifiants(mail, passwd, (valid) => {
      if (!valid) {
        console.log("Wrong identifiants");
        setErrorMessage(t("login.wrongID"));
        setOpenErrorDialog(true);
      }
      else {
        console.log("Good identifiants");
        navigate("/Search", { replace: true });
      };
    });
  }

  const catergoryHeaderProps = {
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
    fontSize: 30,
    marginBottom: 2
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
      <ErrorDialog
        message={errorMessage}
        onClose={onCloseErrorDialog}
        open={openErrorDialog}
      />

      <Box sx={{ width: 0.55 }}>
        <Text sx={catergoryHeaderProps}>{t("login.logInDescription")}</Text>
        <TextInput
          label={t("professional.email")}
          error={mailError}
          setTextState={setMail}
          setErrorState={setMailError}
          multiline={true}
        />
        <PasswordInput
          setTextState={setPswd}
          setLabel={t("professional.password")}
          multiline={true}
        />
        <Button id="login" variant="contained" fullWidth={true} onClick={() => logInClick()} sx={{ marginTop: 2, marginBottom: 2 }}>
          {t("page.logIn")}
        </Button>
        <Box sx={{ textAlign: "center", marginBottom: 1 }}>
          <Link component={RouterLink} to="/forgotPassword" color="primary" sx={{ textDecoration: "none" }}>
            {t("login.forgotPassword")}
          </Link>
        </Box>

      </Box>
    </Box >
  );
}
