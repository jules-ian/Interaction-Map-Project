import { Box, Grid, Button } from "@mui/material";
import DropMultiSelect from "../Components/DropMultiSelect";
import { Text, Header } from "../Components/Label";
import { useEffect, useState } from "react";
import TextInput from "../Components/TextInput";
import {
    addNewProfessional,
    getAllAudiences,
    getAllMissions,
    getAllPlacesOfIntervention,
} from "../utils/BackendFunctions";
import {
    isEmail,
    isName,
    isPostalCode,
    isTelephoneNumber,
} from "../utils/checkFunctions";
import { Address, ContactPerson, Professional } from "../utils/Entities";
import { mapNamesToIDs } from "../utils/ArrayFunctions";
import { useNavigate } from "react-router-dom";
import { useTranslation } from "react-i18next";
import { ErrorDialog, SuccessDialog } from "../Components/AlertDialog";
import { PopUpDialogEditProfil } from "../Components/AlertDialog";


export default function EditProfil({ setMenuTitel }) {
    const { t } = useTranslation();
    setMenuTitel(t("common.myAccount"));
    //phase d'initialisation
    const [name, setName] = useState("");
    const [nameError, setNameError] = useState(false);
    const [establishmentType, setEstablishmentType] = useState("");
    const [establishmentTypeError, setEstablishmentTypeError] = useState(false);
    const [managementType, setManagementType] = useState("");
    const [managementTypeError, setManagementTypeError] = useState(false);
    const [telephone, setTelephone] = useState("");
    const [telephoneError, setTelephoneError] = useState(false);
    const [street, setStreet] = useState("");
    const [streetError, setStreetError] = useState(false);
    const [city, setCity] = useState("");
    const [cityError, setCityError] = useState(false);
    const [postal, setPostal] = useState("");
    const [postalError, setPostalError] = useState(false);
    const [mail, setMail] = useState("");
    const [mailError, setMailError] = useState(false);
    const [contactPersonName, setContactPersonName] = useState("");
    const [contactPersonNameError, setContactPersonNameError] = useState(false);
    const [contactPersonTelephone, setContactPersonTelephone] = useState("");
    const [contactPersonTelephoneError, setContactPersonTelephoneError] =
        useState(false);
    const [contactPersonEmail, setContactPersonEmail] = useState("");
    const [contactPersonEmailError, setContactPersonEmailError] = useState(false);
    const [contactPersonFunction, setContactPersonFunction] = useState("");
    const [contactPersonFunctionError, setContactPersonFunctionError] =
        useState(false);
    const [audiences, setAudiences] = useState([]);
    const [audiencesSelection, setAudiencesSelection] = useState([]);
    const [audiencesSelectionError, setAudiencesSelectionError] = useState(false);
    const [missions, setMissions] = useState([]);
    const [missionsSelection, setMissionsSelection] = useState([]);
    const [missionsSelectionError, setMissionsSelectionError] = useState(false);
    const [placesOfIntervention, setPlacesOfIntervention] = useState([]);
    const [placesOfInterventionSelection, setPlacesOfInterventionSelection] =
        useState([]);
    const [
        placesOfInterventionSelectionError,
        setPlacesOfInterventionSelectionError,
    ] = useState(false);
    const [description, setDescription] = useState("");
    const [descriptionError, setDescriptionError] = useState(false);
    const [accept, setAccept] = useState(false);
    const [acceptError, setAcceptError] = useState(false);
    const navigate = useNavigate();

    // Fenêtres pop-up
    const successMessage = t("form.successMessage");
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
        let valid = checkEntries();
        if (!valid) { //A détailler, plusieurs types d'erreurs possibles
            setErrorMessage(t("form.errorMessageFE"));
            setOpenErrorDialog(true);
            return;
        }
        if (valid) {
            const callback = function (success, errorMessage = "") {
                if (success) {
                    setOpenSuccessDialog(true);
                } else {
                    setErrorMessage(t("form.errorMessageFE"));
                    setOpenErrorDialog(true);
                }
            };
            let professional = createProfessinalEntitiy();
            console.log(professional.toJSON());
            addNewProfessional(professional, callback);
        }
    };

    const checkEntries = function () { //todo : différencier les types de forms invalides
        let checkSuccess = true;
        // Name
        if (!isName(name)) {
            setNameError(true);
            checkSuccess = false;
        }
        // Establishment Type
        if (!isName(establishmentType)) {
            setEstablishmentTypeError(true);
            checkSuccess = false;
        }
        // Management Type
        if (!isName(managementType)) {
            setManagementTypeError(true);
            checkSuccess = false;
        }
        // Telephonenumber
        if (!isTelephoneNumber(telephone)) {
            setTelephoneError(true);
            checkSuccess = true;
        }
        // Streetname
        if (!isName(street)) {
            setStreetError(true);
            checkSuccess = false;
        }
        // City
        if (!isName(city)) {
            setCityError(true);
            checkSuccess = false;
        }
        // PostalCode
        if (!isPostalCode(postal)) {
            setPostalError(true);
            checkSuccess = false;
        }
        // Mail
        if (!isEmail(mail)) {
            setMailError(true);
            checkSuccess = false;
        }
        // Name Contact Person
        if (!isName(contactPersonName)) {
            setContactPersonNameError(true);
            checkSuccess = false;
        }
        // Telephone Contact Person
        if (!isTelephoneNumber(contactPersonTelephone)) {
            setContactPersonTelephoneError(true);
            checkSuccess = false;
        }
        // Mail Contact Person
        if (!isEmail(contactPersonEmail)) {
            setContactPersonEmailError(true);
            checkSuccess = false;
        }
        // Function Contact Person
        if (!isName(contactPersonFunction)) {
            setContactPersonFunctionError(true);
            checkSuccess = false;
        }
        //Audiences
        if (audiencesSelection.length === 0) {
            setAudiencesSelectionError(true);
            checkSuccess = false;
        }
        //Missions
        if (missionsSelection.length === 0) {
            setMissionsSelectionError(true);
            checkSuccess = false;
        }
        //PlaceOfInterventions
        if (placesOfInterventionSelection.length === 0) {
            setPlacesOfInterventionSelectionError(true);
            checkSuccess = false;
        }
        // Description
        if (!isName(description)) {
            setDescriptionError(true);
            checkSuccess = false;
        }
        // Accepted Licence
        if (!accept) {
            setAcceptError(true);
            checkSuccess = false;
        }
        return checkSuccess;
    };

    const createProfessinalEntitiy = function () {
        let audiencesIDs = mapNamesToIDs(audiencesSelection, audiences);
        let placesOfInterventionIDs = mapNamesToIDs(
            placesOfInterventionSelection,
            placesOfIntervention
        );

        let missionsIDS = mapNamesToIDs(missionsSelection, missions);
        const address = new Address(street, city, postal);
        const contactPerson = new ContactPerson(
            contactPersonName,
            contactPersonTelephone,
            contactPersonEmail,
            contactPersonFunction
        );

        const professional = new Professional(
            null,
            name,
            establishmentType,
            managementType,
            address,
            telephone,
            null,
            mail,
            contactPerson,
            audiencesIDs,
            placesOfInterventionIDs,
            missionsIDS,
            description
        );
        console.log(professional);
        return professional;
    };

    const [openPopUpDialogEditProfil, setOpenPopUpDialogEditProfil] = useState(false);
    const onClosePopUpDialogEditProfil = function () {
        setOpenPopUpDialogEditProfil(false);
    };

    const catergoryHeaderProps = {
        textAlign: "left",
        marginLeft: -2,
        borderBottom: "2px solid lightblue",
    };

    let professional = new Professional(null, "Crèche de Ramonville", "Garde d'enfants", "public", new Address("5, avenue de Rangueil", "Ramonville", "31240"), "0987654321", null, "creche@ramonville.fr", new ContactPerson("Pilar", "0706050403", "pilar@insa.fr", "directrice"), "3-10 ans", "crèche", "garde d'enfants", "La crèche de Ramonville peut accueillir jusqu'à 48 enfants", "");

    return (
        <Box>
            <PopUpDialogEditProfil
                onClose={onClosePopUpDialogEditProfil}
                open={openPopUpDialogEditProfil}
            />
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
            <Box sx={{ textAlign: "left", margin: 5 }}>
                <Header>{t("profil.edit")}</Header>

            </Box>
            <Grid paddingX={10} container spacing={2}>
                <Grid item xs={12}>
                    <Text sx={catergoryHeaderProps}>{t("form.subHeaderStructure")}</Text>

                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={nameError}
                        defaultValue={professional.name}
                        setTextState={setName}
                        setErrorState={setNameError}
                        label={t("professional.name")}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={establishmentTypeError}
                        defaultValue={professional.establishmentType}
                        setTextState={setEstablishmentType}
                        setErrorState={setEstablishmentTypeError}
                        label={t("common.typeOf") + " " + t("professional.establishment")}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={managementTypeError}
                        defaultValue={professional.managementType}
                        setTextState={setManagementType}
                        setErrorState={setManagementTypeError}
                        label={t("common.typeOf") + " " + t("professional.management")}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={telephoneError}
                        defaultValue={professional.phoneNumber}
                        setTextState={setTelephone}
                        setErrorState={setTelephoneError}
                        label={t("professional.phoneNumber")}
                        helperText={t("form.helperText.phoneNumber")}
                    />
                </Grid>

                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={streetError}
                        defaultValue={professional.address.street}
                        setTextState={setStreet}
                        setErrorState={setStreetError}
                        label={t("professional.address.street")}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={cityError}
                        defaultValue={professional.address.city}
                        setTextState={setCity}
                        setErrorState={setCityError}
                        label={t("professional.address.city")}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={postalError}
                        defaultValue={professional.address.postalCode}
                        setTextState={setPostal}
                        setErrorState={setPostalError}
                        label={t("professional.address.postalCode")}
                    />
                </Grid>

                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={mailError}
                        defaultValue={professional.email}
                        setTextState={setMail}
                        setErrorState={setMailError}
                        label={t("professional.email")}
                    />
                </Grid>
                <Grid item xs={12}>
                    <Text sx={catergoryHeaderProps}>{t("form.subHeaderPerson")}</Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={contactPersonNameError}
                        defaultValue={professional.contactPerson.name}
                        setTextState={setContactPersonName}
                        setErrorState={setContactPersonNameError}
                        label={t("professional.contactPerson.name")}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={contactPersonTelephoneError}
                        defaultValue={professional.contactPerson.phoneNumber}
                        setTextState={setContactPersonTelephone}
                        setErrorState={setContactPersonTelephoneError}
                        label={t("professional.contactPerson.phoneNumber")}
                        helperText={t("form.helperText.phoneNumber")}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={contactPersonEmailError}
                        defaultValue={professional.contactPerson.email}
                        setTextState={setContactPersonEmail}
                        setErrorState={setContactPersonEmailError}
                        label={t("professional.contactPerson.email")}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <TextInput
                        error={contactPersonFunctionError}
                        defaultValue={professional.contactPerson._function}
                        setTextState={setContactPersonFunction}
                        setErrorState={setContactPersonFunctionError}
                        label={t("professional.contactPerson._function")}
                    />
                </Grid>
                <Grid item xs={12}>
                    <Text sx={catergoryHeaderProps}>
                        {t("form.subHeaderFieldsOfIntervention")}
                    </Text>
                </Grid>
                <Grid item xs={12} sm={6}>
                    <DropMultiSelect
                        options={audiences.map((item) => item.name)}
                        error={audiencesSelectionError}
                        setSelectionState={setAudiencesSelection}
                        setErrorState={setAudiencesSelectionError}
                        label={t("professional.audiences") + " (plusieurs choix possibles)"}
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <DropMultiSelect
                        options={placesOfIntervention.map((item) => item.name)}
                        error={placesOfInterventionSelectionError}
                        setSelectionState={setPlacesOfInterventionSelection}
                        setErrorState={setPlacesOfInterventionSelectionError}
                        label={
                            t("professional.placesOfIntervention") +
                            " (plusieurs choix possibles)"
                        }
                    />
                </Grid>
                <Grid item xs={12} sm={6}>
                    <DropMultiSelect
                        options={missions.map((item) => item.name)}
                        error={missionsSelectionError}
                        setSelectionState={setMissionsSelection}
                        setErrorState={setMissionsSelectionError}
                        label={t("professional.missions") + " (plusieurs choix possibles)"}
                    />
                </Grid>

                <Grid item xs={12}>
                    <Text sx={catergoryHeaderProps}>{t("form.description")}</Text>
                </Grid>
                <Grid item xs={12}>
                    <TextInput
                        error={descriptionError}
                        defaultValue={professional.description}
                        setTextState={setDescription}
                        setErrorState={setDescriptionError}
                        label={t("professional.description")}
                        multiline={true}
                    />
                </Grid>

                <Grid item xs={12}>
                    <Button
                        variant="contained"
                        fullWidth={true}
                        onClick={onSubmit}
                    >
                        {t("common.submitUpdate")}
                    </Button>
                </Grid>
            </Grid>
        </Box >
    );
}
