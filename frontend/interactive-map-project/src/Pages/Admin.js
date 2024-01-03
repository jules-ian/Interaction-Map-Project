import { Box, CircularProgress, Grid, IconButton } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import CheckIcon from "@mui/icons-material/Check";
import useWindowDimensions from "../utils/windowDimension";
import { Header, Text } from "../Components/Label";
import { useEffect, useState } from "react";
import {
  approveProfessional,
  declineProfessional,
  getResultsSearch,
} from "../utils/BackendFunctions";
import { PopoverWindow } from "../Components/PopoverWindow";

export default function Admin() {
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();
  const [unapprovedProfessionals, setUnapprovedProfessionals] = useState([]);
  const [selectedProfessional, setSelectedProfessional] = useState(null);
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    getResultsSearch(setUnapprovedProfessionals);
  }, []);

  const callbackAcceptDecline = function () {
    getResultsSearch(setUnapprovedProfessionals);
    setSelectedProfessional(null);
  };

  useEffect(() => {
    setLoading(false);
  }, [unapprovedProfessionals]);

  return (
    <Box
      sx={{
        height: height * 0.5,
        display: "flex",
        flexDirection: "column",
        padding: 5,
      }}
    >
      {loading ? (
        <CircularProgress />
      ) : (
        <Tabel
          unapprovedProfessionals={unapprovedProfessionals}
          setSelectedProfessional={setSelectedProfessional}
          selectedProfessional={selectedProfessional}
          callbackAcceptDecline={callbackAcceptDecline}
          setLoading={setLoading}
        />
      )}
    </Box>
  );
}

function Tabel({
  unapprovedProfessionals,
  setSelectedProfessional,
  selectedProfessional,
  callbackAcceptDecline,
  setLoading,
}) {
  return (
    <Box>
      {/* HEADERS */}
      <Grid container sx={{ marginBottom: 2, alignItems: "center" }}>
        <Grid item xs={8}>
          <Header sx={{ textAlign: "left" }}>Nom de la structure</Header>
        </Grid>
      </Grid>
      ;{/*TABEL*/}
      {unapprovedProfessionals.length != 0 ? (
        unapprovedProfessionals.map((professional) => (
          // every professional
          <Grid
            container
            sx={{
              borderTop: "2px solid lightblue",
              alignItems: "center",
              "&:hover": {
                background: "lightblue", // change to the desired background color on hover
              },
            }}
          >
            <Grid
              item
              xs={9}
              onClick={() => {
                console.log(professional);
                setSelectedProfessional(professional);
              }}
            >
              <Text sx={{ textAlign: "left" }}>{professional.name}</Text>
            </Grid>
            <Grid
              item
              xs={1.5}
              sx={{
                width: "100%",
                height: "100%",
                padding: 0.2,
              }}
            >
              <Box
                sx={{
                  borderRadius: 1,
                  background: "darkgreen",
                  width: "100%",
                  height: "100%",
                  color: "white",
                  display: "flex",
                  justifyContent: "center",
                  alignItems: "center",
                  "&:hover": {
                    background: "green", // change to the desired background color on hover
                  },
                }}
                onClick={() => {
                  setLoading(true);
                  approveProfessional(professional, callbackAcceptDecline);
                }}
              >
                Accepter
              </Box>
            </Grid>
            <Grid
              item
              xs={1.5}
              sx={{
                width: "100%",
                height: "100%",
                padding: 0.2,
              }}
            >
              <Box
                sx={{
                  borderRadius: 1,
                  background: "darkred",
                  width: "100%",
                  height: "100%",
                  color: "white",
                  display: "flex",
                  justifyContent: "center",
                  alignItems: "center",
                  "&:hover": {
                    background: "red", // change to the desired background color on hover
                  },
                }}
                onClick={() => {
                  setLoading(true);
                  declineProfessional(professional, callbackAcceptDecline);
                }}
              >
                Refuser
              </Box>
            </Grid>
          </Grid>
        ))
      ) : (
        <Text>No Results</Text>
      )}
      <PopoverWindow
        selectedProfessional={selectedProfessional}
      ></PopoverWindow>
    </Box>
  );
}
