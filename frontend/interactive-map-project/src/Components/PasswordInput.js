import { TextField } from "@mui/material";
import InputComponent from "./InputComponent";
import { useTranslation } from "react-i18next";

export default function PasswordInput({
    setTextState,
    setErrorState = function () { }
}) {
    const { t } = useTranslation();
    return (
        <InputComponent>
            <TextField
                id="outlined-password-input"
                label={t("professional.password")}
                type="password"
                variant="outlined"
                fullWidth="true"
                autoComplete="current-password"
                onChange={(event) => {
                    setErrorState(false);
                    setTextState(event.target.value);
                    if (event.key === "Enter") {
                    }
                }}
            />
        </InputComponent>
    );
}
