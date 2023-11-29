import { Checkbox, FormControlLabel } from "@mui/material";
import InputComponent from "./InputComponent";

export function SingleCheckbox({
  // TODO visual feedback depending on error
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
    />
  );
  return (
    <InputComponent>
      <FormControlLabel control={singleCheckbox} label={label} />
    </InputComponent>
  );
}
