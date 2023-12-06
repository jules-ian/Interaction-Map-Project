import React, { useState, useEffect } from "react";
import axios from "axios";
import { TextField } from "@mui/material";
import DropMultiSelect from "./DropMultiSelect";
import InputComponent from "./InputComponent";

const InitGetter = ({ API, label }) => {
  const [names, setNames] = useState([]);

  useEffect(() => {
    axios
      .get(API)
      .then((response) => {
        // Extracting names from response.data
        const extractedNames = response.data.map((item) => item.name);
        console.log(extractedNames);
        console.log(response.data);
        setNames(extractedNames);
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
      });
  }, [API]);

  return <div />;
};

export default InitGetter;
