// let obj = new Object(); 
// obj.name = 'Linh'
// console.log(obj)
// obj2 = obj;
// obj2.age = 19;
// console.log(obj)
// console.log(obj2)

// obj2.xuatten = function (){
//     console.log('ten '+ this.name)
// }
// obj2.xuatten();
// console.log(obj2)

function person(){
    this.name = '';
    this.age=0;
    this.xuatten = () => {
        console.log("ten: " + this.name);
    }
}
nh3 = new person;
nh3.name = 'khai';

nh3.xuatten();