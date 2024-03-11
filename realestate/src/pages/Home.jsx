import React from 'react';
import '../styles/Home.css';
import Navigation from '../components/Navigation.jsx';
import Container from 'react-bootstrap/Container';
import { useTranslation } from 'react-i18next';
import Footer from '../components/Footer.jsx';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Card from 'react-bootstrap/Card';
import EstateSearch from '../components/EstateSearch.jsx';
import { useState } from 'react';
import SearchResult from '../components/SearchResult.jsx';

const Home = () => {
    const { t } = useTranslation();
    return (
    <>
        <Navigation />
        <div id='contain'>
            <div className='container-fluid home_root p-3'>
                <Row className="justify-content-center">
                    <Col xs="12" md="8" lg="6">
                        <div className='m-4 p-2 bg-dark rounded'>
                            <h1 className='text-white'>{t('welcome')}</h1>
                        </div>
                    </Col>
                </Row>
                <Row className="justify-content-center">
                    <Col xs="12" md="8" lg="6">
                        <div className='m-4 p-2 bg-white border border-dark text-center rounded'>
                            <p className='text-dark'>{t('home_description')}</p>
                        </div>
                    </Col>
                </Row>
            </div>
        </div>
        <Footer />
    </>
    );
};

export default Home;