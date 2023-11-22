import { TextField } from "@mui/material";
import { useEffect, useState } from "react";

export default function PostalCodeInput ({state_postalcode, label}){
    return (
    <TextField 
        id="outlined-basic" 
        label={label} 
        variant="outlined" 
        fullWidth="true"
        error = {! (state_postalcode.postalcode == "" || state_postalcode.postalcode.length == 6 && !isNaN(Number(state_postalcode.postalcode)))}
        onKeyDown={(event) => {
            if (event.key === 'Enter') {
                state_postalcode.setpostalcode(event.target.value)
            }
        }
    }
    />
    );
}

// how to put the error part into a function, function only get called at initialization but i want it to be bound to the state and rerender on update