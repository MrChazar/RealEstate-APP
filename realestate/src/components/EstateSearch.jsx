import React from 'react';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';

const EstateSearch = () => {
    return (
        <div className='bg-white rounded border black p-3'>
            <h1 className='text-center'>Wyszukiwarka Nieruchomości</h1>
            <Form>
                <Row className="justify-content-center">
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>Typ nieruchomości</Form.Label>
                            <Form.Control as="select">
                                <option value="mieszkanie">Mieszkanie</option>
                                <option value="działka">Działka</option>
                                <option value="dom">Dom</option>
                            </Form.Control>
                        </Form.Group>
                    </Col>
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>Rodzaj transakcji</Form.Label>
                            <Form.Control as="select">
                                <option value="sprzedaż">Sprzedaż</option>
                                <option value="wynajem">Wynajem</option>
                            </Form.Control>
                        </Form.Group>
                    </Col>
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>Wyszukaj</Form.Label>
                            <Form.Control type="text" placeholder="Wyszukaj" />
                        </Form.Group>
                    </Col>
                </Row>
                <Row className="justify-content-center">
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>Cena</Form.Label>
                            <Row>
                                <Col>
                                    <Form.Control type="number" placeholder="od" />
                                </Col>
                                <Col>
                                    <Form.Control type="number" placeholder="do" />
                                </Col>
                            </Row>
                        </Form.Group>
                    </Col>
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>Powierzchnia</Form.Label>
                            <Row>
                                <Col>
                                    <Form.Control type="number" placeholder="od" />
                                </Col>
                                <Col>
                                    <Form.Control type="number" placeholder="do" />
                                </Col>
                            </Row>
                        </Form.Group>
                    </Col>
                    <Col xs='12' md='4'>
                        <Form.Group>
                            <Form.Label>Liczba pokoi</Form.Label>
                            <Row>
                                <Col>
                                    <Form.Control type="number" placeholder="od" />
                                </Col>
                                <Col>
                                    <Form.Control type="number" placeholder="do" />
                                </Col>
                            </Row>
                        </Form.Group>
                    </Col>
                </Row>
                <Row className="justify-content-center">
                    <Col xs='12' md='4'>
                    
                    </Col>
                    <Col xs='12' md='4'>
                        <Button className='m-2' variant="secondary" type="reset" block>Wyczyść Kryteria</Button> 
                    </Col>
                    <Col xs='12' md='4'>
                        <Button className='m-2' variant="primary" type='submit' block>Szukaj</Button>
                    </Col>
                </Row>
            </Form>
        </div>
    );
};

export default EstateSearch;
