import {
  Box,
  Button,
  Card,
  CardContent,
  MobileStepper,
  Typography,
} from "@mui/material";
import { Header } from "./Label";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect, useState } from "react";
import { arrayRange } from "../utils/ArrayFunctions";

//const AutoPlaySwipeableViews = autoPlay(SwipeableViews);

export default function ResultCardDisplay({ results }) {
  const { height, width } = useWindowDimensions();
  const [activeStep, setActiveStep] = useState(0);
  const cardWidth = 0.4;
  const stepSize = Math.floor(1 / cardWidth);
  const maxSteps = function () {
    return Math.ceil(results.length / stepSize);
  };
  useEffect(() => {
    console.log(results.length);
    console.log(results);
  }, [results]);

  const handleNext = () => {
    setActiveStep((prevActiveStep) => prevActiveStep + 1);
  };

  const handleBack = () => {
    setActiveStep((prevActiveStep) => prevActiveStep - 1);
  };

  const handleStepChange = (step) => {
    setActiveStep(step);
  };

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
    // TODO better visual representation
    // <div>
    //   <Box sx={{ display: "flex", overflow: "auto", flexDirection: "row" }}>
    //     {maxSteps() === 0 ? (
    //       <div></div>
    //     ) : (
    //       arrayRange(activeStep, activeStep + stepSize, 1).map((index) =>
    //         maxSteps() >= index ? (
    //           <ResultCard
    //             professional={results[index * stepSize]}
    //             width={height * cardWidth}
    //             height={height * 0.2}
    //             other={{ flexShrink: 0 }}
    //           />
    //         ) : (
    //           <div></div>
    //         )
    //       )
    //     )}
    //   </Box>
    //   {/* <AutoPlaySwipeableViews
    //     axis="x-reverse"
    //     index={activeStep}
    //     onChangeIndex={handleStepChange}
    //     enableMouseEvents
    //   >
    //     {results.map((step, index) => (
    //       <div key={step.label}>
    //         {Math.abs(activeStep - index) <= 2 ? (
    //           <Box
    //             component="img"
    //             sx={{
    //               height: 255,
    //               display: "block",
    //               maxWidth: 400,
    //               overflow: "hidden",
    //               width: "100%",
    //             }}
    //             src={step.imgPath}
    //             alt={step.label}
    //           />
    //         ) : null}
    //       </div>
    //     ))}
    //   </AutoPlaySwipeableViews> */}
    //   <MobileStepper
    //     steps={maxSteps()}
    //     position="static"
    //     activeStep={activeStep}
    //     nextButton={
    //       <Button
    //         size="small"
    //         onClick={handleNext}
    //         disabled={activeStep === maxSteps() - 1}
    //       >
    //         Next
    //       </Button>
    //     }
    //     backButton={
    //       <Button size="small" onClick={handleBack} disabled={activeStep === 0}>
    //         Back
    //       </Button>
    //     }
    //   />
    // </div>
  );
}

function ResultCard({ professional, width, height, other }) {
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
