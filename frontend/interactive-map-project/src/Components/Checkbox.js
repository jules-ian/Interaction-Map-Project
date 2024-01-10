import { Checkbox, FormControlLabel } from "@mui/material";
import { red } from "@mui/material/colors";
import InputComponent from "./InputComponent";

export function SingleCheckbox({
  checked,
  error,
  setErrorState,
  setStateCheck,
  label,
}) {
  const singleCheckbox = (
    <Checkbox
      checked={checked}
      label={label}
      onChange={(event) => {
        setErrorState(false);
        setStateCheck(event.target.checked);
      }}
      sx={{ color: error ? red[800] : "black" }}
    />
  );
  return (
    <InputComponent>
      <FormControlLabel
        control={singleCheckbox}
        label={label}
        sx={{ color: error ? red[800] : "black" }}
      />
    </InputComponent>
  );
}
