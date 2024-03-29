import { Autocomplete, TextField } from "@mui/material";
import InputComponent from "./InputComponent";

function DropMultiSelect({ //TODO : set les valeurs par défaut
  setSelectionState = function () { },
  options = [],
  label = "label",
  error = false,
  setErrorState = function () { },
  placeholder = "placeholder",
}) {
  return (
    <InputComponent>
      <Autocomplete
        multiple
        id="tags-standard"
        options={options}
        error={true}
        getOptionLabel={(option) => option}
        renderInput={(params) => (
          <TextField
            {...params}
            label={label}
            error={error}
            placeholder={placeholder}
          />
        )}
        onChange={(event, newValue) => {
          setErrorState(false);
          setSelectionState(newValue);

          if (event.key === "Enter") {
            // handle events here
          }
        }}
      />
    </InputComponent>
  );
}

export default DropMultiSelect;
// doc https://mui.com/material-ui/react-autocomplete/
