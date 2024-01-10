import {
  Container,
  Typography,
  Card,
  CardContent,
  Link,
  Grid,
  CssBaseline,
  makeStyles,
  Box,
} from "@mui/material";

import { Professional, dummyProf } from "../utils/Entities.js";

import React, { useState } from "react";
import Button from "@mui/material/Button";
import Popover from "@mui/material/Popover";
import IconButton from "@mui/material/IconButton";
import CloseIcon from "@mui/icons-material/Close";
import useWindowDimensions from "../utils/windowDimension.js";
import { PopoverWindow } from "../Components/PopoverWindow.js";
import { useTranslation } from "react-i18next";
import { test } from "../utils/BackendFunctions.js";
import ButtonComponent from "../Components/ButtonComponent.js";
import InputComponent from "../Components/InputComponent.js";
import TextInput from "../Components/TextInput.js";
export default function Test() {
  const { t, i18n } = useTranslation();
  const [error, setError] = useState(false);
  const [testText, setTestText] = useState("");
  return (
    <Box>
      <ButtonComponent label="test" onClick={test} />
      <TextInput error={error} setError={setError} setTextState={setTestText} />
    </Box>
  );
}
