const http = require('http');
const fs = require('fs');
const path = require('path');

const lst = [
    { id: 1, name: 'Item Name 01', img: 'img/1.png' },
    { id: 2, name: 'Item Name 02', img: 'img/2.png' },
    { id: 3, name: 'Item Name 03', img: 'img/3.png' }
];

const server = http.createServer((req, res) => {
    let url = req.url.replace(/\/+$/, '');
    if (url === '' || url === '/index' || url === '/home') {
        serveFile(res, 'pages/index.html', 'text/html', 'utf8');
    }
    else if (url.startsWith('/detail/')) {
        let id = parseInt(url.split('/')[2]);
        let item = lst.find(x => x.id === id);
        
        if (item && url.split('/').length === 3) {
            fs.readFile('pages/detail.html', 'utf8', (err, data) => {
                if (err) {
                    serve404(res);
                } else {
                    let content = data.replace('{{name}}', item.name)
                                      .replace('{{img}}', item.img);
                    res.writeHead(200, { 'Content-Type': 'text/html; charset=utf-8' });
                    res.end(content, 'utf8');
                }
            });
        } else {
            serve404(res);
        }
    }
    else if (url.endsWith('.css') || url.endsWith('.png')) {
        let filePath = path.join(__dirname, 'public', url);
        let ext = path.extname(filePath).slice(1);
        let contentType = ext === 'css' ? 'text/css' : 'image/png';
        serveFile(res, filePath, contentType);
    }
    else {
        serve404(res);
    }
});
function serveFile(res, filePath, contentType, encoding = null) {
    fs.readFile(filePath, encoding, (err, content) => {
        if (err) {
            serve404(res);
        } else {
            res.writeHead(200, { 'Content-Type': contentType + (encoding ? '; charset=utf-8' : '') });
            res.end(content, encoding || undefined);
        }
    });
}

// Hàm trả về trang 404
function serve404(res) {
    serveFile(res, 'pages/404.html', 'text/html', 'utf8');
}

const PORT = process.env.PORT || 5000;
server.listen(PORT, () => {
    console.log(`Server chạy tại http://localhost:${PORT}`);
});
