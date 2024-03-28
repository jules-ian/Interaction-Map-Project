//page d'accueil

import { Box } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { useTranslation } from "react-i18next";

export default function Home({ setMenuTitel }) {
  const { t } = useTranslation(); //constante t -> alias pour useTranslation() (traduction de l'anglais vers le français)
  setMenuTitel(t("page.home"));
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();
  return (
    <Box
      sx={{
        height: height * 0.5,
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
      }}
    >
      <Box sx={{ width: 0.3, textAlign: 'center' }}>
        <img
          src="https://accueilpourtous31.fr/wp-content/themes/apt31/css/img/maisons-pages.png"
          alt="Accueilpourtous31 dessin maison"
          style={{ marginTop: '100px', marginBottom: '20px' }}
        />
        <ButtonComponent
          label={t("page.signUp")} s
          onClick={() => navigate("/Form", { replace: true })}
          sx={{ marginTop: '20px' }}
        />
        <ButtonComponent
          label={t("page.logIn")}
          onClick={() => navigate("/LogIn", { replace: true })}
        />
      </Box>
    </Box>
  );
}
