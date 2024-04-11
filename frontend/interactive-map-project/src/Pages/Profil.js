
import { Box, Grid, Button } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Text } from "../Components/Label";
import { Address, ContactPerson, Professional } from "../utils/Entities";
import { useEffect, useState } from "react";
import TextInput from "../Components/TextInput";
import {
    getInfosProfessionals,
    getAllAudiences,
    getAllMissions,
    getAllPlacesOfIntervention,
} from "../utils/BackendFunctions";
import { useTranslation } from "react-i18next";
import { ErrorDialog, SuccessDialog } from "../Components/AlertDialog";

export default function Profil({ setMenuTitel, email }) { //todo : uId
    const { t } = useTranslation();
    setMenuTitel(t("common.myAccount"));
    const [audiences, setAudiences] = useState([]);
    const [audiencesSelection, setAudiencesSelection] = useState([]);
    const [missions, setMissions] = useState([]);
    const [missionsSelection, setMissionsSelection] = useState([]);
    const [placesOfIntervention, setPlacesOfIntervention] = useState([]);
    const [
        placesOfInterventionSelectionError,
        setPlacesOfInterventionSelectionError,
    ] = useState(false);
    const [description, setDescription] = useState("");
    const navigate = useNavigate();

    // Fenêtres pop-up
    const successMessage = t("profil.successMessage");
    const [openSuccessDialog, setOpenSuccessDialog] = useState(false);
    const onCloseSuccessDialog = function () {
        setOpenSuccessDialog(false);
        navigate("/Home", { replace: true });
    };

    const [errorMessage, setErrorMessage] = useState("");
    const [openErrorDialog, setOpenErrorDialog] = useState(false);
    const onCloseErrorDialog = function () {
        setOpenErrorDialog(false);
    };

    // on first render
    useEffect(() => {
        getAllPlacesOfIntervention(setPlacesOfIntervention);
        getAllMissions(setMissions);
        getAllAudiences(setAudiences);
    }, []);

    const onSubmit = function () {

    };

    const catergoryHeaderProps = {
        textAlign: "left",
        marginTop: 3,
        marginLeft: -2,
        fontSize: '25px',
        borderBottom: "2px solid lightblue",
    };

    const catergorySubHeaderProps = {
        textAlign: "left",
        marginLeft: -2,
    };

    const catergoryInfoProps = {
        textAlign: "left",
        marginLeft: -2,
        fontSize: '17px',
        color: 'gray',
    };

    //let professional = getInfosProfessionals({ email });
    let professional = new Professional(null, "Crèche de Ramonville", "Garde d'enfants", "public", new Address("5, avenue de Rangueil", "Ramonville", "31240"), "0987654321", null, email, new ContactPerson("Pilar", "0706050403", "pilar@insa.fr", "directrice"), "3-10 ans", "crèche", "garde d'enfants", "La crèche de Ramonville peut accueillir jusqu'à 48 enfants", "");


    return (
        <Box>
            <SuccessDialog
                message={successMessage}
                onClose={onCloseSuccessDialog}
                open={openSuccessDialog}
            />
            <ErrorDialog
                message={errorMessage}
                onClose={onCloseErrorDialog}
                open={openErrorDialog}
            />
            <Grid paddingX={10} container spacing={2}>
                <Grid item xs={12}>
                    <Text sx={catergoryHeaderProps}>{t("form.subHeaderStructure")}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.name")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.name}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("common.typeOf") + " " + t("professional.establishment")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.establishmentType}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("common.typeOf") + " " + t("professional.management")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.managementType}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps} helperText={t("form.helperText.phoneNumber")}>{t("professional.phoneNumber")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.phoneNumber}</Text>
                </Grid>

                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.address.street")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.address.street}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.address.city")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.address.city}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.address.postalCode")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.address.postalCode}</Text>
                </Grid>

                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.email")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.email}</Text>
                </Grid>
                <Grid item xs={12}>
                    <Text sx={catergoryHeaderProps}>{t("form.subHeaderPerson")}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.contactPerson.name")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.contactPerson.name}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps} helperText={t("form.helperText.phoneNumber")}>{t("professional.contactPerson.phoneNumber")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.contactPerson.phoneNumber}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.contactPerson.email")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.contactPerson.email}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.contactPerson._function")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.contactPerson._function}</Text>
                </Grid>
                <Grid item xs={12}>
                    <Text sx={catergoryHeaderProps}>
                        {t("form.subHeaderFieldsOfIntervention")}
                    </Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.audiences")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.audiences}</Text>
                    {/* TODO : revoir les print */}
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.placesOfIntervention")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.placesOfIntervention}</Text>
                    {/* TODO : revoir les print */}
                </Grid>
                <Grid item xs={12} sm={6}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.missions")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.missions}</Text>
                    {/* TODO : revoir les print */}
                </Grid>

                <Grid item xs={12}>
                    <Text sx={catergoryHeaderProps}>{t("form.description")}</Text>
                </Grid>
                <Grid item xs={12}>
                    <Text sx={catergorySubHeaderProps}>{t("professional.description")}</Text>
                    <Text sx={catergoryInfoProps}>{professional.description}</Text>
                </Grid>
            </Grid>
        </Box>
    );
}