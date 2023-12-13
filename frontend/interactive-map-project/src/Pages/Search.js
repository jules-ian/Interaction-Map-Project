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
  //TODO Task Sondre
  const [mapCoordinates, setMapCoordinates] = useState({
    topleft: { lo: 0, la: 0 },
    topright: { lo: 0, la: 0 },
    bottomleft: { lo: 0, la: 0 },
    bottomright: { lo: 0, la: 0 },
  });

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
  // change to search criteria
  useEffect(() => {
    onSearch();
  }, [
    search,
    postal,
    missionsSelection,
    audiencesSelection,
    placesOfInterventionSelection,
    mapCoordinates,
  ]);

  const onSearch = function () {
    let success = checkEntries();
    if (success) {
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
        <Box
          sx={{
            width: 400,
            margin: 2,
            display: "flex",
            flexDirection: "column",
            justifyContent: "center",
          }}
        >
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
        </Box>
        <Map />
      </Box>
      <ResultCardDisplay results={results} />
    </Box>
  );
}
