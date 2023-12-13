import { Typography } from '@mui/material';

export function Text (props){
    const text = props.children
    return (
        <Typography variant="h6" gutterBottom>
            {text}
        </Typography>
    )
} 

export function Header(props){
    const text = props.children
    return (
        <Typography variant="h4" gutterBottom>
            {text}
        </Typography>
    )
} 

