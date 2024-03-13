import i18n from 'i18next';
import { initReactI18next } from 'react-i18next';

const language = localStorage.getItem('i18nextLng') || 'pl';

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
          'first_name': 'First name',
          'name': 'Name',
          'address': 'Address',
          'description': 'Description',
          'login': 'Login',
          'email': 'Email',
          'password': 'Password',
          'email_required': 'Email is required',
          'password_required': 'Password is required',
          'register': 'Register',
          'surname_required': 'Surname is required',
          'surname': 'Surname',
          'name_required': 'Name is required',
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
          'first_name': 'Imię',
          'address': 'Adres',
          'description': 'Opis',
          'login': 'Logowanie',
          'email': 'Email',
          'password': 'Hasło',
          'email_required': 'Email jest wymagany',
          'password_required': 'Hasło jest wymagane',
          'register': 'Zarejestruj',
          'surname_required': 'Nazwisko jest wymagane',
          'surname': 'Nazwisko',  
          'name_required': 'Imię jest wymagane',   
      
        }
      }
    },
    fallbackLng: 'en', 
    interpolation: {
      escapeValue: false 
    }
  });

  export default i18n;
