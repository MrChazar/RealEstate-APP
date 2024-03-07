import React from 'react';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import Container from 'react-bootstrap/Container';

const Footer = () => {
    return (
       <>
        <Navbar  bg="dark" data-bs-theme="dark">
            <Container>
                <Navbar.Brand href="/">© 2024 RealEstate APP</Navbar.Brand>
            </Container>
        </Navbar>
       </>
    );
};

export default Footer;