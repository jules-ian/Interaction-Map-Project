import { Box, CircularProgress, Grid } from "@mui/material";
import { useNavigate } from "react-router-dom";
import useWindowDimensions from "../utils/windowDimension";
import { Header, Text } from "../Components/Label";
import { useEffect, useState } from "react";
import {
  getUnapprovedProfessionals,
} from "../utils/BackendFunctions";
import { PopoverWindow } from "../Components/PopoverWindow";
import { useTranslation } from "react-i18next";
import { PopUpAdminValidateDialog, PopUpAdminDeclineDialog } from "../Components/AlertDialog";
import {
  approveProfessional,
  declineProfessional,
} from "../utils/BackendFunctions";

export default function Admin({ setMenuTitel }) {
  const { t } = useTranslation();
  setMenuTitel(t("page.admin"));
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();
  const [unapprovedProfessionals, setUnapprovedProfessionals] = useState([]);
  const [selectedProfessional, setSelectedProfessional] = useState(null);
  const [openPopover, setOpenPopover] = useState(false);
  const [loading, setLoading] = useState(false);


  useEffect(() => {
    getUnapprovedProfessionals(setUnapprovedProfessionals);
  }, []);

  const callbackAcceptDecline = function () {
    getUnapprovedProfessionals(setUnapprovedProfessionals);
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
        <Box>
          <Tabel
            unapprovedProfessionals={unapprovedProfessionals}
            openPopover={openPopover}
            setOpenPopover={setOpenPopover}
            setSelectedProfessional={setSelectedProfessional}
            selectedProfessional={selectedProfessional}
            callbackAcceptDecline={callbackAcceptDecline}
            setLoading={setLoading}
          />

          <Tabel
            unapprovedModifications={unapprovedModifications}
            openPopover={openPopover}
            setOpenPopover={setOpenPopover}
            setSelectedProfessional={setSelectedProfessional}
            selectedProfessional={selectedProfessional}
            callbackAcceptDecline={callbackAcceptDecline}
            setLoading={setLoading}
          />
        </Box>
      )}
    </Box>
  );
}

function Tabel({
  unapprovedProfessionals,
  unapprovedModifications,
  openPopover,
  setOpenPopover,
  setSelectedProfessional,
  selectedProfessional,
  callbackAcceptDecline,
  setLoading,
}) {
  const { t } = useTranslation();

  const [openPopUpAdminDeclineDialog, setOpenPopUpAdminDeclineDialog] = useState(false);
  const onClosePopUpAdminDeclineDialog = function () {
    setOpenPopUpAdminDeclineDialog(false);
    setLoading(true);
    declineProfessional(selectedProfessional, callbackAcceptDecline);
  };

  const [openPopUpAdminValidateDialog, setOpenPopUpAdminValidateDialog] = useState(false);
  const onClosePopUpAdminValidateDialog = function () {
    setOpenPopUpAdminValidateDialog(false);
    setLoading(true);
    approveProfessional(selectedProfessional, callbackAcceptDecline);
  };

  const onReturnPopUpAdminDeclineDialog = function () {
    setOpenPopUpAdminDeclineDialog(false);
  };

  const onReturnPopUpAdminValidateDialog = function () {
    setOpenPopUpAdminValidateDialog(false);
  };

  const onDeclineClick = function () {
    setOpenPopUpAdminDeclineDialog(true);
  };

  const onValidateClick = function () {
    setOpenPopUpAdminValidateDialog(true);
  };

  return (
    <Box>
      <PopUpAdminDeclineDialog
        onClose={onClosePopUpAdminDeclineDialog} //TODO : close pop up et c'est tout
        onReturn={onReturnPopUpAdminDeclineDialog}
        open={openPopUpAdminDeclineDialog}
      />
      <PopUpAdminValidateDialog
        onClose={onClosePopUpAdminValidateDialog}
        onReturn={onReturnPopUpAdminValidateDialog}
        open={openPopUpAdminValidateDialog}
      />

      {/*TABLE OF PENDING JOIN*/}
      <Grid container sx={{ marginBottom: 2, alignItems: "center" }}>
        <Grid item xs={8}>
          <Header sx={{ textAlign: "left" }}>{t("admin.unapproved")}</Header>
        </Grid>
      </Grid>
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
                setOpenPopover(true);
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
                onClick={onValidateClick}
              >
                {t("common.accept")}
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
                onClick={onDeclineClick}
              >
                {t("common.decline")}
              </Box>
            </Grid>
          </Grid>
        ))
      ) : (
        <Text> {t("common.noResults")}</Text>
      )}

      <Grid container sx={{ marginBottom: 2, alignItems: "center" }}>
        <Grid item xs={8}>
          <Header sx={{ textAlign: "left" }}>{t("admin.modifications")}</Header>
        </Grid>
      </Grid>

      {/*TABLE OF PENDING MODIFICATIONS*/}
      {unapprovedModifications.length != 0 ? (
        unapprovedModifications.map((professional) => (
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
                setOpenPopover(true);
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
                onClick={onValidateClick}
              >
                {t("common.accept")}
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
                onClick={onDeclineClick}
              >
                {t("common.decline")}
              </Box>
            </Grid>
          </Grid>
        ))
      ) : (
        <Text> {t("common.noResults")}</Text>
      )}

      < PopoverWindow
        setOpenPopover={setOpenPopover}
        openPopover={openPopover}
        selectedProfessional={selectedProfessional}
        setSelectedProfessional={setSelectedProfessional}
      ></PopoverWindow>
    </Box >
  );



}
