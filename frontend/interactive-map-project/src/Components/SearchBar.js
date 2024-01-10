import { TextField } from "@mui/material";
import InputComponent from "./InputComponent";

function SearchBar() {
  return (
    <InputComponent>
      <TextField
        id="outlined-basic"
        label="Search"
        variant="outlined"
        fullWidth="true"
        onKeyDown={(event) => {
          if (event.key === "Enter") {
            // handle events here
          }
        }}
      />
    </InputComponent>
  );
}
export default SearchBar;

// doc https://mui.com/material-ui/react-text-field/
