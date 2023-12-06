import DropMultiSelect from "../Components/DropMultiSelect";
import Box from "@mui/system/Box";
import useWindowDimensions from "../utils/windowDimension";
import { Button } from "@mui/material";
import {
  getAudiences,
  getPlacesOfIntervention,
  getMissions,
  getResults,
} from "../utils/BackendFunctions";
import TextInput from "../Components/TextInput";
import { useState } from "react";
import { isPostalCode } from "../utils/checkFunctions";
import ResultCardDisplay from "../Components/ProfessionalResult";

export default function Search() {
  const [search, setSearch] = useState("");
  const [postal, setPostal] = useState("");
  const [postalError, setPostalError] = useState(false);
  const [missions, setMissions] = useState(getMissions());
  const [_public, set_Public] = useState(getAudiences());
  const [lieuIntervention, setLieuIntervention] = useState(
    getPlacesOfIntervention()
  );
  const [results, setResults] = useState([]);
  const { height, width } = useWindowDimensions();

  const onSearch = function () {
    let success = checkEntries();
    if (success) {
      setResults(getResults());
    }
  };

  const checkEntries = function () {
    let checkSuccess = true;
    if (!isPostalCode(postal) && postal !== "") {
      setPostalError(true);
      checkSuccess = false;
    }
    return checkSuccess;
  };

  return (
    <Box>
      <Box sx={{ display: "flex", flexDirection: "row" }}>
        <Box sx={{ width: 400, margin: 2 }}>
          <TextInput setTextState={setSearch} label="Search" />

          <TextInput
            setTextState={setPostal}
            error={postalError}
            setErrorState={setPostalError}
            label="Postalcode"
          />

          <DropMultiSelect
            label="Mission"
            optionsState={missions}
            setOptionsState={setMissions}
          />

          <DropMultiSelect
            label="Public"
            optionsState={_public}
            setOptionsState={set_Public}
          />

          {/* <DropMultiSelect
            label="Lieu d'intervention"
            optionsState={lieuIntervention}
            setOptionsState={setLieuIntervention}
          /> */}
          <InitGetter
            label="Lieu d'interventation"
            API="https://localhost:7212/api/field-of-intervention/place-of-intervention/all"
          />

          <Button variant="contained" fullWidth onClick={onSearch}>
            Search
          </Button>
        </Box>
        <Placeholder
          text="Map under construction"
          height={height * 0.7}
          width={"100%"}
        />
      </Box>
      <ResultCardDisplay results={results} />
    </Box>
  );
}

function Placeholder({ text, width, height, other }) {
  return (
    <Box
      sx={{
        margin: 2,
        height: height,
        width: width,
        borderRadius: 3,
        bgcolor: "black",
        alignItems: "center",
        justifyContent: "center",
        display: "flex",
        color: "white",
        ...other,
      }}
    >
      {text}
    </Box>
  );
}
