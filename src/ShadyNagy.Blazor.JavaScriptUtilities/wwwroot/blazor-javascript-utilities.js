/* ==================================================================ScrollController================================================================== */

window.hideScrollOverflowByTag = (tagName, scrollType) => {
    if (tagName === "body") {
        hide(document.body, scrollType);
    } else {
        var elementsByTagName = document.getElementsByTagName(tagName);
        for (var element in elementsByTagName) {
            if (Object.prototype.hasOwnProperty.call(elementsByTagName, element) && element.classList !== undefined) {
                hide(element, scrollType);
            }
        }
    }
};

window.hideScrollOverflowByClass = (className, scrollType) => {
    if (className === "body") {
        hide(document.body, scrollType);
    } else {
        var elementsByClassName = document.getElementsByClassName(className);
        for (var element in elementsByClassName) {
            if (Object.prototype.hasOwnProperty.call(elementsByClassName, element) && element.classList !== undefined) {
                hide(element, scrollType);
            }
        }
    }
};

window.showScrollOverflowByTag = (tagName, scrollType) => {
    if (tagName === "body") {
        show(document.body, scrollType);
    } else {
        var elementsByTagName = document.getElementsByTagName(tagName);
        for (var element in elementsByTagName) {
            if (Object.prototype.hasOwnProperty.call(elementsByTagName, element) && element.classList !== undefined) {
                show(element, scrollType);
            }
        }
    }
};

window.showScrollOverflowByClass = (className, scrollType) => {
    if (className === "body") {
        show(document.body, scrollType);
    } else {
        var elementsByClassName = document.getElementsByClassName(className);
        for (var element in elementsByClassName) {
            if (Object.prototype.hasOwnProperty.call(elementsByClassName, element) && element.classList !== undefined) {
                show(element, scrollType);
            }
        }
    }
};

window.hideBodyScrollOverflow = (scrollType) => {
    hide(document.body, scrollType);
}

window.showBodyScrollOverflow = (scrollType) => {
    show(document.body, scrollType);
}

function hide(element, scrollType) {
    if (scrollType === 1) {
        element.classList.add("blazor-javascript-v-no-overflow");
    } else if (scrollType === 2) {
        element.classList.add("blazor-javascript-h-no-overflow");
    } else {
        element.classList.add("blazor-javascript-v-no-overflow");
        element.classList.add("blazor-javascript-h-no-overflow");
    }
}

function show(element, scrollType) {
    if (scrollType === 1) {
        element.classList.remove("blazor-javascript-v-no-overflow");
    } else if (scrollType === 2) {
        element.classList.remove("blazor-javascript-h-no-overflow");
    } else {
        element.classList.remove("blazor-javascript-v-no-overflow");
        element.classList.remove("blazor-javascript-h-no-overflow");
    }
}

/* ==================================================================Cookie================================================================== */

window.getCookie = (cname) => {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(";");
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === " ") {
            c = c.substring(1);
        }
        if (c.indexOf(name) === 0) {
            return c.substring(name.length, c.length);
        }
    }

    return "";
};

window.deleteCookie = (cname) => {
    document.cookie = cname + "=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
};