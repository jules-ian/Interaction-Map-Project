import React from 'react';
import { Navigate, Route } from 'react-router-dom';

export default function GuardedRoute({ component: Component, hasAccess, ...rest }) {

    return (<Route {...rest} render={(props) => (
        hasAccess === true
            ? <Component {...props} />
            : Navigate("/LogIn", { replace: true })
    )} />
    );
}