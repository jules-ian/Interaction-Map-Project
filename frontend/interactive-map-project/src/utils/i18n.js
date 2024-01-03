// src/i18n.js
import i18n from "i18next";
import { initReactI18next } from "react-i18next";

import translationEN from "../locales/en.json";
import translationFR from "../locales/en.json";

const resources = {
  en: {
    translation: translationEN,
  },
  fr: {
    translation: translationFR,
  },
};

i18n.use(initReactI18next).init({
  resources,
  globalInjection: true,
  lng: "en", // Default language
  interpolation: {
    escapeValue: false, // React already escapes values, so no need for this
  },
});

export default i18n;
