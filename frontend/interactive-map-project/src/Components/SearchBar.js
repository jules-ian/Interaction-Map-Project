import { TextField } from "@mui/material";
import InputComponent from "./InputComponent";
import { useTranslation } from "react-i18next";

function SearchBar() {
  const { t } = useTranslation();
  return (
    <InputComponent>
      <TextField
        id="outlined-basic"
        label={t("common.search")}
        variant="outlined"
        fullWidth={true}
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
