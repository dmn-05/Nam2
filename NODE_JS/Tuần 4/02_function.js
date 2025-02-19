let a = 5;
let obj = {a:a};
function tang (x){
    x.a++;
}
tang(obj);
console.log(obj.a);