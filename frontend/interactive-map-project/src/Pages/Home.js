import { Box } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";

export default function Home() {
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
        <ButtonComponent
          label="Form"
          onClick={() => navigate("/Form", { replace: true })}
        />
        <ButtonComponent
          label="Search"
          onClick={() => navigate("/Search", { replace: true })}
        />
        <Box sx={{ height: height * 0.02 }}></Box>
        <ButtonComponent
          label="Admin"
          onClick={() => navigate("/Admin", { replace: true })}
          color="secondary"
        />
        <ButtonComponent
          label="Test"
          onClick={() => navigate("/Test", { replace: true })}
          color="secondary"
        />
      </Box>
    </Box>
  );
}
