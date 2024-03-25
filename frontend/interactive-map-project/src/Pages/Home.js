//page d'acceuil



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
          src="https://accueilpourtous31.fr/wp-content/uploads/2017/12/cropped-logo-Accueilpourtous31-180x180.jpg"
          alt="Accueilpourtous31 dessin maison"
          style={{ margin: 'auto' }}
        />
        <ButtonComponent
          label={t("page.signUp")}
          onClick={() => navigate("/Form", { replace: true })}
        />
        <ButtonComponent
          label={t("page.logIn")}
          onClick={() => navigate("/LogIn", { replace: true })}
        />
        {/* <Box sx={{ height: height * 0.02 }}></Box>
        { <ButtonComponent
          label={t("page.admin")}
          onClick={() => navigate("/Admin", { replace: true })}
          color="secondary"
        /> }
        <ButtonComponent //todo: potentiellement à enlever
          label={t("page.test")}
          onClick={() => navigate("/Test", { replace: true })}
          color="secondary"
        />*/}
      </Box>
    </Box>
  );
}
