var cacheName = 'v2';
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

self.addEventListener("install", function (e) {
    console.log('[ServiceWorker] Installed');

    e.waitUntil(
        caches.open(cacheName).then(function (cache) {
            console.log('[ServiceWorker] Caching files...');
            return cache.addAll(cacheFiles);
        })
    );
});

self.addEventListener("activate", function (e) {
    console.log('[ServiceWorker] Activated');

    e.waitUntil(
        caches.keys().then(function (cacheNames) {
            return Promise.all(cacheNames.map(function (thisCacheName) {
                if (thisCacheName !== cacheName) {
                    console.log('[ServiceWorker] removing cache files from: ', thisCacheName);
                    return caches.delete(thisCacheName);
                }
            }));
        })
    );
});

self.addEventListener("fetch", function (e) {
    console.log('[ServiceWorker] Fetched', e.request.url);

    e.respondWith(

        caches.open(cacheName).then(cache => {
            return cache.match(e.request).then(response => {
                return response || fetch(e.request).then(response => {
                    cache.put(e.request, response.clone());
                    return response;
                });
            });
        })

        //caches.match(e.request).then(function (response) {
        //    return response || fetch(e.request).then((response) => {
        //        cache
        //    });
        //})
    );
});