export function isPostalCode(postalcode){
    return (! (postalcode == "" || postalcode.length == 6 && !isNaN(Number(postalcode))))
}