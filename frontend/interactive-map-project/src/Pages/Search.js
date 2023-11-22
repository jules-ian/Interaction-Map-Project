import SearchBar from "../Components/SearchBar"
import DropMultiSelect from "../Components/DropMultiSelect"
import Box from '@mui/system/Box';
import useWindowDimensions from "../utils/windowDimension";
import { List, ListItem } from "@mui/material";
import { getLieuIntervention, getMission, getPublic } from "../utils/BackendFunctions";
import PostalCodeInput from "../Components/PostalCodeInput";
import { useEffect, useState } from "react";

export default function Search() {
    const [postalcode, setpostalcode] = useState("");
    const [results, setResults] = useState([]);
    const {height, width} = useWindowDimensions();

    
    useEffect(()=>{
      setResults(produce_random_results())
    },[postalcode])
    return (
      <Box>
        <Box sx={{ display:"flex",flexDirection:"row"}}>
          
          <Box sx={{width:400, margin:2}}>
            <SearchBar/> 
            <PostalCodeInput state_postalcode = {{postalcode,setpostalcode}} label="Postalcode"/>
            <DropMultiSelect label="Mission" options={getMission()}/>
            <DropMultiSelect label="Public" options={getPublic()}/>
            <DropMultiSelect label="Lieu d'intervention" options={getLieuIntervention()}/>
          </Box>
          <Placeholder text="Map under construction" height={height*0.7} width={"100%"}/>
          </Box>
          <Box sx={{display:"flex", overflow: "auto", flexDirection:"row"}}>
            {results.map((i)=>(<Placeholder text={"Result "+i} width={height*0.2} height={height*0.2} other={{flexShrink: 0}}/>))}
          </Box>
        </Box>
  )
}

function produce_random_results(){
  return(
    [...Array(Math.round(Math.random()*10)+1).keys()]
  )
}

function Placeholder({text,width,height, other}){
  return(
    <Box
                sx={{
                  margin:2,
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
