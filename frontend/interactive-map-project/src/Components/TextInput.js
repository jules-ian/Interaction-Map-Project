import { TextField } from "@mui/material";
import InputComponent from "./InputComponent";
export default function TextInput({
  defaultValue,
  setTextState,
  error = false,
  setErrorState = function () { },
  label = "",
  multiline = false,
  helperText = "",
}) {
  return (
    <InputComponent>
      <TextField
        id="outlined-basic"
        label={label}
        variant="outlined"
        fullWidth="true"
        helperText={error ? helperText : ""}
        error={error}
        multiline={multiline}
        defaultValue={defaultValue}
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
