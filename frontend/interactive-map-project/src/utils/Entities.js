export class Professional {
  constructor(
    id,
    name,
    establishmentType,
    managementType,
    address,
    phoneNumber,
    geolocation,
    email,
    contactPerson,
    audiences = [],
    placesOfIntervention = [],
    missions = [],
    description = null
  ) {
    this.id = id;
    this.name = name;
    this.establishmentType = establishmentType;
    this.managementType = managementType;
    this.address = address;
    this.phoneNumber = phoneNumber;
    this.geolocation = geolocation;
    this.email = email;
    this.contactPerson = contactPerson;
    this.audiences = audiences;
    this.placesOfIntervention = placesOfIntervention;
    this.missions = missions;
    this.description = description;
  }
  toString() {
    return "Professional" + this.serviceName;
  }

  // is for posting a new professional to backend
  toJSON() {
    return {
      name: this.name,
      establishmentType: this.establishmentType,
      managementType: this.managementType,
      address: {
        street: this.address.street,
        city: this.address.city,
        postalCode: this.address.postalCode,
      },
      phoneNumber: this.phoneNumber,
      email: this.email,
      contactPerson: {
        name: this.contactPerson.name,
        function: this.contactPerson._function,
        phoneNumber: this.contactPerson.phoneNumber,
        email: this.contactPerson.email,
      },
      audiences: this.audiences.map((id) => {
        return { id: id };
      }),
      placesOfIntervention: this.placesOfIntervention.map((id) => {
        return { id: id };
      }),
      missions: this.missions.map((id) => {
        return { id: id };
      }),
      description: this.description,
    };
  }
}
export function professionalFromJSON(json) {
  let address = new Address(
    json.address.street,
    json.address.city,
    json.address.postalCode
  );
  let geolocation = new GeoLocation(
    json.geolocation.latitude,
    json.geolocation.longitude
  );
  let contactPerson = new ContactPerson(
    json.contactPerson.name,
    json.contactPerson.phoneNumber,
    json.contactPerson.email,
    json.contactPerson.function
  );
  return new Professional(
    json.id,
    json.name,
    json.establishmentType,
    json.managementType,
    address,
    json.phoneNumber,
    geolocation,
    json.email,
    contactPerson,
    json.audiences.map((tuple) => tuple.name),
    json.placesOfIntervention.map((tuple) => tuple.name),
    json.missions.map((tuple) => tuple.name),
    json.description
  );
}

export class Address {
  constructor(street, city, postalCode) {
    this.street = street;
    this.city = city;
    this.postalCode = postalCode;
  }
}
export class GeoLocation {
  constructor(longitude, latitude) {
    this.longitude = longitude;
    this.latitude = latitude;
  }
}
export class ContactPerson {
  constructor(name, phoneNumber, email, _function) {
    this.name = name;
    this.phoneNumber = phoneNumber;
    this.email = email;
    this._function = _function;
  }
}
export class Identifiants {
  constructor(mail, passwd) {
    this.mail = mail;
    this.passwd = passwd;
  }
  toJSON() {
    return {
      Email: this.mail,
      Password: this.passwd
    }
  };
}

const dummyAdd = new Address("dummystreet", "dummycity", "000000");
const dummyPerson = new ContactPerson(
  "dummyPerson",
  111111,
  "dummyPerson@dummy.com",
  "dummyfunction"
);
const dummyGeoLocation = new GeoLocation(1.1, 0.1);
export const dummyProf = new Professional(
  0,
  "serviceName",
  "dummy est.",
  "dummy management",
  dummyAdd,
  1111111,
  dummyGeoLocation,
  "dummy@dummy.com",
  dummyPerson,
  [],
  [],
  [],
  "dummydescription"
);
