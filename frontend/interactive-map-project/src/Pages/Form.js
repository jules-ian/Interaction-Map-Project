import { Box, Grid, Button, } from "@mui/material";
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
import { SingleCheckbox } from "../Components/Checkbox";
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

export default function Form({ setMenuTitel }) {
  const { t } = useTranslation();
  setMenuTitel(t("page.form"));
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
      const callback = function (success) {
        if (success) {
          setOpenSuccessDialog(true);
        } else {
          setErrorMessage(t("form.errorMessageDB"));

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

  const catergoryHeaderProps = {
    textAlign: "left",
    marginLeft: -2,
    borderBottom: "2px solid lightblue",
  };
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
      <Box sx={{ padding: 5 }}>
        <Header>{t("form.header")}</Header>
        <Text>{t("form.descriptionOfForm")}</Text>
      </Box>
      <Grid paddingX={10} container spacing={2}>
        <Grid item xs={12}>
          <Text sx={catergoryHeaderProps}>{t("form.subHeaderStructure")}</Text>
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={nameError}
            setTextState={setName}
            setErrorState={setNameError}
            label={t("professional.name")}
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={establishmentTypeError}
            setTextState={setEstablishmentType}
            setErrorState={setEstablishmentTypeError}
            label={t("common.typeOf") + " " + t("professional.establishment")}
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={managementTypeError}
            setTextState={setManagementType}
            setErrorState={setManagementTypeError}
            label={t("common.typeOf") + " " + t("professional.management")}
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={telephoneError}
            setTextState={setTelephone}
            setErrorState={setTelephoneError}
            label={t("professional.phoneNumber")}
            helperText={t("form.helperText.phoneNumber")}
          />
        </Grid>

        <Grid item xs={12} sm={6}>
          <TextInput
            error={streetError}
            setTextState={setStreet}
            setErrorState={setStreetError}
            label={t("professional.address.street")}
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={cityError}
            setTextState={setCity}
            setErrorState={setCityError}
            label={t("professional.address.city")}
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={postalError}
            setTextState={setPostal}
            setErrorState={setPostalError}
            label={t("professional.address.postalCode")}
          />
        </Grid>

        <Grid item xs={12} sm={6}>
          <TextInput
            error={mailError}
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
            setTextState={setContactPersonName}
            setErrorState={setContactPersonNameError}
            label={t("professional.contactPerson.name")}
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={contactPersonTelephoneError}
            setTextState={setContactPersonTelephone}
            setErrorState={setContactPersonTelephoneError}
            label={t("professional.contactPerson.phoneNumber")}
            helperText={t("form.helperText.phoneNumber")}
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={contactPersonEmailError}
            setTextState={setContactPersonEmail}
            setErrorState={setContactPersonEmailError}
            label={t("professional.contactPerson.email")}
          />
        </Grid>
        <Grid item xs={12} sm={6}>
          <TextInput
            error={contactPersonFunctionError}
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
            setTextState={setDescription}
            setErrorState={setDescriptionError}
            label={t("professional.description")}
            multiline={true}
          />
        </Grid>
        <Grid item xs={12}>
          <SingleCheckbox
            stateCheck={accept}
            error={acceptError}
            setErrorState={setAcceptError}
            setStateCheck={setAccept}
            label={t("form.license")}
          />
        </Grid>

        <div style={{ marginTop: '20px', width: '100%', backgroundColor: '#efffff', height: '400px', paddingLeft: '10px', overflow: 'scroll' }}>
          <h2>Charte des membres du réseau partenarial</h2>
          Le collectif ressources à l’origine d’élaboration de la présente Charte, le réseau partenarial ainsi que la présente Charte sont portés par le pôle ressources Accueil 31.
          Ils s’inscrivent dans la démarche et les valeurs d'Accueil Pour Tous 31 relatifs à l'accueil inclusif qui sont :
          <br />

          <ul>
            <li>Accompagner les parents, et les professionnels afin de favoriser et construire ensemble un accueil collectif ou individuel pour chaque enfant. Quels que soient son environnement, ses besoins, ses différences et ses potentiels, sa singularité, chaque enfant doit pouvoir être accueilli dans les lieux d’accueil.</li>
            <li>Le projet d’accueil de l’enfant se construit grâce à une relation de confiance entre l’enfant, les parents et l’équipe pluri-professionnelle.</li>
            <li>Une démarche de connaissance réciproque, d’échange de savoirs et de savoir-faire, de partage d’expériences permet de mettre en place un accueil de qualité pour chaque enfant.</li>
          </ul>
          <br />

          <h4>La présente Charte du réseau partenarial repose sur les principes suivants :</h4>

          <h6>NOS VALEURS</h6>
          <ul>
            <li>Informer les parents et les professionnels, mutualiser les informations concernant l’ensemble des acteurs du département (éducatifs, médicaux sociaux, institutionnels).</li>
            <li>Faciliter le partage d’expériences et l’échange de pratiques d’accueil d’enfants en situation de handicap.</li>
            <li>Croiser les regards et les réalités des familles et des professionnels afin de définir ensemble un accueil de qualité.</li>
            <li>Soutenir les réflexions et les actions des professionnels visant à améliorer l’accueil de l’enfant en situation de handicap et de sa famille.</li>
            <li>Valoriser les pratiques des lieux d’accueil de la petite enfance.</li>
          </ul>

          <h6>NOS OBJECTIFS</h6>
          <ul>
            <li>Mutualiser des compétences</li>
            <li>Mobiliser et partager les savoir-faire</li>
            <li>Identifier des acteurs complémentaires</li>
            <li>Optimiser l'orientation des familles</li>
            <li>Personnaliser l'accompagnement au plus près des besoins et des attentes</li>
            <li>Être ressource et favoriser les échanges entre les pros</li>
          </ul>

          <h6>NOTRE FONCTIONNEMENT</h6>
          <ul>
            <li>La cooptation et validation par un autre membre du réseau</li>
            <li>La présentation détaillée du nouveau membre grâce à une fiche d'identité complète sur la structure, son domaine d’activité, sa zone géographique, etc</li>
            <li>L’adhésion requise aux objectifs annoncés</li>
            <li>Le respect sur la confidentialité des informations partagées au sein du réseau partenarial</li >
            <li>Le respect sur l’accès privé et professionnel au répertoire des membres du réseau partenarial</li >
            <li>Ne pas utiliser ce réseau comme lieu de promotion de son activité, mais en privilégiant l’intérêt majeur de trouver la réponse la mieux adapté à la demande </li >
          </ul>

          <h6>LES ENGAGEMENTS </h6>
          <ul>
            <li>Remplir la fiche d'identité de l'établissement ou de l'institution</li>
            <li>Définir une personne / un service ressource au sein de l'institution après validation de la direction</li>
            <li>Actualiser les informations administratives lorsqu’il y a des changements</li>
            <li>Alimenter le répertoire en partageant des informations auprès de la personne référente APT</li>
            <li>Mettre en lien, orienter, diriger au - delà du répertoire pour favoriser le tissage, dans l’intérêt majeur de trouver une réponse la plus adapté à la demande de la famille et / ou du professionnel</li>
            <li>Respecter les projets des familles dans les choix d'orientation</li>
            <li>Ne pas diffuser le répertoire directement aux familles ni aux professionnels ou structures n’ayant pas accepté et signée la présente charte</li>
            <li>S'inscrire dans la complémentarité sans promouvoir son activité</li>
            <li>Accepter d'être sollicité par les partenaires ayant accès au répertoire réseau partenarial</li>
            <li>Engagement tacite du nouveau membre concernant le partage des objectifs, du fonctionnement et des engagements par signature de la présente charte</li>
          </ul>

          < SingleCheckbox
            stateCheck={accept}
            error={acceptError}
            setErrorState={setAcceptError}
            setStateCheck={setAccept}
            label={t("form.charter")}
          />

        </div >

        <Grid item xs={12}>
          <Button variant="contained" fullWidth={true} onClick={onSubmit}>
            {t("common.submit")}
          </Button>
        </Grid>
      </Grid >
    </Box >
  );
}
