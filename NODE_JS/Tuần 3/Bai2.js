a = 123;
b = 9;

max_index = Math.ceil(a/b);

console.log(max_index);

var index = 12

if(max_index < index){

    index = max_index;
}

c = b * index;
if(c > a){
    c = a;
}
for(let i = c - b -1; i < c; i++){
    console.log(i);
}