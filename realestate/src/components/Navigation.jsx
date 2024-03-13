import React from 'react';
import Image from 'react-bootstrap/Image';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import Container from 'react-bootstrap/Container';
import { Button } from 'react-bootstrap';
import { useTranslation } from 'react-i18next';
import { useState, useEffect } from 'react';


const Navigation = () => {

    const { i18n } = useTranslation();
    const { t } = useTranslation();
    const [initialized, setInitialized] = useState(false);
    
    useEffect(() => { 
        if (!initialized) {
            const language = localStorage.getItem('i18nextLng') || 'pl';
            i18n.changeLanguage(language);
            setInitialized(true);
        }
    }, [i18n, initialized]);

    const changeLanguage = () => {
        const newLanguage = i18n.language === 'en' ? 'pl' : 'en';
        i18n.changeLanguage(newLanguage);
        localStorage.setItem('i18nextLng', newLanguage);
        window.location.reload();
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