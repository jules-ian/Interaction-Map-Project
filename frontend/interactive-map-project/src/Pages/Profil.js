
import { Box, Grid, Button } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { useEffect, useState } from "react";
import { useTranslation } from "react-i18next";
import TextInput from "../Components/TextInput";
import { Text, Header } from "../Components/Label";

export default function Profil({ setMenuTitel }) {
    const { t } = useTranslation(); //constante t -> alias pour useTranslation() (traduction de l'anglais vers le français)
    setMenuTitel(t("common.myAccount"));
    const navigate = useNavigate();
    const { width, height } = useWindowDimensions();



    return (
        null
    );
}
