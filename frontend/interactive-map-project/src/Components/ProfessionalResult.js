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
import { Text } from "./Label";

//const AutoPlaySwipeableViews = autoPlay(SwipeableViews);

export default function ResultCardDisplay({ results }) {
  const { height, width } = useWindowDimensions();

  useEffect(() => {
    console.log(results.length);
    console.log(results);
  }, [results]);

  return (
    <Box
      sx={{
        display: "flex",
        overflow: "auto",
        flexDirection: "row",
        backgroundColor: "lightgrey",
        margin: 1,
        borderRadius: 1,
      }}
    >
      {results.length != 0 ? (
        results.map((professional) => (
          <ProfessionalCard
            professional={professional}
            width={height * 0.4}
            height={height * 0.2}
            other={{ flexShrink: 0 }}
          />
        ))
      ) : (
        <ResultCard>
          <Text>No Results</Text>
        </ResultCard>
      )}
    </Box>
  );
}

function ProfessionalCard({ professional, width, height, other }) {
  return (
    <ResultCard width={width} height={height} other={other}>
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
    </ResultCard>
  );
}

function ResultCard(props, { width, height, other }) {
  const content = props.children;
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
      <CardContent sx={{ maxWidth: width }}>{content}</CardContent>
    </Card>
  );
}
