const readline = require('readline');

// Tạo giao diện để đọc dòng lệnh
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Đặt câu hỏi để nhận dữ liệu từ người dùng
rl.question('So can dao nguoc: ', (num) => {
    
    var sodaonguoc = 0;
    while(num != 0){
        let temp =  num % 10;
        sodaonguoc = sodaonguoc * 10 + temp;
        num = Math.floor(num/10);
    }
    console.log(sodaonguoc);
    // Đóng giao diện
    rl.close();
});


