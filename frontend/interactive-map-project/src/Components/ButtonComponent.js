import InputComponent from "./InputComponent";
import { Button } from "@mui/material";
import { blue } from "@mui/material/colors";

export default function ButtonComponent({ onClick, label, color = "primary" }) {
  return (
    <InputComponent>
      <Button
        variant="contained"
        fullWidth={true}
        onClick={onClick}
        color={color}
      >
        {label}
      </Button>
    </InputComponent>
  );
}
