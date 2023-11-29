export class Professional {
  constructor(
    id,
    serviceName,
    address,
    phoneNumber,
    geolocation,
    email,
    contactPerson,
    audiences = [],
    placeOfIntervention = [],
    missions = [],
    description = null
  ) {
    this.id = id;
    this.serviceName = serviceName;
    this.address = address;
    this.phoneNumber = phoneNumber;
    this.geolocation = geolocation;
    this.email = email;
    this.conactPerson = contactPerson;
    this.audiences = audiences;
    this.placeOfIntervention = placeOfIntervention;
    this.mission = missions;
    this.description = description;
  }
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
