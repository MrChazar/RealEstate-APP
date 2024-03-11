import React from 'react';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import { useTranslation } from 'react-i18next';
import "../styles/SearchResult.css";
import Image from 'react-bootstrap/Image';

const SearchResult = ({result, toggleResult}) => {
    const { t } = useTranslation();
    return (
        <div className='bg-white rounded border black m-3 p-3'>
            <Row className='text-center'>
                <Col>
                    <h3>{t('name')}: {result.Name}</h3>
                </Col>
            </Row>
            <Row className="justify-content-center">
                <Col xs={12} md={6} className="d-flex justify-content-center mb-3">
                    <Image src="https://via.placeholder.com/300" rounded />
                </Col>
            </Row>
            <Row className="text-center">
                <Col xs={12} md={4}>
                    <p>{t('address')}: {result.Address}</p>
                </Col>
                <Col xs={12} md={4}>
                    <p>{t('area')}: {result.Area}</p>
                </Col>
                <Col xs={12} md={4}>
                    <p>{t('price')}: {result.Price}</p>
                </Col>
            </Row>
            <Row className='text-center'>
                <Col>
                    <h4>{t('description')}</h4>
                    <textarea rows='3' className="form-control"  value={result.Description} readOnly></textarea>
                </Col>
            </Row>
            <Row className='text-center'>
                <Col>
                    <button onClick={toggleResult} className='btn btn-primary m-3 p-2'>{t('more')}</button>
                </Col>
            </Row>
        </div>
    );
};

export default SearchResult;
