﻿if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('./sw.js', { scope: './' })
        .then(function (registration) {
            console.log('Service worker registered', registration);
        })
        .catch(function (err) {
            console.log('Service worker failed to register', err);
        });
}