// AlertDialog.js
import React from "react";
import { Dialog, DialogContent, DialogTitle, Button } from "@mui/material";
import { useNavigate } from "react-router-dom";
import DialogActions from '@mui/material/DialogActions';
import DialogContentText from '@mui/material/DialogContentText';
import { useTranslation } from "react-i18next";
import { useState } from "react";
import Slide from '@mui/material/Slide';
import TextInput from "../Components/TextInput";
import { isName } from "../utils/checkFunctions";


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
  const navigate = useNavigate();

  const handleClose = () => {
    onClose(); //todo : déconnecter l'utilisateur? deja fait?
    navigate("/Home", { replace: true });
  };
  const handleReturn = () => {
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
          <Button onClick={handleReturn}>{t("common.return")}
          </Button>
        </DialogActions>
      </Dialog>
    </React.Fragment>
  );
};

export const PopUpDialogEditProfil = ({ open, onClose }) => {
  const { t } = useTranslation();
  const navigate = useNavigate();

  const handleClose = () => {
    onClose(); //todo : modifier les infos dans la base de données
    navigate("/Profil", { replace: true });
  };
  const handleReturn = () => {
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
          <Button onClick={handleClose}>{t("common.submit")}
          </Button>
          <Button onClick={handleReturn}>{t("common.return")}
          </Button>
        </DialogActions>
      </Dialog>
    </React.Fragment>
  );
};


export const PopUpAdminValidateDialog = ({ open, onClose, onReturn }) => {
  const { t } = useTranslation();

  const handleClose = () => {
    onClose();
  };
  const handleReturn = () => {
    onReturn();
  };

  return (
    <React.Fragment>
      <Dialog
        open={open}
        TransitionComponent={Transition}
        onClose={handleClose}
        PaperProps={{
          component: 'form',
          onSubmit: (event) => {
            event.preventDefault();
            const formData = new FormData(event.currentTarget);
            const formJson = Object.fromEntries(formData.entries());
            const email = formJson.email;
            console.log(email);
            handleClose();
          },
        }}
      >
        <DialogTitle>{t("admin.titlepopupValidate")}</DialogTitle>
        <DialogActions>
          <Button onClick={handleReturn}>{t("common.return")}</Button>
          <Button onClick={handleClose} type="submit">{t("common.valid")}</Button>
        </DialogActions>
      </Dialog>
    </React.Fragment>
  );
};




export const PopUpAdminDeclineDialog = ({ open, onClose, onReturn }) => {
  const { t } = useTranslation();
  const [motif, setMotif] = useState("");
  const [motifError, setMotifError] = useState(false);

  const handleClose = () => {//todo:verifier qu'un motif soit saisi
    onClose();
    if (!isName(motif)) {
      setMotifError(true);
    }
  };
  const handleReturn = () => {
    onReturn();
  };

  return (
    <React.Fragment>
      <Dialog
        open={open}
        TransitionComponent={Transition}
        onClose={handleClose}
        PaperProps={{
          component: 'form',
          onSubmit: (event) => {
            event.preventDefault();
            const formData = new FormData(event.currentTarget);
            const formJson = Object.fromEntries(formData.entries());
            const email = formJson.email;
            console.log(email);
            handleClose();
          },
        }}
      >
        <DialogTitle>{t("admin.titlepopupDecline")}</DialogTitle>
        <DialogContent>
          <DialogContentText>
            {t("admin.askmotif")}
          </DialogContentText>
          <TextInput
            multiline={true}
            label={t("admin.motif")}
            error={motifError}
            setTextState={setMotif}
            setErrorState={setMotifError}
          />
        </DialogContent>
        <DialogActions>
          <Button onClick={handleReturn}>{t("common.return")}</Button>
          <Button onClick={handleClose} type="submit">{t("common.valid")}</Button>
        </DialogActions>
      </Dialog>
    </React.Fragment>
  );
};
