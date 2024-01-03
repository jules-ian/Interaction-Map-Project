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
export default function Test() {
  const { t, i18n } = useTranslation(["test2"]);
  return <Box>{t("blub")}</Box>;
}
