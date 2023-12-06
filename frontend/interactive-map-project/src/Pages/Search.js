import DropMultiSelect from "../Components/DropMultiSelect";
import Box from "@mui/system/Box";
import { Button } from "@mui/material";
import {
  getAudiences,
  getPlacesOfIntervention,
  getMissions,
  getResults,
} from "../utils/BackendFunctions";
import TextInput from "../Components/TextInput";
import { useEffect, useState } from "react";
import { isPostalCode } from "../utils/checkFunctions";
import ResultCardDisplay from "../Components/ProfessionalResult";
import Map from "../Components/Map";

export default function Search() {
  const [search, setSearch] = useState("");
  const [postal, setPostal] = useState("");
  const [postalError, setPostalError] = useState(false);
  const [missions, setMissions] = useState([]);
  const [audiences, setAudiences] = useState([]);
  const [placesOfIntervention, setPlacesOfIntervention] = useState([]);
  const [results, setResults] = useState([]);

  // on first render
  useEffect(() => {
    getPlacesOfIntervention(setPlacesOfIntervention);
    getMissions(setMissions);
    getAudiences(setAudiences);
  }, []);

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
          <DropMultiSelect label="Missions" options={missions} />

          <DropMultiSelect label="Public" options={audiences} />

          <DropMultiSelect
            label="Lieu d'intervention"
            options={placesOfIntervention}
          />
          <Button variant="contained" fullWidth onClick={onSearch}>
            Search
          </Button>
        </Box>
        <Map />
      </Box>
      {/* <ResultCardDisplay results={results} /> */}
    </Box>
  );
}

// function Placeholder({ text, width, height, other }) {
//   return (
//     <Box
//       sx={{
//         margin: 2,
//         height: height,
//         width: width,
//         borderRadius: 3,
//         bgcolor: "black",
//         alignItems: "center",
//         justifyContent: "center",
//         display: "flex",
//         color: "white",
//         ...other,
//       }}
//     >
//       {text}
//     </Box>
//   );
// }
