import { Box, Button } from "@mui/material";
import { useNavigate } from "react-router-dom";
import useWindowDimensions from "../utils/windowDimension";
import { useTranslation } from "react-i18next";
import PasswordInput from "../Components/PasswordInput";
import { Text } from "../Components/Label";

export default function InitPassword({ setMenuTitel }) {


    const { t } = useTranslation(); //t -> alias pour useTranslation() (traduction en vers fr)
    setMenuTitel(t("initpswd.titlepage"));
    const navigate = useNavigate();
    const { height } = useWindowDimensions();

    const catergoryHeaderProps = {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        textAlign: "left",
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
                <Text sx={catergoryHeaderProps}>{t("initpswd.subtitle")}</Text>

                <PasswordInput
                    setLabel={t("initpswd.newPswd")}
                    multiline={true}
                />

                <PasswordInput
                    setLabel={t("initpswd.confirmPswd")}
                    multiline={true}
                />

                <Button id="validate" variant="contained" fullWidth={true} onClick={() => navigate("/LogIn", { replace: true })} sx={{ marginTop: 2, marginBottom: 2 }}>
                    {t("common.valid")}
                </Button>


            </Box>
        </Box >
    );
}
