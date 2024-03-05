import i18n from 'i18next';
import { initReactI18next } from 'react-i18next';

i18n
  .use(initReactI18next)
  .init({
    lng: 'pl', 
    resources: {
      en: {
        translation: {
          'welcome': 'Welcome',
          'hello_world': 'Hello, World!',
          'buy': 'Buy',
          'sell': 'Sell',
          'login': 'Login',
          'register': 'Register',
        }
      },
      pl: {
        translation: {
          'welcome': 'Witaj',
          'hello_world': 'Witaj, Świecie!',
          'buy': 'Kup',
          'sell': 'Sprzedaj',
          'login': 'Zaloguj',
          'register': 'Zarejestruj',
        }
      }
    },
    fallbackLng: 'en', 
    interpolation: {
      escapeValue: false 
    }
  });

  export default i18n;
