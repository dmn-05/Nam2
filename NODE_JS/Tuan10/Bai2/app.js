var express = require('express');
var app = express();

app.use(express.static('newsfeed'));
app.get('/', function (req, res) {
    res.sendFile(__dirname + "/newsfeed/" + "index.html");
});

var server = app.listen(8081, function () {
    var host = server.address().address;
    var port = server.address().port;
    if (host === '::' || host === '0.0.0.0') {
        host = 'localhost';
    }
    console.log(`Example app listening at http://${host}:${port}`);
});