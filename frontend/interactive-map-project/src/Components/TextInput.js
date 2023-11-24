import { TextField } from "@mui/material"
export default function TextInput({textState, setTextState, label="placeholder"}){
    return(
        <TextField 
            id="outlined-basic" 
            label={label} 
            variant="outlined" 
            fullWidth="true"
            onKeyDown={(event) => {
                if (event.key === 'Enter') {
                    setTextState(event.target.value)
                }
            }}
        />
    )
}