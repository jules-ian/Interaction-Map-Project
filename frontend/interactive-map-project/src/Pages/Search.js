import SearchBar from "../Components/SearchBar"
import DropMultiSelect from "../Components/DropMultiSelect"
import Box from '@mui/system/Box';
import useWindowDimensions from "../utils/windowDimension";
import { Button, List, ListItem } from "@mui/material";
import { getLieuIntervention, getMission, getPublic } from "../utils/BackendFunctions";
import PostalCodeInput from "../Components/PostalCodeInput";
import { useEffect, useState } from "react";
import InputComponent from "../Components/InputComponent";
import Map from "../Components/Map";

export default function Search() {
  const [postalcode, setpostalcode] = useState("");
  const [mission, setMission] = useState(getMission());
  const [_public, set_Public] = useState(getPublic());
  const [lieuIntervention, setLieuIntervention] = useState(getLieuIntervention());
  const [results, setResults] = useState([]);
  const { height, width } = useWindowDimensions();


  const rerenderResults = () => {
    setResults(produce_random_results())
  }


  return (
    <Box>
      <Box sx={{ display: "flex", flexDirection: "row" }}>

        <Box sx={{ width: 400, margin: 2 }}>
          <InputComponent>
            <SearchBar />
          </InputComponent>
          <InputComponent>
            <PostalCodeInput state_postalcode={{ postalcode, setpostalcode }} label="Postalcode" />
          </InputComponent>
          <InputComponent>
            <DropMultiSelect label="Mission" optionsState={mission} setOptionsState={setMission} />
          </InputComponent>
          <InputComponent>
            <DropMultiSelect label="Public" optionsState={_public} setOptionsState={set_Public} />
          </InputComponent>
          <InputComponent>
            <DropMultiSelect label="Lieu d'intervention" optionsState={lieuIntervention} setOptionsState={setLieuIntervention} />
          </InputComponent>


          <InputComponent>
            <Button variant="contained" fullWidth={true}
              onClick={rerenderResults}>
              Search
            </Button>
          </InputComponent>

        </Box>
        <Map />
      </Box>
      <Box sx={{ display: "flex", overflow: "auto", flexDirection: "row" }}>
        {results.map((i) => (<Placeholder text={"Result " + i} width={height * 0.2} height={height * 0.2} other={{ flexShrink: 0 }} />))}
      </Box>
    </Box>
  )
}

function produce_random_results() {
  return (
    [...Array(Math.round(Math.random() * 10) + 1).keys()]
  )
}

function Placeholder({ text, width, height, other }) {
  return (
    <Box
      sx={{
        margin: 2,
        height: height,
        width: width,
        borderRadius: 3,
        bgcolor: 'black',
        alignItems: "center",
        justifyContent: "center",
        display: "flex",
        color: "white",
        ...other
      }}>{text}</Box>
  )
}
