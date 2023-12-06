import InitGetter from "../Components/InitGetter";
import axios from "axios";

export function getMissions(setReturn) {
  let API = "https://localhost:7212/api/field-of-intervention/mission/all";
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

export function getAudiences(setReturn) {
  let API = "https://localhost:7212/api/field-of-intervention/audience/all";
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

export function getPlacesOfIntervention(setReturn) {
  let API =
    "https://localhost:7212/api/field-of-intervention/place-of-intervention/all";
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
