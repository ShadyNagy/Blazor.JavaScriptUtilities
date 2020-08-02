function hide(element, scrollType) {
    if (scrollType === 1) {
        element.classList.add("blazor-javascript-v-no-overflow");
    }
    else if (scrollType === 2) {
        element.classList.add("blazor-javascript-h-no-overflow");
    }
    else {
        element.classList.add("blazor-javascript-v-no-overflow");
        element.classList.add("blazor-javascript-h-no-overflow");
    }
}
function show(element, scrollType) {
    if (scrollType === 1) {
        element.classList.remove("blazor-javascript-v-no-overflow");
    }
    else if (scrollType === 2) {
        element.classList.remove("blazor-javascript-h-no-overflow");
    }
    else {
        element.classList.remove("blazor-javascript-v-no-overflow");
        element.classList.remove("blazor-javascript-h-no-overflow");
    }
}
function hideScrollOverflowByTag(tagName, scrollType) {
    if (tagName === "body") {
        hide(document.body, scrollType);
    }
    else {
        const elements = document.getElementsByTagName(tagName);
        for (let i = 0; i < elements.length; i++) {
            hide(elements[i], scrollType);
        }
    }
}
function hideScrollOverflowByClass(className, scrollType) {
    if (className === "body") {
        hide(document.body, scrollType);
    }
    else {
        const elements = document.getElementsByClassName(className);
        for (let i = 0; i < elements.length; i++) {
            hide(elements[i], scrollType);
        }
    }
}
function showScrollOverflowByTag(tagName, scrollType) {
    if (tagName === "body") {
        show(document.body, scrollType);
    }
    else {
        const elements = document.getElementsByTagName(tagName);
        for (let i = 0; i < elements.length; i++) {
            show(elements[i], scrollType);
        }
    }
}
function showScrollOverflowByClass(className, scrollType) {
    if (className === "body") {
        show(document.body, scrollType);
    }
    else {
        const elements = document.getElementsByClassName(className);
        for (let i = 0; i < elements.length; i++) {
            show(elements[i], scrollType);
        }
    }
}
function hideBodyScrollOverflow(scrollType) {
    hide(document.body, scrollType);
}
function showBodyScrollOverflow(scrollType) {
    show(document.body, scrollType);
}
//# sourceMappingURL=scroll-controller.js.map