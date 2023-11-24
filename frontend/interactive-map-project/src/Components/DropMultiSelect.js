import { Autocomplete, TextField } from "@mui/material"

function DropMultiSelect ({options=[], label="label", placeholder="placeholder"}){
    return (
        <Autocomplete
            multiple
            id="tags-standard"
            options={options}
            getOptionLabel={(option) => option}
            renderInput={(params) => (
            <TextField
                {...params}
                label={label}
                placeholder={placeholder}
            />
            )}
            onKeyDown={(event) => {
                if (event.key === 'Enter') {
                    // handle events here
                }
              }}
        />
    );
}

export default DropMultiSelect;
// doc https://mui.com/material-ui/react-autocomplete/
