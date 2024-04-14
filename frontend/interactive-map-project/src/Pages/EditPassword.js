import { useEffect } from "react";
import { Box, Button } from "@mui/material";
import { useNavigate } from "react-router-dom";
import useWindowDimensions from "../utils/windowDimension";
import { useState } from "react";
import { useTranslation } from "react-i18next";
import PasswordInput from "../Components/PasswordInput";
import { Text } from "../Components/Label";


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
    const { width, height } = useWindowDimensions();

    const [current, setCurrentPw] = useState("");
    const [pswd1, setPswd1] = useState("");
    const [pswd2, setPswd2] = useState("");


    const catergoryHeaderProps = {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        fontSize: 35,
        marginBottom: 3
    };

    const checkUpdatePswd = () => {
        //TODO : get current password (check if sme as DB) + check new password valid (characters, length, ...)
        if (pswd1 === pswd2) {
            return true;
        } else {
            return false;
        }
    }


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
                    setTextState={setCurrentPw}
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
}
