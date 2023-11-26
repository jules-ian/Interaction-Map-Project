import { Box, Grid, Button } from "@mui/material"
import DropMultiSelect from "../Components/DropMultiSelect"
import { Text, Header} from "../Components/Label"
import InputComponent from "../Components/InputComponent"
import { useState } from "react"
import TextInput from "../Components/TextInput"
import { getLieuIntervention, getMission, getPublic } from "../utils/BackendFunctions"
import { SingleCheckbox } from "../Components/Checkbox"

export default function Form(){
    const [structure, setStructure] = useState("")
    const [postale, setPostale] = useState("")
    const [service, setService] = useState("")
    const [telephone, setTelephone] = useState("")
    const [mail, setMail] = useState("")
    const [gestionnaire, setGestionnaire] = useState("")
    const [personneResource, setPersonneResource] = useState("")
    const [telephonePersonneRessource, setTelephonePersonneRessource] = useState("")
    const [_function, set_Function] = useState("")
    const [adressePersonneRessource, setadressePersonneRessource] = useState("")
    const [mission, setMission] = useState(getMission())
    const [_public, set_Public] = useState(getPublic())
    const [sectuerIntervention, setSectuerIntervention] = useState([])
    const [lieuIntervention, setLieuIntervention] = useState(getLieuIntervention())
    const [presentation, setPresentation] = useState("")
    const [accept, setAccept] = useState(false)
    
    return(
        <Box>
            <Header>Veuillez remplir le formulaire suivant.</Header>
            <Text>Avec une inscription confirmée, vous entrez dans notre service de recherche et d'identification dans le domaine professionnel des handicaps de la petite enfance.</Text>
            
                <Grid padding={2} paddingX={10} container spacing={2}>
                    <Grid item xs={12}>
                        <Text>Information de votre structure</Text>
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={structure} setTextState={setStructure} label="Nom de la structure" />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={postale} setTextState={setPostale} label="Adresse postale" />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={service} setTextState={setService} label="Service" />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={telephone} setTextState={setTelephone} label="Numero télephone" />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={mail} setTextState={setMail} label="Mail" />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={gestionnaire} setTextState={setGestionnaire} label="Gestionnaire" />
                    </Grid>
                    <Grid item xs={12}>
                        <Text>Information de la personne ressource</Text>
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={personneResource} setTextState={setPersonneResource} label="Nom, prénom de la personne ressource" />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={_function} setTextState={set_Function} label="Function" />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={telephonePersonneRessource} setTextState={setTelephonePersonneRessource} label="Numéro de téléphone de la personne ressource" />
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <TextInput textState={adressePersonneRessource} setTextState={setadressePersonneRessource} label="Adresse mail de la personne ressource" />
                    </Grid>
                    <Grid item xs={12}>
                        <Text>Champs d'intervention</Text>
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <DropMultiSelect optionsState={mission} setOptionsState={setMission} label={"Mission (pusieur choix possible)"}/>
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <DropMultiSelect optionsState={_public} setOptionsState={set_Public} label={"public (pusieur choix possible)"}/>
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <DropMultiSelect label={"TODO"}/>
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <DropMultiSelect optionsState={lieuIntervention} setOptionsState={setLieuIntervention} label={"lieu d'intervention(pusieur choix possible)"}/>
                    </Grid>
                    <Grid item xs={12}>
                        <Text>Présentation personnalisée de vos missions</Text>
                    </Grid>
                    <Grid item xs={12}>
                        <TextInput textState={presentation} setTextState={setPresentation} multiline={true} />
                    </Grid>
                    <Grid item xs={12}>
                        <Text>Accepter Licence</Text>
                    </Grid>
                    <Grid item xs={12} sm={6}>
                        <SingleCheckbox stateCheck={accept} setStateCheck={setAccept} label={"J'accepte d'apparître sur le répoire de partenaires du réseau d'Accueil pour tous et ainsi d'être solicité si besoin en tant que personne ressource."}/>
                    </Grid>
                    <Grid item xs={12}>
                        <Button variant="contained" fullWidth={true} 
                            onClick={() =>{}}>
                            Submit
                        </Button>
                    </Grid>
                </Grid>
        </Box>
        
    )
}
