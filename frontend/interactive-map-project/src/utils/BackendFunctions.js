import InitGetter from "../Components/InitGetter";

export function getZoneGeographique() {
  return ["Haute-Garonne", "Ariège", "Aude", "Portet Garonne"];
}

export function getMission() {
  return [
    "Accueil de loisirs",
    "Petite enfance",
    "Répit",
    "Accueil occasionnel",
    "Scolarité",
    "Référent santé accueil inclusif (RSAI)",
  ];
}

export function getPublic() {
  return ["0-3 ans", "3-6 ans", "6-12 ans", "12-18 ans", "parents"];
}

export function getLieuIntervention() {
  return InitGetter(
    "https://localhost:7212/api/field-of-intervention/place-of-intervention/all"
  );
}
