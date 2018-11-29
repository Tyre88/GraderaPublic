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
            }))
        })
    );
});

self.addEventListener("fetch", function (e) {
    console.log('[ServiceWorker] Fetched', e.request.url);

    e.respondWith(
        caches.match(e.request).then(function (response) {
            if (response) {
                console.log('[ServiceWorker] found in cache', e.request.url);
                return response;
            }

            return fetch(e.request);
        })
    )
});