import { dummyProf } from "./Entities";

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

export function getPlacesOfIntervention() {
  return ["domicile", "EAJE", "école", "cabinet"];
}

// returns an array of Professionals
export function getResults() {
  let results = [];
  let randomNumberOfResults = Math.round(Math.random() * 10) + 1;
  for (let i = 0; i < randomNumberOfResults; i++) {
    results.push(dummyProf);
  }
  return results;
}
