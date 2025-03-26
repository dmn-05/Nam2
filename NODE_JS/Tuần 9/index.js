var http = require('http');
var fs = require('fs');
var path = require('path');

http.createServer(function (request, response) {
    let url = request.url;
    console.log('Requested:', url);

    let filePath = './pages/index.html';
    let contentType = 'text/html; charset=utf-8';

    if (url === '/') {
        filePath = './pages/index.html';
    } else if (url === '/style.css') {
        filePath = './public/style.css';
        contentType = 'text/css; charset=utf-8';
    } else if (url.startsWith('/img/')) {
        filePath = path.join(__dirname, 'public', url); // Đường dẫn đúng
        contentType = 'image/png'; // Mặc định PNG

        // Xác định loại ảnh dựa vào phần mở rộng
        let ext = path.extname(filePath);
        if (ext === '.jpg' || ext === '.jpeg') contentType = 'image/jpeg';
        if (ext === '.gif') contentType = 'image/gif';

        // Kiểm tra file có tồn tại không
        fs.access(filePath, fs.constants.F_OK, (err) => {
            if (err) {
                response.writeHead(404, { 'Content-Type': 'text/html; charset=utf-8' });
                return response.end('<h1>404 - Hình ảnh không tồn tại</h1>');
            }

            response.writeHead(200, { 'Content-Type': contentType });
            fs.createReadStream(filePath).pipe(response); // Đọc file hiệu quả hơn
        });
        return;
    } else {
        response.writeHead(404, { 'Content-Type': 'text/html; charset=utf-8' });
        return response.end('<h1>404 - Không tìm thấy trang</h1>');
    }

    fs.readFile(filePath, function (err, data) {
        if (err) {
            console.log('Lỗi:', err.message);
            response.writeHead(500, { 'Content-Type': 'text/html; charset=utf-8' });
            return response.end('<h1>500 - Lỗi server</h1>');
        }

        response.writeHead(200, { 'Content-Type': contentType });
        response.end(data);
    });

}).listen(3000);

console.log('Server running at http://127.0.0.1:3000/');