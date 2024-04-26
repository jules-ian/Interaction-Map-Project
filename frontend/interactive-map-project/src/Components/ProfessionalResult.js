import { Box, Button, Card, CardContent, Typography } from "@mui/material";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect } from "react";
import { Text } from "./Label";
import { useTranslation } from "react-i18next";

//const AutoPlaySwipeableViews = autoPlay(SwipeableViews);

export default function ResultCardDisplay({
  results,
  setSelectedProfessional,
  setOpenPopover,
}) {
  const { height, width } = useWindowDimensions();
  const { t } = useTranslation();
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
      {results.length !== 0 ? (
        results.map((professional) => (
          <ProfessionalCard
            professional={professional}
            width={width * 0.2}
            height={height * 0.15}
            other={{ backgroundColor: '#efffff', flexShrink: 0 }}
            setOnClick={setSelectedProfessional}
            setOpenPopover={setOpenPopover}
          />
        ))
      ) : (
        <ResultCard>
          <Text >{t("common.noResults")}</Text>
        </ResultCard>
      )}
    </Box>
  );
}

function ProfessionalCard({
  professional,
  width,
  height,
  other,
  setOnClick,
  setOpenPopover,
}) {
  const { t } = useTranslation();
  return (
    <ResultCard width={width} height={height} other={other}>
      <Typography variant="h5" noWrap>
        {professional.name}
      </Typography>
      <Typography noWrap>
        {t("professional.management") + ": " + professional.managementType}
      </Typography>
      <Typography noWrap>
        {t("professional.establishment") +
          ": " +
          professional.establishmentType}
      </Typography>
      <Button
        variant="outlined"
        sx={{ backgroundColor: '#ffffff' }}
        fullWidth
        onClick={() => {
          setOpenPopover(true);
          setOnClick(professional);
        }}
      >
        {t("common.moreInfo")}
      </Button>
    </ResultCard >
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
        minHeight: 100,
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
