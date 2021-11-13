
_apiUrl = "http://localhost:63578/";


function getProducts(categoryId, callback) {
    var url = _apiUrl + "api/products?categoryId=" + categoryId;

    $.get(url, function (data) {        
        callback(data);
    });
}

function getProduct(productId, callback) {
    var url = _apiUrl + "api/products/" + productId;

    $.get(url, function (data) {
        callback(data);
    });


}

function getCategories(callback) {
    var url = _apiUrl + "api/categories";
    
    $.get(url, function (data) {
        callback(data);
    });
}

function getLogin(username, password, callback, errorF) {
    var url = _apiUrl + "api/authentication";

    var data = { "username": username, "password": password };

    $.ajax({
        type: "POST",
        url: url,
        data: JSON.stringify( data),
        success: callback,
        dataType: "json",
        accepts: "application/json",
        contentType: "application/json",
        error: errorF
    });
}

function getUsername(userId, username, callback) {
    var url = _apiUrl + "api/Users" + userId;

    $.get(url, function (data) {
        callback(data);
    });
}

function doSignUp(name, surname, username, email, password, callback, errorF) {
    var url = _apiUrl + "api/Users";

    var data = { "name": name, "surname": surname, "username": username, "email": email, "password": password };

    $.ajax({
        type: "POST",
        url: url,
        data: JSON.stringify(data),
        success: callback,
        dataType: "json",
        accepts: "application/json",
        contentType: "application/json",
        error: errorF

    });

   
}

function setCookie(cname, cvalue, exdays) {
    const d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    let expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function getCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}


