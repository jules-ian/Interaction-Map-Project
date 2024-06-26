import { useEffect } from "react";
import { Box, Button } from "@mui/material";
import { useNavigate } from "react-router-dom";
import useWindowDimensions from "../utils/windowDimension";
import { useState } from "react";
import { useTranslation } from "react-i18next";
import PasswordInput from "../Components/PasswordInput";
import { Text } from "../Components/Label";
import { isName } from "../utils/checkFunctions";
import { getToken } from "../utils/BackendFunctions";
import { tokenUser } from "../App";

export default function EditPassword({ setMenuTitel }) {
    useEffect(() => {
        function handleKeyDown(e) {
            if (e.key === "Enter") {
                console.log("Enter key pressed");
                checkUpdatePswd();
            }
        }
        document.addEventListener('keydown', handleKeyDown);
        return function cleanup() {
            document.removeEventListener('keydown', handleKeyDown);
        }
    }, []);

    const { t } = useTranslation(); //t -> alias pour useTranslation() (traduction en vers fr)
    setMenuTitel(t("editpswd.titlepage"));
    const navigate = useNavigate();
    const { height } = useWindowDimensions();

    const [errorMessage, setErrorMessage] = useState("");
    const [openErrorDialog, setOpenErrorDialog] = useState(false);
    const onCloseErrorDialog = function () {
        setOpenErrorDialog(false);
    };

    const [current, setCurrentPw] = useState("");
    const [pswdError, setPswdError] = useState(false);
    const [pswd1, setPswd1] = useState("");
    const [pswd2, setPswd2] = useState("");


    const catergoryHeaderProps = {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        textAlign: "left",
        fontSize: 35,
        marginBottom: 3
    };

    const checkUpdatePswd = () => {
        if (!isName(current) || !isName(pswd1) || !isName(pswd2)) {
            setPswdError(false);
            setErrorMessage(t("test pswd vide"));
            setOpenErrorDialog(true);
        }

        //TODO : get current password (check if sme as DB) + check new password valid (characters, length, ...)
        if ((pswd1 === pswd2)) {
            return true;
        } else {
            return false;
        }
    }

    const tok = getToken(tokenUser);
    let tokRole = "Null";
    if (tok !== null) {
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
                    <Text sx={catergoryHeaderProps}>{t("editpswd.subtitle")}</Text>

                    <PasswordInput
                        error={pswdError}
                        setTextState={setCurrentPw}
                        setErrorState={setPswdError}
                        setLabel={t("editpswd.currentPswd")}
                        multiline={true}
                    />

                    <PasswordInput
                        setTextState={setPswd1}
                        setLabel={t("editpswd.newPswd")}
                        multiline={true}
                    />

                    <PasswordInput
                        setTextState={setPswd2}
                        setLabel={t("editpswd.confirmPswd")}
                        multiline={true}
                    />

                    <Button id="validate" variant="contained" fullWidth={true} onClick={() => checkUpdatePswd()} sx={{ marginTop: 2, marginBottom: 2 }}>
                        {t("common.valid")}
                    </Button>


                </Box>
            </Box >
        );
    } else {
        navigate("/LogIn", { replace: true });
    }
}
