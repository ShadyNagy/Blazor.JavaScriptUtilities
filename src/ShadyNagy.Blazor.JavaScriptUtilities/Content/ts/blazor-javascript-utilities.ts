export { };

/* ==================================================================ScrollController================================================================== */
interface IScrollOptions {
    top: number;
    left: number;
    behavior: 'auto' | 'smooth';
}

interface IScrollIntoViewOptions {
    behavior: 'auto' | 'smooth';
    block: 'start' | 'center' | 'end' | 'nearest';
    inline: 'start' | 'center' | 'end' | 'nearest';
}

function createOptions(top: number, left: number, behavior: 'auto' | 'smooth' = 'auto') {
    return <IScrollOptions>{
        top: top,
        left: left,
        behavior: behavior
    };
}

function createScrollIntoViewOptions(
    behavior: 'auto' | 'smooth' = 'auto',
    block: 'start' | 'center' | 'end' | 'nearest' = 'start',
    inline: 'start' | 'center' | 'end' | 'nearest' = 'nearest') {
    return <IScrollIntoViewOptions>{
        behavior: behavior,
        block: block,
        inline: inline
    };
}

function getElementByTagName(tagName: string) {
    if (tagName === "body") {
        return document.body;
    } else {
        const elements = document.getElementsByTagName(tagName) as HTMLCollectionOf<HTMLElement>;
        for (let i = 0; i < elements.length; i++) {
            return elements[i];
        }
    }

    return new HTMLElement();
}

function getElementByClassName(className: string) {
    const elements = document.getElementsByClassName(className) as HTMLCollectionOf<HTMLElement>;
    for (let i = 0; i < elements.length; i++) {
        return elements[i];
    }

    return new HTMLElement();
}

function scrollHeightElement(element: HTMLElement): number {
    return element.scrollHeight;
}

function scrollWidthElement(element: HTMLElement): number {
    return element.scrollTop;
}

function setScrollLeftElement(element: HTMLElement, value: number) {
    element.scrollLeft = value;
}

function setScrollTopElement(element: HTMLElement, value: number) {
    element.scrollTop = value;
}

function getScrollLeftElement(element: HTMLElement): number {
    return element.scrollLeft;
}

function getScrollTopElement(element: HTMLElement): number {
    return element.scrollTop;
}

function hide(element: HTMLElement, scrollType: number) {
    if (scrollType === 1) {
        element.classList.add("blazor-javascript-v-no-overflow");
    } else if (scrollType === 2) {
        element.classList.add("blazor-javascript-h-no-overflow");
    } else {
        element.classList.add("blazor-javascript-v-no-overflow");
        element.classList.add("blazor-javascript-h-no-overflow");
    }
}

function show(element: HTMLElement, scrollType: number) {
    if (scrollType === 1) {
        element.classList.remove("blazor-javascript-v-no-overflow");
    } else if (scrollType === 2) {
        element.classList.remove("blazor-javascript-h-no-overflow");
    } else {
        element.classList.remove("blazor-javascript-v-no-overflow");
        element.classList.remove("blazor-javascript-h-no-overflow");
    }
}

function hideScrollOverflowByTag(tagName: string, scrollType: number) {
    if (tagName === "body") {
        hide(document.body, scrollType);
    } else {
        const elements = document.getElementsByTagName(tagName) as HTMLCollectionOf<HTMLElement>;
        for (let i = 0; i < elements.length; i++) {
            hide(elements[i], scrollType);
        }
    }
}

function hideScrollOverflowByClass(className: string, scrollType: number) {
    if (className === "body") {
        hide(document.body, scrollType);
    } else {
        const elements = document.getElementsByClassName(className) as HTMLCollectionOf<HTMLElement>;
        for (let i = 0; i < elements.length; i++) {
            hide(elements[i], scrollType);
        }
    }
}

function showScrollOverflowByTag(tagName: string, scrollType: number) {
    if (tagName === "body") {
        show(document.body, scrollType);
    } else {
        const elements = document.getElementsByTagName(tagName) as HTMLCollectionOf<HTMLElement>;
        for (let i = 0; i < elements.length; i++) {
            show(elements[i], scrollType);
        }
    }
}

function showScrollOverflowByClass(className: string, scrollType: number) {
    if (className === "body") {
        show(document.body, scrollType);
    } else {
        const elements = document.getElementsByClassName(className) as HTMLCollectionOf<HTMLElement>;
        for (let i = 0; i < elements.length; i++) {
            show(elements[i], scrollType);
        }
    }
}

function hideBodyScrollOverflow(scrollType: number) {
    hide(document.body, scrollType);
}

function showBodyScrollOverflow(scrollType: number) {
    show(document.body, scrollType);
}

function mainScrollTo(top = 0, left = 0, behavior: 'auto' | 'smooth' = 'auto') {
    try {
        const options = createOptions(top, left, behavior);
        window.scroll(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollVToElementById(elementId: string, behavior: 'auto' | 'smooth' = 'auto', block: 'start' | 'center' | 'end' | 'nearest' = 'start') {
    try {
        let element = document.getElementById(elementId);
        const options = createScrollIntoViewOptions(behavior, block, undefined);
        element.scrollIntoView(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollVToElementByTag(tagName: string, behavior: 'auto' | 'smooth' = 'auto', block: 'start' | 'center' | 'end' | 'nearest' = 'start') {
    try {
        let element = getElementByTagName(tagName);
        const options = createScrollIntoViewOptions(behavior, block, undefined);
        element.scrollIntoView(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollVToElementByClass(className: string, behavior: 'auto' | 'smooth' = 'auto', block: 'start' | 'center' | 'end' | 'nearest' = 'start') {
    try {
        let element = getElementByClassName(className);
        const options = createScrollIntoViewOptions(behavior, block, undefined);
        element.scrollIntoView(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollHToElementById(elementId: string, behavior: 'auto' | 'smooth' = 'auto', inline: 'start' | 'center' | 'end' | 'nearest' = 'nearest') {
    try {
        let element = document.getElementById(elementId);
        const options = createScrollIntoViewOptions(behavior, undefined, inline);
        element.scrollIntoView(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollHToElementByTag(tagName: string, behavior: 'auto' | 'smooth' = 'auto', inline: 'start' | 'center' | 'end' | 'nearest' = 'nearest') {
    try {
        let element = getElementByTagName(tagName);
        const options = createScrollIntoViewOptions(behavior, undefined, inline);
        element.scrollIntoView(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollHToElementByClass(className: string, behavior: 'auto' | 'smooth' = 'auto', inline: 'start' | 'center' | 'end' | 'nearest' = 'nearest') {
    try {
        let element = getElementByClassName(className);
        const options = createScrollIntoViewOptions(behavior, undefined, inline);
        element.scrollIntoView(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollElementToByElementId(elementId: string, top = 0, left = 0, behavior: 'auto' | 'smooth' = 'auto') {
    try {
        let element = document.getElementById(elementId);
        const options = createOptions(top, left, behavior);
        element.scroll(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollElementToByTagName(tagName: string, top = 0, left = 0, behavior: 'auto' | 'smooth' = 'auto') {
    try {
        let element = getElementByTagName(tagName);
        const options = createOptions(top, left, behavior);
        element.scroll(options);
        return true;
    } catch (e) {
        return false;
    }
}

function scrollElementToByClassName(className: string, top = 0, left = 0, behavior: 'auto' | 'smooth' = 'auto') {
    try {
        let element = getElementByClassName(className);
        const options = createOptions(top, left, behavior);
        element.scroll(options);
        return true;
    } catch (e) {
        return false;
    }
}

function getScrollHeightByElementId(elementId: string): number {
    try {
        let element = document.getElementById(elementId);

        return scrollHeightElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollHeightByTagName(tagName: string): number {
    try {
        let element = getElementByTagName(tagName);

        return scrollHeightElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollHeightByClassName(className: string): number {
    try {
        let element = getElementByClassName(className);

        return scrollHeightElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollWidthByElementId(elementId: string): number {
    try {
        let element = document.getElementById(elementId);

        return scrollWidthElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollWidthByTagName(tagName: string): number {
    try {
        let element = getElementByTagName(tagName);

        return scrollWidthElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollWidthByClassName(className: string): number {
    try {
        let element = getElementByClassName(className);

        return scrollWidthElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollLeftByElementId(elementId: string): number {
    try {
        let element = document.getElementById(elementId);

        return getScrollLeftElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollLeftByTagName(tagName: string): number {
    try {
        let element = getElementByTagName(tagName);

        return getScrollLeftElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollLeftByClassName(className: string): number {
    try {
        let element = getElementByClassName(className);

        return getScrollLeftElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollTopByElementId(elementId: string): number {
    try {
        let element = document.getElementById(elementId);

        return getScrollTopElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollTopByTagName(tagName: string): number {
    try {
        let element = getElementByTagName(tagName);

        return getScrollTopElement(element);
    } catch (e) {
        return 0;
    }
}

function getScrollTopByClassName(className: string): number {
    try {
        let element = getElementByClassName(className);

        return getScrollTopElement(element);
    } catch (e) {
        return 0;
    }
}

function setScrollLeftByElementId(elementId: string, value: number) {
    try {
        let element = document.getElementById(elementId);

        setScrollLeftElement(element, value);

        return true;
    } catch (e) {
        return false;
    }
}

function setScrollLeftByTagName(tagName: string, value: number) {
    try {
        let element = getElementByTagName(tagName);

        setScrollLeftElement(element, value);

        return true;
    } catch (e) {
        return false;
    }
}

function setScrollLeftByClassName(className: string, value: number) {
    try {
        let element = getElementByClassName(className);

        setScrollLeftElement(element, value);

        return true;
    } catch (e) {
        return false;
    }
}

function setScrollTopByElementId(elementId: string, value: number) {
    try {
        let element = document.getElementById(elementId);

        setScrollTopElement(element, value);

        return true;
    } catch (e) {
        return false;
    }
}

function setScrollTopByTagName(tagName: string, value: number) {
    try {
        let element = getElementByTagName(tagName);

        setScrollTopElement(element, value);

        return true;
    } catch (e) {
        return false;
    }
}

function setScrollTopByClassName(className: string, value: number) {
    try {
        let element = getElementByClassName(className);

        setScrollTopElement(element, value);

        return true;
    } catch (e) {
        return false;
    }
}

/* ==================================================================Cookie================================================================== */

function getCookie(cname: string) {
    const name = cname + '=';
    const decodedCookie = decodeURIComponent(document.cookie);
    const ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) === ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) === 0) {
            return c.substring(name.length, c.length);
        }
    }

    return '';
}

function deleteCookie(cname: string) {
    document.cookie = cname + '=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;';
}

/* ==================================================================Storage================================================================== */
function getStorage(type: string) {
    try {
        if (type.toLowerCase() === 'sessionstorage') {
            return sessionStorage;
        } else if (type.toLowerCase() === 'localstorage') {
            return localStorage;
        } else {
            return null;
        }
    } catch (e) {
        return null;
    }
}

function storageAvailable(type: string) {
    let storage = getStorage(type);
    if (storage === null) {
        return false;
    }
    try {
        const x = '__storage_test__';
        storage.setItem(x, x);
        storage.removeItem(x);

        return true;
    }
    catch (e) {
        return e instanceof DOMException &&
            (e.code === 22 ||
                e.code === 1014 ||
                e.name === 'QuotaExceededError' ||
                e.name === 'NS_ERROR_DOM_QUOTA_REACHED') &&
            (storage && storage.length !== 0);
    }
}

function storageSet(type: string, key: string, value: string) {
    try {
        let storage = getStorage(type);
        if (storage === null) {
            return false;
        }

        storage.setItem(key, value);

        return true;
    }
    catch (e) {
        return false;
    }
}

function storageGet(type: string, key: string) {
    try {
        let storage = getStorage(type);
        if (storage === null) {
            return '';
        }
        return storage.getItem(key);
    }
    catch (e) {
        return '';
    }
};

function storageRemove(type: string, key: string) {
    try {
        let storage = getStorage(type);
        if (storage === null) {
            return false;
        }

        if (storage.length <= 0 || storage.getItem(key) === undefined) {
            return false;
        }

        localStorage.removeItem(key);
        return true;
    }
    catch (e) {
        return false;
    }
}

function storageCount(type: string) {
    try {
        let storage = getStorage(type);
        if (storage === null) {
            return 0;
        }

        if (storage.length <= 0) {
            return 0;
        }
        return storage.length;
    }
    catch (e) {
        return 0;
    }
}

function storageClear(type: string) {
    try {
        let storage = getStorage(type);
        if (storage === null) {
            return false;
        }

        storage.clear();

        return true;
    }
    catch (e) {
        return false;
    }
}

function storageGetAll(type: string) {
    try {
        let storage = getStorage(type);
        if (storage === null) {
            return [];
        }

        let result = new Array<string>();
        const keys = Object.keys(storage);

        for (let i = 0; i < keys.length; i++) {
            if (!keys[i]) {
                continue;
            }
            result.push(keys[i].toString() + '=' + storage.getItem(keys[i].toString()));
        }

        return result;
    }
    catch (e) {
        return [];
    }
}

function storageListener(componentInstance: any) {
    window.addEventListener('storage',
        (e) => {
            let result = <IStorageChanged>{
                key: e.key,
                oldValue: e.oldValue,
                newValue: e.newValue,
                url: e.url
            }
            componentInstance.invokeMethodAsync('StorageChange', JSON.stringify(result));
        });
}

interface IStorageChanged {
    key: string;
    oldValue: string;
    newValue: string;
    url: string;
}

/* ==================================================================Dialog================================================================== */
function showAlert(message: string) {
    try {
        window.alert(message);
        return true;
    } catch (e) {
        return false;
    }
}

function showPrompt(message: string, defaultResponse: string = '') {
    try {
        return window.prompt(message, defaultResponse);
    } catch (e) {
        return '';
    }
}

function showConfirm(message: string) {
    try {
        return window.confirm(message);
    } catch (e) {
        return false;
    }
}
