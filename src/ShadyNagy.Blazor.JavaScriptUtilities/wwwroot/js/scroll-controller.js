window.hideScrollOverflowByTag = (tagName) => {
    if (className === undefined) {
        document.body.classList.add("blazor-javascript-no-overflow");
    } else {
        var elementsByTagName = document.getElementsByTagName(className);
        for (var tag in elementsByTagName) {
            if (Object.prototype.hasOwnProperty.call(elementsByTagName, tag)) {
                tag.classList.add("blazor-javascript-no-overflow");
            }
        }
    }
};

window.showScrollOverflowByTag = (tagName) => {
    if (className === undefined) {
        document.body.classList.remove("blazor-javascript-no-overflow");
    } else {
        var elementsByTagName = document.getElementsByTagName(className);
        for (var tag in elementsByTagName) {
            if (Object.prototype.hasOwnProperty.call(elementsByTagName, tag)) {
                tag.classList.remove("blazor-javascript-no-overflow");
            }
        }
    }
};