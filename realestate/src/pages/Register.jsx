import React from 'react';
import Navigation from '../components/Navigation';
import Footer from '../components/Footer';
import { useTranslation } from 'react-i18next';
import { useForm } from "react-hook-form";
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';


const Register = () => {

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
                            <h1>{t('register')}</h1>
                        </div>
                    </Col>
                </Row>
                <Row className="justify-content-center">
                    <Col xs="12" md="8" lg="6">
                        <div className='m-4 p-2 bg-white border border-dark rounded text-center m-3 p-2'>
                            <form onSubmit={handleSubmit(onSubmit)}>
                                <div className="form-group">
                                    <label htmlFor="Name" className="form-label">{t('first_name')}</label>
                                    <input
                                        type="text"
                                        id="Name"
                                        className="form-control"
                                        placeholder={t('first_name')}
                                        {...register("Name", {
                                            required: t('name_required'),
                                        })}
                                    />
                                    {errors.Name && <p className='text-danger'>{errors.Name.message}</p>}
                                </div>
                                <div className="form-group">
                                    <label htmlFor="Surname" className="form-label">{t('surname')}</label>
                                    <input
                                        type="text"
                                        id="Surname"
                                        className="form-control"
                                        placeholder={t('surname')}
                                        {...register("Surname", {
                                            required: t('surname_required'),
                                        })}
                                    />
                                    {errors.Surname && <p className='text-danger'>{errors.Surname.message}</p>}
                                </div>
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
                                    {errors.Email && <p className='text-danger'>{errors.Email.message}</p>}
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
                                    {errors.Password && <p className='text-danger'>{errors.Password.message}</p>}
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

export default Register;