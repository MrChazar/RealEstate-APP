import React from 'react';
import Navigation from '../components/Navigation';
import Footer from '../components/Footer';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import EstateSearch from '../components/EstateSearch';
import SearchResult from '../components/SearchResult';
import { useState } from 'react';

const Buy = () => {
    const [resultList, setResultList] = useState([
        {
          Name: "Hałupa",
          Address: "Koszalin",
          Area: "100",
          Price: "100000",
          Description: "Opis"
        },
        {
          Name: "Nowy Dom",
          Address: "Warszawa, ul. Północna 10",
          Area: "120",
          Price: "120000",
          Description: "Nowoczesny dom w centrum miasta"
        },
        {
          Name: "Inna Nieruchomość",
          Address: "Gdańsk, ul. Zachodnia 5",
          Area: "80",
          Price: "90000",
          Description: "Przestronne mieszkanie z widokiem na morze"
        },
        {
          Name: "Stylowy Apartament",
          Address: "Kraków, Rynek Główny 1",
          Area: "60",
          Price: "150000",
          Description: "Elegancki apartament w sercu starego miasta"
        },
        {
          Name: "Dom na Wsi",
          Address: "Poznań, Wiejska 3",
          Area: "200",
          Price: "250000",
          Description: "Uroczy dom otoczony zielenią"
        }
      ]);
    return (
        <>
            <Navigation />
            <div id='contain'>
                <div className='container-fluid home_root p-3'>
                    <Row className="justify-content-center mt-3">
                        <Col xs="12" md="8" lg="6" className='mt-3'>
                            <EstateSearch />
                        </Col>
                    </Row>
                    {resultList.map((result, index) => (
                        <SearchResult key={index} result={result} />
                    ))}
                </div>  
            </div>
            <Footer />
        </>
    );
};

export default Buy;