import InitGetter from "../Components/InitGetter";
import axios from "axios";

export function getMissions() {
  return [
    "Accueil de loisirs",
    "Petite enfance",
    "Répit",
    "Accueil occasionnel",
    "Scolarité",
    "Référent santé accueil inclusif (RSAI)",
  ];
}

export function getAudiences() {
  return ["0-3 ans", "3-6 ans", "6-12 ans", "12-18 ans", "parents"];
}

export function getPlacesOfIntervention(setReturn) {
  let API =
    "https://localhost:7212/api/field-of-intervention/place-of-intervention/all";
  let label = "placesOfIntervention";
  axios
    .get(API)
    .then((response) => {
      // Extracting names from response.data
      const extractedNames = response.data.map((item) => item.name);
      console.log(extractedNames);
      console.log(response.data);
      setReturn(extractedNames);
    })
    .catch((error) => {
      console.error("Error fetching data:", error);
    });
}

export function getResults() {
  return [];
}
