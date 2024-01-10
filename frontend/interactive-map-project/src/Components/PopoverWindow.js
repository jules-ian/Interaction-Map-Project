import { Popover, IconButton, Grid, Box } from "@mui/material";
import CloseIcon from "@mui/icons-material/Close";
import React, { useEffect, useState } from "react";
import useWindowDimensions from "../utils/windowDimension.js";
import { Header, Text } from "./Label.js";
export function PopoverWindow(props) {
  const { selectedProfessional } = props;
  const content = props.children;

  const [anchorEl, setAnchorEl] = useState(null);
  const { width, height } = useWindowDimensions();
  useEffect(() => {
    if (selectedProfessional !== null) {
      handlePop();
    }
  }, [selectedProfessional]);

  const handlePop = (event) => {
    // calculate and set middle of window for popup
    let middleX = width / 2;
    let middleY = height / 2;
    setAnchorEl({
      clientWidth: 0,
      clientHeight: 0,
      getBoundingClientRect: () => ({
        top: middleY,
        left: middleX,
        width: 0,
        height: 0,
      }),
    });
  };

  const handleClose = () => {
    setAnchorEl(null);
  };

  const open = Boolean(anchorEl);
  const id = open ? "window-like-popover" : undefined;

  return (
    <Popover
      id={id}
      open={open}
      anchorEl={anchorEl}
      onClose={handleClose}
      anchorOrigin={{
        vertical: "center",
        horizontal: "center",
      }}
      transformOrigin={{
        vertical: "center",
        horizontal: "center",
      }}
    >
      <IconButton
        edge="end"
        color="inherit"
        onClick={handleClose}
        sx={{ position: "absolute", top: 10, right: 20 }}
      >
        <CloseIcon />
      </IconButton>
      <ProfessionalTable professional={selectedProfessional} />
    </Popover>
  );
}

function ProfessionalTable({ professional }) {
  const { width, height } = useWindowDimensions();

  return (
    <Box
      sx={{
        padding: 10,
        height: height * 0.6,
        width: width * 0.7,
        display: "flex",
        justifyContent: "center",
        flexDirection: "column",
      }}
    >
      <Text>Information de votre structure</Text>
      <Row
        label="Nom de la structure"
        value={professional.name}
        marked={true}
      />
      <Row label="Service" value={professional.establishmentType} />
      <Row
        label="Gestionnaire"
        value={professional.managementType}
        marked={true}
      />
      <Row label="Street" value={professional.address.street} />
      <Row label="City" value={professional.address.city} marked={true} />
      <Row label="Postal" value={professional.address.postalCode} />
      <Row label="Mail" value={professional.email} marked={true} />
      <Text>Information de la personne ressource</Text>
      <Row
        label="Nom contact personne"
        value={professional.contactPerson.name}
        marked={true}
      />
      <Row
        label="Numero téléphone contact personne"
        value={professional.contactPerson.phoneNumber}
      />
      <Row
        label="Email contact personne"
        value={professional.contactPerson.email}
        marked={true}
      />
      <Row
        label="function contact personne"
        value={professional.contactPerson._function}
      />
      <Text>Champs d'intervention</Text>
      <Row label="Audiences" value={professional.audiences} marked={true} />
      <Row
        label="Lieu d'Intervention"
        value={professional.placesOfIntervention}
      />
      <Row label="Mission" value={professional.missions} marked={true} />
      <Text>Présentation: </Text>
      <Grid item xs={12}>
        {professional.description}
      </Grid>
    </Box>
  );
}

function Row({ label, value, marked }) {
  const color = "lightgrey";
  const rowProps = { padding: 1 };
  return (
    <Grid container>
      <Grid
        item
        xs={12}
        sm={6}
        sx={{ backgroundColor: marked ? color : "", ...rowProps }}
      >
        {label}
      </Grid>
      <Grid
        item
        xs={12}
        sm={6}
        sx={{ backgroundColor: marked ? color : "", ...rowProps }}
      >
        {Array.isArray(value) ? value.join("; ") : value}
      </Grid>
    </Grid>
  );
}
