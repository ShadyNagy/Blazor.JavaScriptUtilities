function createOptions(top, left, behavior = 'auto') {
    return {
        top: top,
        left: left,
        behavior: behavior
    };
}
function createScrollIntoViewOptions(behavior = 'auto', block = 'start', inline = 'nearest') {
    return {
        behavior: behavior,
        block: block,
        inline: inline
    };
}
function getElementByTagName(tagName) {
    if (tagName === "body") {
        return document.body;
    }
    else {
        const elements = document.getElementsByTagName(tagName);
        for (let i = 0; i < elements.length; i++) {
            return elements[i];
        }
    }
    return new HTMLElement();
}
function getElementByClassName(className) {
    const elements = document.getElementsByClassName(className);
    for (let i = 0; i < elements.length; i++) {
        return elements[i];
    }
    return new HTMLElement();
}
function scrollHeightElement(element) {
    return element.scrollHeight;
}
function scrollWidthElement(element) {
    return element.scrollTop;
}
function setScrollLeftElement(element, value) {
    element.scrollLeft = value;
}
function setScrollTopElement(element, value) {
    element.scrollTop = value;
}
function getScrollLeftElement(element) {
    return element.scrollLeft;
}
function getScrollTopElement(element) {
    return element.scrollTop;
}
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
function mainScrollTo(top = 0, left = 0, behavior = 'auto') {
    try {
        const options = createOptions(top, left, behavior);
        window.scroll(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollVToElementById(elementId, behavior = 'auto', block = 'start') {
    try {
        let element = document.getElementById(elementId);
        const options = createScrollIntoViewOptions(behavior, block, undefined);
        element.scrollIntoView(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollVToElementByTag(tagName, behavior = 'auto', block = 'start') {
    try {
        let element = getElementByTagName(tagName);
        const options = createScrollIntoViewOptions(behavior, block, undefined);
        element.scrollIntoView(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollVToElementByClass(className, behavior = 'auto', block = 'start') {
    try {
        let element = getElementByClassName(className);
        const options = createScrollIntoViewOptions(behavior, block, undefined);
        element.scrollIntoView(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollHToElementById(elementId, behavior = 'auto', inline = 'nearest') {
    try {
        let element = document.getElementById(elementId);
        const options = createScrollIntoViewOptions(behavior, undefined, inline);
        element.scrollIntoView(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollHToElementByTag(tagName, behavior = 'auto', inline = 'nearest') {
    try {
        let element = getElementByTagName(tagName);
        const options = createScrollIntoViewOptions(behavior, undefined, inline);
        element.scrollIntoView(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollHToElementByClass(className, behavior = 'auto', inline = 'nearest') {
    try {
        let element = getElementByClassName(className);
        const options = createScrollIntoViewOptions(behavior, undefined, inline);
        element.scrollIntoView(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollElementToByElementId(elementId, top = 0, left = 0, behavior = 'auto') {
    try {
        let element = document.getElementById(elementId);
        const options = createOptions(top, left, behavior);
        element.scroll(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollElementToByTagName(tagName, top = 0, left = 0, behavior = 'auto') {
    try {
        let element = getElementByTagName(tagName);
        const options = createOptions(top, left, behavior);
        element.scroll(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function scrollElementToByClassName(className, top = 0, left = 0, behavior = 'auto') {
    try {
        let element = getElementByClassName(className);
        const options = createOptions(top, left, behavior);
        element.scroll(options);
        return true;
    }
    catch (e) {
        return false;
    }
}
function getScrollHeightByElementId(elementId) {
    try {
        let element = document.getElementById(elementId);
        return scrollHeightElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollHeightByTagName(tagName) {
    try {
        let element = getElementByTagName(tagName);
        return scrollHeightElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollHeightByClassName(className) {
    try {
        let element = getElementByClassName(className);
        return scrollHeightElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollWidthByElementId(elementId) {
    try {
        let element = document.getElementById(elementId);
        return scrollWidthElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollWidthByTagName(tagName) {
    try {
        let element = getElementByTagName(tagName);
        return scrollWidthElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollWidthByClassName(className) {
    try {
        let element = getElementByClassName(className);
        return scrollWidthElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollLeftByElementId(elementId) {
    try {
        let element = document.getElementById(elementId);
        return getScrollLeftElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollLeftByTagName(tagName) {
    try {
        let element = getElementByTagName(tagName);
        return getScrollLeftElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollLeftByClassName(className) {
    try {
        let element = getElementByClassName(className);
        return getScrollLeftElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollTopByElementId(elementId) {
    try {
        let element = document.getElementById(elementId);
        return getScrollTopElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollTopByTagName(tagName) {
    try {
        let element = getElementByTagName(tagName);
        return getScrollTopElement(element);
    }
    catch (e) {
        return 0;
    }
}
function getScrollTopByClassName(className) {
    try {
        let element = getElementByClassName(className);
        return getScrollTopElement(element);
    }
    catch (e) {
        return 0;
    }
}
function setScrollLeftByElementId(elementId, value) {
    try {
        let element = document.getElementById(elementId);
        setScrollLeftElement(element, value);
        return true;
    }
    catch (e) {
        return false;
    }
}
function setScrollLeftByTagName(tagName, value) {
    try {
        let element = getElementByTagName(tagName);
        setScrollLeftElement(element, value);
        return true;
    }
    catch (e) {
        return false;
    }
}
function setScrollLeftByClassName(className, value) {
    try {
        let element = getElementByClassName(className);
        setScrollLeftElement(element, value);
        return true;
    }
    catch (e) {
        return false;
    }
}
function setScrollTopByElementId(elementId, value) {
    try {
        let element = document.getElementById(elementId);
        setScrollTopElement(element, value);
        return true;
    }
    catch (e) {
        return false;
    }
}
function setScrollTopByTagName(tagName, value) {
    try {
        let element = getElementByTagName(tagName);
        setScrollTopElement(element, value);
        return true;
    }
    catch (e) {
        return false;
    }
}
function setScrollTopByClassName(className, value) {
    try {
        let element = getElementByClassName(className);
        setScrollTopElement(element, value);
        return true;
    }
    catch (e) {
        return false;
    }
}
//# sourceMappingURL=scroll-controller.js.map