import { Box, Button } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";

export default function Home() {
  const navigate = useNavigate();
  return (
    <Box>
      <Button
        variant="contained"
        fullWidth={true}
        onClick={() => navigate("/Form", { replace: true })}
      >
        Form
      </Button>
      <Button
        variant="contained"
        fullWidth={true}
        onClick={() => navigate("/Search", { replace: true })}
      >
        Search
      </Button>
    </Box>
  );
}
