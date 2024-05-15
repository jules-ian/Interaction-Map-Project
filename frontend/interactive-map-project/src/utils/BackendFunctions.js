import axios from "axios";
import {
  professionalFromJSON,
  tokenFromJSON,
  Identifiants,
  Token
} from "./Entities";
import { tokenUser } from "../App";

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
  console.log("pro = ", professional);
  console.log("id = ", professional.id);

  let url =
    "https://localhost:7212/api/professional/validate/" + professional.id;

  const data = { approve: true };
  axios
    .post(url, data, {
      headers: {
        "Content-Type": "application/json",
        'Authorization': `Bearer ${tokenUser.token}`
      },
    })
    .then(() => {
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
    .delete(url, { headers: { 'Authorization': `Bearer ${tokenUser.token}` } })
    .then(() => {
      console.log(professional.name + " was deleted");
      callback();
    })
    .catch((error) => {
      console.error("Error deleting Professional:", error.response);
      callback();
    });
}

export function checkIdentifiants(mail, password, setReturn) {
  let id = new Identifiants(mail, password);
  let url = "https://localhost:7212/api/account/login";
  axios
    .post(url, id.toJSON())
    .then((response) => {
      let tok = tokenFromJSON(response.data);
      setReturn(tok);
    })
    .catch((error) => {
      console.log("Error due to wrong id:", error);
      setReturn(null);
    });
}

export function getUnapprovedProfessionals(setResults) {
  let url = "https://localhost:7212/api/professional/pending/all";
  axios
    .get(url, { headers: { 'Authorization': `Bearer ${tokenUser.token}` } })
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

export function getInfosProfessionals() {
  let url = "https://localhost:7212/api/account/professional/info";
  console.log("A la recherche des infos du professional", tokenUser.token);
  axios
    .get(url, { headers: { 'Authorization': `Bearer ${tokenUser.token}` } })
    .then((response) => {
      return (professionalFromJSON(response.data));
    })
    .catch((error) => {
      console.error("Error getting professionnal information:", error);
    });
}

export function addEditedProfessional(professional, callback) {
  let url = "https://localhost:7212/api/modification";

  axios
    .post(url, professional.toJSON(), { headers: { 'Authorization': `Bearer ${tokenUser.token}` } })
    .then((response) => {
      console.log(response);
      callback(true);
    })
    .catch((error) => {
      console.error("Error Posting Professional Modifications:", error.response);
      callback(false, error.response);
    });
}

export function approveModification(professional, callback) {
  let url =
    "https://localhost:7212/api/modification/validate/" + professional.id;
  const data = { approve: true };
  axios
    .post(url, data, {
      headers: {
        "Content-Type": "application/json",
        'Authorization': `Bearer ${tokenUser.token}`
      }
    },
    )
    .then(() => {
      console.log(professional.name + "'s modifications were approved");
      callback();
    })
    .catch((error) => {
      console.error("Error approving modifications of professional:", error.response);
      callback();
    });
}

export function declineModification(professional, callback) {
  let url =
    "https://localhost:7212/api/modification/pending/" + professional.id;
  axios
    .delete(url, { headers: { 'Authorization': `Bearer ${tokenUser.token}` } })
    .then((response) => {
      console.log(professional.name + "'s modifications were refused");
      callback();
    })
    .catch((error) => {
      console.error("Error refusing modifications of professional:", error.response);
      callback();
    });
}

export function getEditedProfessionals(setResults) {
  let url = "https://localhost:7212/api/modification/pending/all";
  axios
    .get(url, { headers: { 'Authorization': `Bearer ${tokenUser.token}` } })
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

export function getToken(tok) {
  if (tok === null) {
    return new Token(null, null);
  }
  var base64Url = tok.token.split('.')[1];
  var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
  var jsonPayload = decodeURIComponent(window.atob(base64).split('').map(function (c) {
    return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
  }).join(''));
  const role = JSON.parse(jsonPayload)['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'];
  const ex = JSON.parse(jsonPayload).exp;

  return new Token(role, ex);
}

export function getResultsSearch(
  setResults,
  textSearch = "",
  audiencesIDs = [],
  placesOfInterventionIDs = [],
  missionIDs = [],
  mapBounds
) {
  let data = {};
  console.log("text search = ", textSearch);
  if (textSearch.length !== 0) {
    console.log("data text not empty");
    data.text = textSearch;
  }
  if (audiencesIDs.length !== 0) {
    console.log("data aud not empty");
    data.audiences = audiencesIDs;
  }
  if (missionIDs.length !== 0) {
    console.log("data mission not empty");
    data.missions = missionIDs;
  }
  if (placesOfInterventionIDs.length !== 0) {
    console.log("data places not empty");
    data.placesOfIntervention = placesOfInterventionIDs;
  }

  console.log("Data send to backend on search");
  console.log(data);

  let url = "https://localhost:7212/api/professional/approved/filtered";
  axios
    .post(url, data, {
      headers: {
        "Content-Type": "application/json",
        'Authorization': `Bearer ${tokenUser.token}`
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
