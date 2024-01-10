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

import React, { useEffect, useState } from "react";
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
import { isTelephoneNumber } from "../utils/checkFunctions.js";
import { Text } from "../Components/Label.js";
export default function Test() {
  const { t, i18n } = useTranslation();
  const [error, setError] = useState(false);
  const [testText, setTestText] = useState("");
  useEffect(() => {
    setError(!isTelephoneNumber(testText));
  }, [testText]);

  return (
    <Box>
      <TextInput error={error} setError={setError} setTextState={setTestText} />
    </Box>
  );
}
