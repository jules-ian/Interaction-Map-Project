import { Box } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { Text } from "../Components/Label";

export default function Admin() {
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();
  return (
    <Box
      sx={{
        height: height * 0.5,
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
      }}
    >
      <Box sx={{ width: 0.3 }}>
        <Text>Under Construction</Text>
        <ButtonComponent
          label="Back"
          onClick={() => navigate("/Home", { replace: true })}
        />
      </Box>
    </Box>
  );
}
