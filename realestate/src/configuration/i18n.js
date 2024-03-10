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
          'home_description': 'A page that will help you find your dream home!',
          'home_search': 'Search for a real estate',
          'estate_type': 'Estate type',
          'apartment': 'Apartment',
          'plot': 'Plot',
          'home': 'Home',
          'property_type': 'Property type',
          'transaction_type': 'Transaction type',
          'sell': 'Sell',
          'rent': 'Rent',
          'search': 'Search',
          'price': 'Price',
          'area': 'Area',
          'rooms_number': 'Rooms',
          'reset_criteria': 'Reset criteria',
          'from': 'from',
          'to': 'to',
          'name': 'Name',
          'address': 'Address',
          'description': 'Description',
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
          'home_description': 'Strona która pomoże Ci znaleźć wymarzony dom!',
          'home_search': 'Szukaj nieruchomości',
          'estate_type': 'Typ nieruchomości',
          'apartment': 'Mieszkanie',
          'plot': 'Działka',
          'home': 'Dom',
          'property_type': 'Rodzaj nieruchomości',
          'transaction_type': 'Rodzaj transakcji',
          'sell': 'Sprzedaż',
          'rent': 'Wynajem',
          'search': 'Wyszukaj',
          'price': 'Cena',
          'area': 'Powierzchnia',
          'rooms_number': 'Liczba pokoi',
          'reset_criteria': 'Resetuj kryteria',
          'from': 'od',
          'to': 'do',
          'name': 'Nazwa',
          'address': 'Adres',
          'description': 'Opis',
        }
      }
    },
    fallbackLng: 'en', 
    interpolation: {
      escapeValue: false 
    }
  });

  export default i18n;
