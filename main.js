const { app, BrowserWindow } = require('electron')

function createWindow () {
    // Create the browser window.
    let win = new BrowserWindow({
        width: 1280,
        height: 960,
        webPreferences: {
            nodeIntegration: true
        }
    })

    // and load the index.html of the app.
    win.setMenu(null);
    win.loadURL('https://client.foldingathome.org');
    win.webContents.on('new-window', function(e, url) {
        e.preventDefault();
        require('electron').shell.openExternal(url);
    });
}


app.whenReady().then(createWindow)