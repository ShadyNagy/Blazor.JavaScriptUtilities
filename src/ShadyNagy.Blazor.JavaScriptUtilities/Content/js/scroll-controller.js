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