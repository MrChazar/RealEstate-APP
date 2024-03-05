import React from 'react';
import Navigation from '../components/Navigation.jsx';
import Container from 'react-bootstrap/Container';
import { useTranslation } from 'react-i18next';

const Home = () => {
    const { t } = useTranslation();
    return (
    <div>
        <Navigation />
        <h1>{t('buy')}</h1>
        <p>{t('sell')}</p>
    </div>
    );
};

export default Home;