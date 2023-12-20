import {
  Container,
  Typography,
  Card,
  CardContent,
  Link,
  Grid,
  CssBaseline,
  makeStyles,
} from "@mui/material";

import { Professional, dummyProf } from "../utils/Entities.js";

import React, { useState } from "react";
import Button from "@mui/material/Button";
import Popover from "@mui/material/Popover";
import IconButton from "@mui/material/IconButton";
import CloseIcon from "@mui/icons-material/Close";
import useWindowDimensions from "../utils/windowDimension.js";
export default function Test() {
  return (
    <div>
      <WindowLikePopover />
    </div>
  );
}

const WindowLikePopover = () => {
  const [anchorEl, setAnchorEl] = useState(false);
  const { width, height } = useWindowDimensions();

  const handleClick = (event) => {
    let middleX = width / 2;
    let middleY = height / 2;
    setAnchorEl({
      clientWidth: 0,
      clientHeight: 0,
      getBoundingClientRect: () => ({
        top: middleY,
        left: middleX,
        width: 0,
        height: 0,
      }),
    });
  };

  const handleClose = () => {
    setAnchorEl(null);
  };

  const open = Boolean(anchorEl);
  const id = open ? "window-like-popover" : undefined;

  return (
    <div style={{ backgroundColor: "black", height: height, widht: width }}>
      <Popover
        id={id}
        open={open}
        anchorEl={anchorEl}
        onClose={handleClose}
        anchorOrigin={{
          vertical: "center",
          horizontal: "center",
        }}
        transformOrigin={{
          vertical: "center",
          horizontal: "center",
        }}
      >
        <div
          style={{
            width: width * 0.8,
            height: height * 0.7,
            borderRadius: "8px",
          }}
        >
          <IconButton
            edge="end"
            color="inherit"
            onClick={handleClose}
            sx={{ position: "absolute", top: 0, right: 0 }}
          >
            <CloseIcon />
          </IconButton>
        </div>
        <Typography style={{ padding: "16px" }}>
          This is the content of the window-like Popover.
        </Typography>
      </Popover>
      <Button onClick={handleClick} aria-describedby={id}>
        Open Window
      </Button>
    </div>
  );
};
