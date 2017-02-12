function RedirectToShop(url, adId) {
    $.post("/Advertisement/Redirect/", { id: adId }, function (data) {
    });

    window.location.href = url + "?ref=gradera";
}