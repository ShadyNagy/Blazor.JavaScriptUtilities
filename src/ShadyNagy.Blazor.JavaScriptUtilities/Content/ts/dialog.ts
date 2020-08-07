export { };

function showAlert(message: string) {
    try {
        window.alert(message);
        return true;
    } catch (e) {
        return false;
    }
}

function showPrompt(message: string, defaultResponse: string='') {
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