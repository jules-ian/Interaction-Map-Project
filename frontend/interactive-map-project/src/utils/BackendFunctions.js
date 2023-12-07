import InitGetter from "../Components/InitGetter";
import axios from "axios";
import { dummyProf } from "./Entities";

export function getAllMissions(setReturn) {
  let url = "https://localhost:7212/api/field-of-intervention/mission/all";
  axios
    .get(url)
    .then((response) => {
      console.log(response.data);
      setReturn(response.data);
    })
    .catch((error) => {
      console.error("Error fetching data:", error);
    });
}

export function getAllAudiences(setReturn) {
  let url = "https://localhost:7212/api/field-of-intervention/audience/all";
  axios
    .get(url)
    .then((response) => {
      console.log(response.data);
      setReturn(response.data);
    })
    .catch((error) => {
      console.error("Error fetching data:", error);
    });
}

export function getAllPlacesOfIntervention(setReturn) {
  let url =
    "https://localhost:7212/api/field-of-intervention/place-of-intervention/all";
  axios
    .get(url)
    .then((response) => {
      console.log(response.data);
      setReturn(response.data);
    })
    .catch((error) => {
      console.error("Error fetching data:", error);
    });
}

export function getResults() {
  let results = [];
  let randomNumberOfResults = Math.round(Math.random() * 10) + 1;
  for (let i = 0; i < randomNumberOfResults; i++) {
    results.push(dummyProf);
  }
  return results;
}

export function getResultsSearch(
  postalCode,
  audiencesIDs,
  placesOfInterventionIDs,
  missionIDs,
  setResults
) {
  let data = {};
  if (!postalCode === "") {
    data.postalCode = postalCode;
  }
  if (!audiencesIDs.length == 0) {
    data.audiences = audiencesIDs;
  }
  if (!missionIDs.length == 0) {
    data.missions = missionIDs;
  }
  if (!placesOfInterventionIDs.length == 0) {
    data.placesOfIntervention = placesOfInterventionIDs;
  }
  console.log(data);

  // let url =
  //   "https://localhost:7212/api/field-of-intervention/place-of-intervention/10";
  // axios
  //   .delete(url)
  //   .then((response) => console.log(response.data))
  //   .catch((error) => {
  //     console.error("Error sending post for search:", error);
  //   });
  let url = "https://localhost:7212/api/professional/all-filtered";
  axios
    .post(url, [])
    .then((response) => console.log(response.data))
    .catch((error) => {
      console.error("Error sending post for search:", error);
    });
}
