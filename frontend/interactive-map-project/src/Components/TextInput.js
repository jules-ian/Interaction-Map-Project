import { TextField } from "@mui/material";
import InputComponent from "./InputComponent";
export default function TextInput({
  defaultValue = "",
  setTextState,
  error = false,
  setErrorState = function () {},
  label = "placeholder",
  multiline = false,
  helperText = "Empty Helpertext",
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
