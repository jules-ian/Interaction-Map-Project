export function isPostalCode(postalcode) {
  const regex = new RegExp("^(?:0[1-9]|[1-8]\\d|9[0-8])\\d{3}$");
  return regex.test(postalcode);
}

export function isName(name) {
  return name !== "" && typeof name === "string";
}

export function isTelephoneNumber(number) {
  const regex =
    /^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$/;

  return number !== "" && regex.test(number);
}

export function isEmail(email) {
  // TODO
  return isName(email);
}
