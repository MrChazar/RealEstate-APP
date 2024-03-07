import React from 'react';
import '../styles/Home.css';
import Navigation from '../components/Navigation.jsx';
import Container from 'react-bootstrap/Container';
import { useTranslation } from 'react-i18next';
import Footer from '../components/Footer.jsx';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Card from 'react-bootstrap/Card';


const Home = () => {
    const { t } = useTranslation();
    return (
    <div>
        <Navigation />
        <Container>
            <div className='home_root'>
                <Row className="justify-content-md-center">
                    <Col md="auto">
                        <div className='m-4 p-2 bg-dark rounded'>
                            <h1 className='text-white'>{t('welcome')}</h1>
                        </div>
                    </Col>
                </Row>
                <Row className="justify-content-md-center">
                    <Col md="auto">
                        <div className='m-4 p-2 bg-white border border-dark rounded'>
                            <p className='text-dark'>{t('home_description')}</p>
                        </div>
                    </Col>
                </Row>
            </div>
        </Container>
        <Footer />
    </div>
    );
};

export default Home;