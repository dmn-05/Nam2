const prompt = require('prompt-sync')();
var num = parseInt(prompt("Nhap so dao nguoc: "));
var dem = 0;
var sodaonguoc = 0;
while (num != 0) {
    let temp = num % 10;
    sodaonguoc = sodaonguoc * 10 + temp;
    num = Math.floor(num / 10);
    dem++;
}
console.log(sodaonguoc);
console.log(dem);