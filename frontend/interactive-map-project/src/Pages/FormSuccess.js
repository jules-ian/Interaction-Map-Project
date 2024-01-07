import { Box } from "@mui/material";
import { Navigate, useNavigate } from "react-router-dom";
import ButtonComponent from "../Components/ButtonComponent";
import useWindowDimensions from "../utils/windowDimension";
import { Text } from "../Components/Label";
import { useTranslation } from "react-i18next";

export default function FormSuccess({ setMenuTitel }) {
  const { t } = useTranslation();
  setMenuTitel(t("page.successForm"));
  const navigate = useNavigate();
  const { width, height } = useWindowDimensions();
  return (
    <Box
      sx={{
        height: height * 0.5,
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        flexDirection: "column",
      }}
    >
      <Text>{t("successForm.description")}</Text>
      <Box sx={{ width: 0.3 }}>
        <ButtonComponent
          label={t("page.home")}
          onClick={() => navigate("/Home", { replace: true })}
        />
      </Box>
    </Box>
  );
}
