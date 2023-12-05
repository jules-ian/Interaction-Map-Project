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
    this.conactPerson = contactPerson;
    this.audiences = audiences;
    this.placesOfIntervention = placesOfIntervention;
    this.missions = missions;
    this.description = description;
  }
  toString() {
    return "Professional" + this.serviceName;
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
