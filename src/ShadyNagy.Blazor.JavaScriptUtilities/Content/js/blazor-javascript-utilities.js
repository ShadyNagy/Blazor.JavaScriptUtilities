/* ==================================================================ScrollController================================================================== */
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
/* ==================================================================Cookie================================================================== */
function getCookie(cname) {
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
function deleteCookie(cname) {
    document.cookie = cname + '=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;';
}
/* ==================================================================Storage================================================================== */
function getStorage(type) {
    try {
        if (type.toLowerCase() === 'sessionstorage') {
            return sessionStorage;
        }
        else if (type.toLowerCase() === 'localstorage') {
            return localStorage;
        }
        else {
            return null;
        }
    }
    catch (e) {
        return null;
    }
}
function storageAvailable(type) {
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
function storageSet(type, key, value) {
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
function storageGet(type, key) {
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
}
;
function storageRemove(type, key) {
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
function storageCount(type) {
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
function storageClear(type) {
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
function storageGetAll(type) {
    try {
        let storage = getStorage(type);
        if (storage === null) {
            return [];
        }
        let result = new Array();
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
function storageListener(componentInstance) {
    window.addEventListener('storage', (e) => {
        let result;
        result.key = e.key;
        result.oldValue = e.oldValue;
        result.newValue = e.newValue;
        result.url = e.url;
        componentInstance.invokeMethodAsync('StorageChange', JSON.stringify(result));
    });
}
/* ==================================================================File================================================================== */
//# sourceMappingURL=blazor-javascript-utilities.js.map