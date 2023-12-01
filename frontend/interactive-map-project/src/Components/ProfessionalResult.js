import { Box, Button, Card, CardContent, Typography } from "@mui/material";
import { Header } from "./Label";

export function ResultCard({ professional, width, height, other }) {
  return (
    <Card
      sx={{
        margin: 2,
        height: height,
        wdith: width,
        alignItems: "center",
        justifyContent: "center",
        display: "flex",
        color: "black",
        ...other,
      }}
    >
      <CardContent sx={{ maxWidth: width }}>
        <Typography variant="h5" noWrap>
          {professional.name}
        </Typography>
        <Typography noWrap>
          {"Gestionnare: " + professional.managementType}
        </Typography>
        <Typography noWrap>
          {"Service: " + professional.establishmentType}
        </Typography>
        <Button
          variant="contained"
          fullWidth
          onClick={() => {
            /*TODO*/
          }}
        >
          More Info
        </Button>
      </CardContent>
    </Card>
  );
}

//TODO get the linebreak to prevent
