window.hideScrollOverflowByTag = (tagName) => {
    if (tagName.toLowerCase() === "body") {
        document.body.classList.add("blazor-javascript-no-overflow");
    } else {
        var elementsByTagName = document.getElementsByTagName(tagName);
        for (var element in elementsByTagName) {
            if (Object.prototype.hasOwnProperty.call(elementsByTagName, element) && element.classList !== undefined) {
                element.classList.add("blazor-javascript-no-overflow");
            }
        }
    }
};

window.hideScrollOverflowByClass = (className) => {
    if (className === undefined) {
        document.body.classList.add("blazor-javascript-no-overflow");
    } else {
        var elementsByClassName = document.getElementsByClassName(className);
        for (var element in elementsByClassName) {
            if (Object.prototype.hasOwnProperty.call(elementsByClassName, element) && element.classList !== undefined) {
                element.classList.add("blazor-javascript-no-overflow");
            }
        }
    }
};

window.showScrollOverflowByTag = (tagName) => {
    if (tagName.toLowerCase() === "body") {
        document.body.classList.remove("blazor-javascript-no-overflow");
    } else {
        var elementsByTagName = document.getElementsByTagName(tagName);
        for (var element in elementsByTagName) {
            if (Object.prototype.hasOwnProperty.call(elementsByTagName, element) && element.classList !== undefined) {
                element.classList.remove("blazor-javascript-no-overflow");
            }
        }
    }
};

window.showScrollOverflowByClass = (className) => {
    if (className === undefined) {
        document.body.classList.remove("blazor-javascript-no-overflow");
    } else {
        var elementsByClassName = document.getElementsByClassName(className);
        for (var element in elementsByClassName) {
            if (Object.prototype.hasOwnProperty.call(elementsByClassName, element) && element.classList !== undefined) {
                element.classList.remove("blazor-javascript-no-overflow");
            }
        }
    }
};