window.storageAvailable = (type) => {
    var storage;
    try {
        storage = window[type];
        var x = '__storage_test__';
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
};

window.storageSet = (type, key, value) => {
    try {
        var storage = window[type];
        storage.setItem(key, value);

        return true;
    }
    catch (e) {
        return false;
    }
};

window.storageGet = (type, key) => {
    try {
        var storage = window[type];
        return storage.getItem(key);
    }
    catch (e) {
        return '';
    }
};

window.storageRemove = (type, key) => {
    try {
        var storage = window[type];
        if (storage.length <= 0 || storage.getItem(key) === undefined) {
            return false;
        }

        localStorage.removeItem(key);
        return true;
    }
    catch (e) {
        return false;
    }
};

window.storageCount = (type) => {
    try {
        var storage = window[type];
        if (storage.length <= 0) {
            return 0;
        }
        return storage.length;
    }
    catch (e) {
        return 0;
    }
};

window.storageClear = (type) => {
    try {
        var storage = window[type];
        storage.clear();

        return true;
    }
    catch (e) {
        return false;
    }
};

window.storageGetAll = (type) => {
    try {
        var storage = window[type];

        var result = [];
        var keys = Object.keys(storage);

        for (var i = 0; i < keys.length; i++) {
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
};

window.storageListener = (componentInstance) => {
    window.addEventListener('storage',
        (e) => {
            var result = {};
            result['key'] = e.key;
            result['oldValue'] = e.oldValue;
            result['newValue'] = e.newValue;
            result['url'] = e.url;
            componentInstance.invokeMethodAsync('StorageChange', JSON.stringify(result));
        });
};