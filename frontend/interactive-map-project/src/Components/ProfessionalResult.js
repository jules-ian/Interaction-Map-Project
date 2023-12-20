import { Box, Button, Card, CardContent, Typography } from "@mui/material";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect, useState } from "react";
import { Text } from "./Label";

//const AutoPlaySwipeableViews = autoPlay(SwipeableViews);

export default function ResultCardDisplay({
  results,
  setSelectedProfessional,
}) {
  const { height, width } = useWindowDimensions();

  useEffect(() => {
    console.log(results.length);
    console.log(results);
  }, [results]);

  return (
    <Box
      spacing={2}
      display="flex"
      flexDirection="row"
      flexWrap="nowrap"
      overflow="auto"
    >
      {results.length != 0 ? (
        results.map((professional) => (
          <ProfessionalCard
            professional={professional}
            width={width * 0.2}
            height={height * 0.15}
            other={{ flexShrink: 0 }}
            setOnClick={setSelectedProfessional}
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

function ProfessionalCard({ professional, width, height, other, setOnClick }) {
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
          setOnClick(professional);
        }}
      >
        More Info
      </Button>
    </ResultCard>
  );
}

function ResultCard(props) {
  const { width, height, other } = props;
  const content = props.children;

  return (
    <Card
      sx={{
        margin: 1,
        padding: 1,
        height: height,
        width: width,
        color: "black",
        justifyContent: "center",
        display: "flex",
        flexDirection: "column",

        "&:hover": {
          background: "lightblue", // change to the desired background color on hover
        },
        ...other,
      }}
    >
      <CardContent>{content}</CardContent>
    </Card>
  );
}
