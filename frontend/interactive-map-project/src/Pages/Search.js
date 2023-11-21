import SearchBar from "../Components/SearchBar"
import DropMultiSelect from "../Components/DropMultiSelect"
import Box from '@mui/system/Box';
import useWindowDimensions from "../utils/windowDimension";
import { List, ListItem } from "@mui/material";


export default function Search() {
    const {height, width} = useWindowDimensions();
    return (
      <Box>
        <Box sx={{ display:"flex",flexDirection:"row"}}>
          
          <Box sx={{width:400, margin:2}}>
            <SearchBar/> 
            <DropMultiSelect/>
            <DropMultiSelect/>
            <DropMultiSelect/>
            <DropMultiSelect/>
          </Box>
          <Placeholder text="Map under construction" height={height*0.7} width={"100%"}/>
          </Box>
          <Box sx={{display:"flex", overflow: "auto", flexDirection:"row"}}>
            {[...Array(10).keys()].map((i)=>(<Placeholder text={"Result "+i} width={height*0.2} height={height*0.2} other={{flexShrink: 0}}/>))}
          </Box>
        </Box>
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
