import React from 'react';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { useTranslation } from 'react-i18next';

const EstateSearch = () => {
    const { t } = useTranslation();
    return (
        <div className='bg-white rounded border black p-3'>
            <h1 className='text-center'>{t('home_search')}</h1>
            <Form>
                <Row className="justify-content-center">
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>{t('property_type')}</Form.Label>
                            <Form.Control as="select">
                                <option value="apartment">{t('apartment')}</option>
                                <option value="plot">{t('plot')}</option>
                                <option value="home">{t('home')}</option>
                            </Form.Control>
                        </Form.Group>
                    </Col>
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>{t('transaction_type')}</Form.Label>
                            <Form.Control as="select">
                                <option value="sell">{t('sell')}</option>
                                <option value="rent">{t('rent')}</option>
                            </Form.Control>
                        </Form.Group>
                    </Col>
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>{t('search')}</Form.Label>
                            <Form.Control type="text" placeholder={t('search')} />
                        </Form.Group>
                    </Col>
                </Row>
                <Row className="justify-content-center">
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>{t('price')}</Form.Label>
                            <Row>
                                <Col>
                                    <Form.Control type="number" placeholder={t('from')} />
                                </Col>
                                <Col>
                                    <Form.Control type="number" placeholder={t('to')} />
                                </Col>
                            </Row>
                        </Form.Group>
                    </Col>
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>{t('area')}</Form.Label>
                            <Row>
                                <Col>
                                    <Form.Control type="number" placeholder={t('from')} />
                                </Col>
                                <Col>
                                    <Form.Control type="number" placeholder={t('to')} />
                                </Col>
                            </Row>
                        </Form.Group>
                    </Col>
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>{t('rooms_number')}</Form.Label>
                            <Row>
                                <Col>
                                    <Form.Control type="number" placeholder={t('from')} />
                                </Col>
                                <Col>
                                    <Form.Control type="number" placeholder={t('to')} />
                                </Col>
                            </Row>
                        </Form.Group>
                    </Col>
                </Row>
                <Row className="justify-content-center">
                    <Col xs='12' md='4'>
                    
                    </Col>
                    <Col xs='12' md='4'>
                        <Button className='m-2' variant="secondary" type="reset" block>{t('reset_criteria')}</Button> 
                    </Col>
                    <Col xs='12' md='4'>
                        <Button className='m-2' variant="primary" type='submit' block>{t('search')}</Button>
                    </Col>
                </Row>
            </Form>
        </div>
    );
};

export default EstateSearch;
