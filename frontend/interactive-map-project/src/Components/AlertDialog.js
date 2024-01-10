// AlertDialog.js
import React from "react";
import { Dialog, DialogContent, DialogTitle, Button } from "@mui/material";

export const SuccessDialog = ({ open, onClose, message }) => {
  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>Success</DialogTitle>
      <DialogContent>{message}</DialogContent>
      <Button onClick={onClose} color="primary" autoFocus>
        Close
      </Button>
    </Dialog>
  );
};

export const ErrorDialog = ({ open, onClose, message }) => {
  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>Error</DialogTitle>
      <DialogContent>{message}</DialogContent>
      <Button onClick={onClose} color="primary" autoFocus>
        Close
      </Button>
    </Dialog>
  );
};
