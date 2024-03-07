import React from 'react';
import { useTranslation } from 'react-i18next';

const NotFound = () => {
    const { t } = useTranslation();
    return (
        <div>
            <h1>{t('not_found')}</h1>
            <p>{t('not_exist')}</p>
        </div>
    );
};

export default NotFound;