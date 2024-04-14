import { TextField } from "@mui/material";
import InputComponent from "./InputComponent";
import { useTranslation } from "react-i18next";

export default function PasswordInput({
    setTextState,
    setLabel,
    setErrorState = function () { }
}) {
    const { t } = useTranslation();
    return (
        <InputComponent>
            <TextField
                id="outlined-password-input"
                label={setLabel}
                type="password"
                variant="outlined"
                fullWidth="true"
                autoComplete="current-password"
                onChange={(event) => {
                    setErrorState(false);
                    setTextState(event.target.value);
                }}
            />
        </InputComponent>
    );
}
