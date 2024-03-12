export const arrayRange = (start, stop, step) =>
  Array.from(
    { length: (stop - start) / step + 1 },
    (value, index) => start + index * step
  );

export const mapNamesToIDs = function (nameArray, tupleArray) { // ? chaque professionnel associé à un id ?
  let ids = nameArray.map((name) => {
    const match = tupleArray.find((tuple) => tuple.name === name);
    return match ? match.id : null;
  });
  return ids;
};
