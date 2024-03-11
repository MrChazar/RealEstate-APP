import React from 'react';
import Navigation from '../components/Navigation';
import Footer from '../components/Footer';
import { useTranslation } from 'react-i18next';
import { useForm } from "react-hook-form";
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';


const Login = () => {
    const { t } = useTranslation();
    const form = useForm();
    const { register, handleSubmit, formState, reset} = form;
    const { errors } = formState;

    const onSubmit = (data) => {
        console.log(data);
        reset(); 
    }

    return (
        <>
        <Navigation />
        <div id='contain'>
            <div className='container-fluid home_root p-3'>
                <Row className="justify-content-center">
                    <Col xs="12" md="8" lg="6">
                        <div className='m-4 p-2 bg-white border border-dark rounded text-center'>
                            <h1>{t('login')}</h1>
                        </div>
                    </Col>
                </Row>
                <Row className="justify-content-center">
                    <Col xs="12" md="8" lg="6">
                        <div className='m-4 p-2 bg-white border border-dark rounded text-center m-3 p-2'>
                            <form onSubmit={handleSubmit(onSubmit)}>
                                <div className="form-group">
                                    <label htmlFor="Email" className="form-label">{t('email')}</label>
                                    <input
                                        type="email"
                                        id="Email"
                                        className="form-control"
                                        placeholder={t('email')}
                                        {...register("Email", {
                                            required: t('email_required'),
                                        })}
                                    />
                                    {errors.Email && <p>{errors.Email.message}</p>}
                                </div>
                                <div className="form-group">
                                    <label htmlFor="Password" className="form-label">{t('password')}</label>
                                    <input
                                        type="password"
                                        id="Password"
                                        className="form-control"
                                        placeholder={t('password')}
                                        {...register("Password", {
                                            required: t('password_required'),
                                            minLength: {
                                                value: 8,
                                                message: "Hasło musi mieć minimum 8 znaków."
                                            }
                                        })}
                                    />
                                    {errors.Password && <p>{errors.Password.message}</p>}
                                </div>
                                <button type="submit" className="btn btn-primary m-3 p-2">{t('login')}</button>
                            </form>
                        </div>
                    </Col>
                </Row>
            </div>
        </div>
        <Footer />
        </>
    );
};

export default Login;