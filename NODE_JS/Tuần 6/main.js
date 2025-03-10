var http = require('http');

const server = http.createServer(function (request, response) {
  response.writeHead(200, { 'Content-Type': 'text/html; charset=utf-8' });

  const detailRegex = /^\/detail\/(\d+)$/; // Chỉ chấp nhận số sau /detail/
  const match = request.url.match(detailRegex);

  if (request.url === "/index") {
    response.end("<h1 style='text-align: center; color: red;'>Trang chủ</h1>");
  }
  else if (request.url === "/detail") { 
    response.end("<h1 style='text-align: center; color: green;'>Chi tiết mặc định</h1>");
  }
  else if (match) { // Nếu là số
    const number = match[1];
    response.end(`<h1 style='text-align: center; color: green;'>Chi tiết</h1>`);
  }
  else  { // Nếu không phải số, xuất "Có cái nịt"
    response.end("<h1 style='text-align: center; color: blue;'>Có cái nịt</h1>");
  }

}).listen(8081);

console.log('Server running at http://127.0.0.1:8081/');
