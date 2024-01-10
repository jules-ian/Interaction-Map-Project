import InitGetter from "../Components/InitGetter";
import axios from "axios";
import {
  Address,
  ContactPerson,
  GeoLocation,
  Professional,
  dummyProf,
  professionalFromJSON,
} from "./Entities";

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

export function addNewProfessional(professional, callback) {
  let url = "https://localhost:7212/api/professional";

  axios
    .post(url, professional.toJSON())
    .then((response) => {
      console.log(response);
      callback(true);
    })
    .catch((error) => {
      console.error("Error Posting Professional:", error.response);
      callback(false, error.response);
    });
}

export function approveProfessional(professional, callback) {
  let url =
    "https://localhost:7212/api/professional/validate/" + professional.id;
  const data = { approve: true };
  axios
    .post(url, data, {
      headers: {
        "Content-Type": "application/json",
        // Add any other headers if needed
      },
    })
    .then((response) => {
      console.log(professional.name + " was approved");
      callback();
    })
    .catch((error) => {
      console.error("Error approving Professional:", error.response);
      callback();
    });
}

export function declineProfessional(professional, callback) {
  let url =
    "https://localhost:7212/api/professional/pending/" + professional.id;
  axios
    .delete(url)
    .then((response) => {
      console.log(professional.name + " was deleted");
      callback();
    })
    .catch((error) => {
      console.error("Error deleteing Professional:", error.response);
      callback();
    });
}

export function getUnapprovedProfessionals(setResults) {
  let url = "https://localhost:7212/api/professional/pending/all";
  axios
    .get(url)
    .then((response) => {
      let professionals = response.data.map((profData) => {
        return professionalFromJSON(profData);
      });
      setResults(professionals);
    })
    .catch((error) => {
      console.error("Error sending post for search:", error);
    });
}

export function getResultsSearch(
  setResults,
  textSearch = "",
  audiencesIDs = [],
  placesOfInterventionIDs = [],
  missionIDs = []
) {
  let data = {};
  if (!textSearch.length == 0) {
    data.text = textSearch;
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
  console.log("Data send to backend on search");
  console.log(data);

  let url = "https://localhost:7212/api/professional/approved/filtered";
  axios
    .post(url, data, {
      headers: {
        "Content-Type": "application/json",
        // Add any other headers if needed
      },
    })
    .then((response) => {
      let professionals = response.data.map((profData) => {
        return professionalFromJSON(profData);
      });
      setResults(professionals);
    })
    .catch((error) => {
      console.error("Error sending post for search:", error);
    });
}

export function test() {
  let data = {
    name: "string",
    establishmentType: "string",
    managementType: "string",
    address: {
      street: "string",
      city: "string",
      postalCode: "string",
    },
    phoneNumber: "+33772738475",
    email: "stri@ng",
    contactPerson: {
      name: "string",
      function: "string",
      phoneNumber: "+33772738475",
      email: "str@ing",
    },
    audiences: [
      {
        id: "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      },
    ],
    placesOfIntervention: [
      {
        id: "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      },
    ],
    missions: [
      {
        id: "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      },
    ],
    description: "string",
  };

  let url = "https://localhost:7212/api/professional/";
  axios
    .post(url, data, {
      headers: {
        "Content-Type": "application/json",
        // Add any other headers if needed
      },
    })
    .then((response) => {
      console.log("Response: ", response.data);
    })
    .catch((error) => {
      console.error("Error sending post for search:", error);
    });
}
