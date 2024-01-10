import { Box } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { useTranslation } from "react-i18next";

export default function Home({ setMenuTitel }) {
  const { t } = useTranslation();
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
      <Box sx={{ width: 0.3 }}>
        <ButtonComponent
          label={t("page.form")}
          onClick={() => navigate("/Form", { replace: true })}
        />
        <ButtonComponent
          label={t("page.search")}
          onClick={() => navigate("/Search", { replace: true })}
        />
        <Box sx={{ height: height * 0.02 }}></Box>
        <ButtonComponent
          label={t("page.admin")}
          onClick={() => navigate("/Admin", { replace: true })}
          color="secondary"
        />
        <ButtonComponent
          label={t("page.test")}
          onClick={() => navigate("/Test", { replace: true })}
          color="secondary"
        />
      </Box>
    </Box>
  );
}
