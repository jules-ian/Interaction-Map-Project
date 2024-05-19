import { Popover, IconButton, Grid, Box } from "@mui/material";
import CloseIcon from "@mui/icons-material/Close";
import React, { useEffect, useState } from "react";
import useWindowDimensions from "../utils/windowDimension.js";
import { Header, Text } from "./Label.js";
import { useTranslation } from "react-i18next";

export function PopoverWindow(props) {
  const { selectedProfessional, openPopover, setOpenPopover } = props;
  const content = props.children;

  const [anchorEl, setAnchorEl] = useState(null);
  const { width, height } = useWindowDimensions();
  useEffect(() => {
    if (selectedProfessional !== null && openPopover) {
      handlePop();
    }
  }, [openPopover]);

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
    setOpenPopover(false);
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
      sx={{}}
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
  const { t } = useTranslation();

  return (
    <div>
      {professional == null ? (
        <div></div>
      ) : (
        <Box
          sx={{
            margin: 5,
            height: height * 0.9,
            width: width * 0.7,
            position: "relative",
          }}
        >
          <Box
            sx={{
              boxSizing: "border-box",
              height: "100%",
              width: "100%",
            }}
          >
            <Text sx={{ marginLeft: -2 }}>
              {t("professional.popOver.infoProfessional")}
            </Text>
            <Row
              label={t("professional.name")}
              value={professional.name}
              marked={true}
            />
            <Row
              label={t("common.typeO") + " " + t("professional.establishment")}
              value={professional.establishmentType}
            />
            <Row
              label={t("common.typeOf") + " " + t("professional.management")}
              value={professional.managementType}
              marked={true}
            />
            <Row
              label={t("professional.address.street")}
              value={professional.address.street}
            />
            <Row
              label={t("professional.address.city")}
              value={professional.address.city}
              marked={true}
            />
            <Row
              label={t("professional.address.postalCode")}
              value={professional.address.postalCode}
            />
            <Row
              label={t("professional.email")}
              value={professional.email}
              marked={true}
            />
            <Text sx={{ marginLeft: -2 }}>
              {t("professional.popOver.infoContactPerson")}
            </Text>
            <Row
              label={t("professional.contactPerson.name")}
              value={professional.contactPerson.name}
              marked={true}
            />
            <Row
              label={t("professional.contactPerson.phoneNumber")}
              value={professional.contactPerson.phoneNumber}
            />
            <Row
              label={t("professional.contactPerson.email")}
              value={professional.contactPerson.email}
              marked={true}
            />
            <Row
              label={t("professional.contactPerson._function")}
              value={professional.contactPerson._function}
            />
            <Text sx={{ marginLeft: -2 }}>
              {t("professional.popOver.infoFieldsOfIntervention")}
            </Text>
            <Row
              label={t("professional.audiences")}
              value={professional.audiences}
              marked={true}
            />
            <Row
              label={t("professional.placesOfIntervention")}
              value={professional.placesOfIntervention}
            />
            <Row
              label={t("professional.missions")}
              value={professional.missions}
              marked={true}
            />

            <Text sx={{ marginLeft: -2 }}>
              {t("professional.popOver.description")}
            </Text>
            <Grid item xs={12}>
              {professional.description}
            </Grid>
          </Box>
        </Box>
      )}
    </div>
  );
}

function Row({ label, value, marked }) {
  const color = "lightgrey";
  const rowProps = { padding: 0.2 };
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
