// AlertDialog.js
import React from "react";
import { Dialog, DialogContent, DialogTitle, Button } from "@mui/material";
import DialogActions from '@mui/material/DialogActions';
import DialogContentText from '@mui/material/DialogContentText';
import { useTranslation } from "react-i18next";
import Slide from '@mui/material/Slide';

export const SuccessDialog = ({ open, onClose, message }) => {
  const { t } = useTranslation();
  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>{t("common.success")}</DialogTitle>
      <DialogContent>{message}</DialogContent>
      <Button onClick={onClose} color="primary" autoFocus>
        {t("common.close")}
      </Button>
    </Dialog>
  );
};

export const ErrorDialog = ({ open, onClose, message }) => {
  const { t } = useTranslation();

  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>{t("common.error")}</DialogTitle>
      <DialogContent>{message}</DialogContent>
      <Button onClick={onClose} color="primary" autoFocus>
        {t("common.close")}
      </Button>
    </Dialog>
  );
};

const Transition = React.forwardRef(function Transition(props, ref) {
  return <Slide direction="up" ref={ref} {...props} />;
});




export const PopUpDialog = ({ open, onClose }) => {
  const { t } = useTranslation();


  const handleClose = () => {
    onClose();
  };


  return (
    <React.Fragment>
      <Dialog
        open={open}
        TransitionComponent={Transition}
        keepMounted
        onClose={handleClose}
        aria-describedby="alert-dialog-slide-description"
      >
        <DialogTitle>{t("common.confirmation")}</DialogTitle>
        <DialogContent>
          <DialogContentText id="alert-dialog-slide-description">
            {t("common.confirmationBody")}
          </DialogContentText>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleClose}>{t("common.disconnection")}
          </Button>
          <Button onClick={handleClose}>{t("common.return")}
          </Button>
        </DialogActions>
      </Dialog>
    </React.Fragment>
  );
};
