import i18n from 'i18next';
import { initReactI18next } from 'react-i18next';

i18n
  .use(initReactI18next)
  .init({
    lng: 'pl', 
    resources: {
      en: {
        translation: {
          'welcome': 'Welcome to RealEstate APP! site',
          'hello_world': 'Hello, World!',
          'buy': 'Buy',
          'sell': 'Sell',
          'login': 'Login',
          'register': 'Register',
          'not_found': '404 - Page Not Found',
          'not_exist': 'The page you are looking for does not exist.',
          'home_description': 'A page that will help you find your dream home!'
        }
      },
      pl: {
        translation: {
          'welcome': 'Witaj na Stronie RealEstate APP!',
          'hello_world': 'Witaj, Świecie!',
          'buy': 'Kup',
          'sell': 'Sprzedaj',
          'login': 'Zaloguj',
          'register': 'Zarejestruj',
          'not_found': '404 - Strona nie znaleziona',
          'not_exist': 'Strona, której szukasz, nie istnieje.',
          'home_description': 'Strona która pomoże Ci znaleźć wymarzony dom!'
        }
      }
    },
    fallbackLng: 'en', 
    interpolation: {
      escapeValue: false 
    }
  });

  export default i18n;
