const prompt = require('prompt-sync')();
var num = parseInt(prompt("Nhap so thap phan: "));
var bin = 0;
while (num != 0) {
    var temp = num % 2;
    bin = bin * 10 + temp;
    num = parseInt(num / 2);
    console.log(num);
}
console.log(bin);