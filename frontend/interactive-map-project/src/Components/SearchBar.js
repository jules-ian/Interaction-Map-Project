import { TextField } from "@mui/material";

function SearchBar (){
    return (
    <TextField 
        id="outlined-basic" 
        label="Search" 
        variant="outlined" 
        fullWidth="true"
        onKeyDown={(event) => {
            if (event.key === 'Enter') {
                // handle events here
            }
        }}
    />
    );
}
export default SearchBar;

// doc https://mui.com/material-ui/react-text-field/