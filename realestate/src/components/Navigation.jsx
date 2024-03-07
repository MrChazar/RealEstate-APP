import React from 'react';
import Image from 'react-bootstrap/Image';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import Container from 'react-bootstrap/Container';
import { Button } from 'react-bootstrap';
import { useTranslation } from 'react-i18next';


const Navigation = () => {

    const { i18n } = useTranslation();
    const { t } = useTranslation();
    
    const changeLanguage = () => {
        i18n.changeLanguage(i18n.language === 'en' ? 'pl' : 'en');
    };

    return (
        <>
            <Navbar bg="dark" data-bs-theme="dark">
                <Container>
                    <Navbar.Brand href="/">RealEstate APP</Navbar.Brand>
                    <Nav className="me-auto">
                        <Nav.Link href="/buy">{t('buy')}</Nav.Link>
                        <Nav.Link href="/sell">{t('sell')}</Nav.Link>
                    </Nav>
                    <Nav>
                        <Nav.Link href="/login">{t('login')}</Nav.Link>
                        <Nav.Link href="/register">{t('register')}</Nav.Link>
                        <Button variant="outline-light" onClick={changeLanguage}>{i18n.language}</Button>
                    </Nav>
                </Container>
            </Navbar>
        </>
    );
};

export default Navigation;