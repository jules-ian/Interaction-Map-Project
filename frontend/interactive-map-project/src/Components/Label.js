import { Typography } from "@mui/material";

export function Text(props) {
  const { sx } = props;

  const text = props.children;
  return (
    <Typography sx={sx} variant="h6">
      {text}
    </Typography>
  );
}

export function Header(props) {
  const { sx } = props;
  const text = props.children;
  return (
    <Typography sx={sx} variant="h4">
      {text}
    </Typography>
  );
}
