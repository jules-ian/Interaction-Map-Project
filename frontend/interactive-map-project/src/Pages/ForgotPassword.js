
import { Box, Grid, Button, Link } from "@mui/material";
import { Navigate, useNavigate, Link as RouterLink } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect, useState } from "react";
import { useTranslation } from "react-i18next";
import TextInput from "../Components/TextInput";
import { isEmail } from "../utils/checkFunctions";
import { Text, Header } from "../Components/Label";

export default function ForgotPassword({ setMenuTitel }) {
    const { t } = useTranslation(); //constante t -> alias pour useTranslation() (traduction de l'anglais vers le français)
    setMenuTitel(t("forgotpw.titlepw"));
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
        if (valid) { //todo : envoyer un mail de renouvellement de mot de passe

        }
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
                    multiline={true}
                />
                <Button variant="contained" fullWidth={true} onClick={onSubmit} sx={{ marginTop: 2, marginBottom: 2 }}>
                    {t("common.valid")}
                </Button>

            </Box>
        </Box>
    );
}
