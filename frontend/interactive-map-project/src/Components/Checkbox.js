import { Checkbox, FormControlLabel } from "@mui/material";

export function SingleCheckbox({stateCheck, setStateCheck, label}){
    const singleCheckbox = <Checkbox 
            checked={stateCheck}
            label={label}
            onChange={(event)=> {setStateCheck(event.target.checked)}}
            />
    return(
        <FormControlLabel control={singleCheckbox} label={label} />
        
    )
}