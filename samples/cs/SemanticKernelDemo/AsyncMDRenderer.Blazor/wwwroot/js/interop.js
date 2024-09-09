// wwwroot/js/interop.js
window.sendDataToWinForms = function (data) {
    chrome.webview.postMessage(data);
};

window.receiveDataFromWinForms = function (data) {
    DotNet.invokeMethodAsync('AsyncMDRenderer.Blazor', 'RenderMarkdown', data);
};
