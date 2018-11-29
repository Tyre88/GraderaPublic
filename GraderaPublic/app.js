var cacheName = 'v3';
var cacheFiles = [
    "/js/headjs.min.js",
    "/js/jquery.min.js",
    "/Scripts/jquery.validate.min.js",
    "/Scripts/jquery.validate.unobtrusive.min.js",
    "/Content/Javascript/TecHover.js",
    "/content/javascript/advertisement.js",
    "https://ajax.googleapis.com/ajax/libs/angularjs/1.6.6/angular.min.js",
    "https://ajax.googleapis.com/ajax/libs/angularjs/1.6.6/angular-animate.min.js",
    "https://ajax.googleapis.com/ajax/libs/angularjs/1.6.6/angular-aria.min.js",
    "https://ajax.googleapis.com/ajax/libs/angularjs/1.6.6/angular-messages.min.js",
    "https://cdnjs.cloudflare.com/ajax/libs/angular-material/1.1.5/angular-material.min.js",

    "/Content/templatemo_style.css",
    "/content/css/advertisement.css",
    "https://cdnjs.cloudflare.com/ajax/libs/angular-material/1.1.5/angular-material.min.css",
    "/Content/nivo-slider.css",
    "/js/jquery.nivo.slider.js"
];


if ('serviceWorker' in navigator) {
    navigator.serviceWorker.register('./sw.js', { scope: './' })
        .then(function (registration) {
            console.log('Service worker registered', registration);
        })
        .catch(function (err) {
            console.log('Service worker failed to register', err);
        });
}