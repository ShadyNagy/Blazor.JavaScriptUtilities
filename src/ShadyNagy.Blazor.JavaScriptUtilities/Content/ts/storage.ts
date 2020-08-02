export { };

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
            let result: IStorageChanged;
            result.key = e.key;
            result.oldValue = e.oldValue;
            result.newValue = e.newValue;
            result.url = e.url;
            componentInstance.invokeMethodAsync('StorageChange', JSON.stringify(result));
        });
}

export interface IStorageChanged {
    key: string;
    oldValue: string;
    newValue: string;
    url: string;
}