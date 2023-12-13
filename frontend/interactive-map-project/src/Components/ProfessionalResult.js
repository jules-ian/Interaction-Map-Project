import {
  Box,
  Button,
  Card,
  CardContent,
  MobileStepper,
  Typography,
} from "@mui/material";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect, useState } from "react";

//const AutoPlaySwipeableViews = autoPlay(SwipeableViews);

export default function ResultCardDisplay({ results }) {
  const { height, width } = useWindowDimensions();
  const cardWidth = 0.4;
  useEffect(() => {
    console.log(results.length);
    console.log(results);
  }, [results]);

  return (
    <Box sx={{ display: "flex", overflow: "auto", flexDirection: "row" }}>
      {results.map((professional) => (
        <ResultCard
          professional={professional}
          width={height * 0.4}
          height={height * 0.2}
          other={{ flexShrink: 0 }}
        />
      ))}
    </Box>
  );
}

function ResultCard({ professional, width, height, other }) {
  return (
    <Card
      sx={{
        margin: 2,
        padding: 2,
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
