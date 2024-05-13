
import { Box, Button } from "@mui/material";
import { useNavigate } from "react-router-dom";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect, useState } from "react";
import { useTranslation } from "react-i18next";
import TextInput from "../Components/TextInput";
import { isEmail } from "../utils/checkFunctions";
import { Text } from "../Components/Label";
import { getToken } from "../utils/BackendFunctions";
import { tokenUser } from "../App";

export default function ForgotPassword({ setMenuTitel }) {
    useEffect(() => {
        function handleKeyDown(e) {
            if (e.key === "Enter") {
                console.log("Enter key pressed");
                onSubmit();
            }
        }
        document.addEventListener('keydown', handleKeyDown);
        return function cleanup() {
            document.removeEventListener('keydown', handleKeyDown);
        }
    }, []);


    const { t } = useTranslation(); //constante t -> alias pour useTranslation() (traduction de l'anglais vers le français)
    setMenuTitel(t("forgotpw.titlepw"));
    const navigate = useNavigate();
    const { height } = useWindowDimensions();

    const [mail, setMail] = useState("");
    const [mailError, setMailError] = useState(false);

    /*Le lien avec le backend (envoi automatique de mail) n'est pas fait */
    const onSubmit = function () {
        /*let valid = checkEntries();
        if (!valid) { //A détailler, plusieurs types d'erreurs possibles
            setErrorMessage(t("form.errorMessageFE"));
            setOpenErrorDialog(true);
            return;
        }
        if (valid) { //envoyer un mail de renouvellement de mot de passe
            pop up confirmation email*/
        navigate("/LogIn", { replace: true });
        //}
    };

    const checkEntries = function () {
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

    const catergorySubheaderProps = {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        fontSize: 20,
        marginBottom: 3
    };

    const tok = getToken(tokenUser);
    let tokRole = "Null";
    if (tok != null) {
        tokRole = tok.token;
    }

    if (tokRole === "Professional" | tokRole === "Admin") {
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
                    <Text sx={catergoryHeaderProps}>{t("forgotpw.headerForgotPassword")}</Text>
                    <Text sx={catergorySubheaderProps}>{t("forgotpw.subheaderForgotPassword")}</Text>
                    <TextInput
                        label={t("professional.email")}
                        setTextState={setMail}
                        type="email"
                        multiline={false}
                    />
                    <Button variant="contained" fullWidth={true} onClick={onSubmit} sx={{ marginTop: 2, marginBottom: 2 }}>
                        {t("common.valid")}
                    </Button>

                </Box>
            </Box>
        );
    } else {
        navigate("/LogIn", { replace: true });
    }
}
