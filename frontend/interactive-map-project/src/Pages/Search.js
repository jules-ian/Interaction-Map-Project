import DropMultiSelect from "../Components/DropMultiSelect";
import Box from "@mui/system/Box";
import { Button } from "@mui/material";
import {
  getAllAudiences,
  getAllPlacesOfIntervention,
  getAllMissions,
  getResults,
  getResultsSearch,
} from "../utils/BackendFunctions";
import TextInput from "../Components/TextInput";
import { useEffect, useState } from "react";
import { isPostalCode } from "../utils/checkFunctions";
import ResultCardDisplay from "../Components/ProfessionalResult";
import Map from "../Components/Map";
import { mapNamesToIDs } from "../utils/ArrayFunctions";

export default function Search() {
  const [search, setSearch] = useState("");
  const [postal, setPostal] = useState("");
  const [postalError, setPostalError] = useState(false);
  const [missions, setMissions] = useState([]);
  const [audiences, setAudiences] = useState([]);
  const [placesOfIntervention, setPlacesOfIntervention] = useState([]);
  const [missionsSelection, setMissionsSelection] = useState([]);
  const [audiencesSelection, setAudiencesSelection] = useState([]);
  const [placesOfInterventionSelection, setPlacesOfInterventionSelection] =
    useState([]);
  const [results, setResults] = useState([]);

  // on first render
  useEffect(() => {
    getAllPlacesOfIntervention(setPlacesOfIntervention);
    getAllMissions(setMissions);
    getAllAudiences(setAudiences);
  }, []);

  const onSearch = function () {
    let success = checkEntries();
    if (success) {
      setResults(getResults());
      let audiencesIDs = mapNamesToIDs(audiencesSelection, audiences);
      let placesOfInterventionIDs = mapNamesToIDs(
        placesOfInterventionSelection,
        placesOfIntervention
      );
      let missionsIDS = mapNamesToIDs(missionsSelection, missions);
      getResultsSearch(
        postal,
        audiencesIDs,
        placesOfInterventionIDs,
        missionsIDS,
        setResults
      );
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
            label="Missions"
            options={missions.map((item) => item.name)}
            setSelectionState={setMissionsSelection}
          />

          <DropMultiSelect
            label="Public"
            options={audiences.map((item) => item.name)}
            setSelectionState={setAudiencesSelection}
          />

          <DropMultiSelect
            label="Lieu d'intervention"
            options={placesOfIntervention.map((item) => item.name)}
            setSelectionState={setPlacesOfInterventionSelection}
          />
          <Button variant="contained" fullWidth onClick={onSearch}>
            Search
          </Button>
        </Box>
        <Map />
      </Box>
      <ResultCardDisplay results={results} />
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
