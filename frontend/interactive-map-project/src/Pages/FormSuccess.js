import { Box } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { Text } from "../Components/Label";

export default function FormSuccess() {
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();
  return (
    <Box
      sx={{
        height: height * 0.5,
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        flexDirection: "column",
      }}
    >
      <Text>Entering Form was successfull returning to Homescreen</Text>
      <Box sx={{ width: 0.3 }}>
        <ButtonComponent
          label="Home"
          onClick={() => navigate("/Home", { replace: true })}
        />
      </Box>
    </Box>
  );
}
