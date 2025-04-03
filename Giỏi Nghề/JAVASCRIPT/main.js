hong = document.getElementById('pink')
violet = document.getElementsByClassName('violet')
a = document.getElementsByTagName('a')
p = document.querySelectorAll("p");
for(let element of p){
    if(element.className.includes("vi")){
        element.style.fontWeight = "600"
    }
}
pink.style.color = "pink"
a[0].style.textDecoration = "none"
for(let element of violet){
    element.style.color = "violet"
}

tendn = document.querySelector('#tendn');
sdt = document.querySelector('#sodt');
error_sdt = document.querySelector(".error_sdt");


document.getElementById("sodt").addEventListener("keypress", function (event){
    if(event.key < "0" || event.key > "9"){
        event.preventDefault();
        document.querySelector('#loi').innerText = "chi dc nhap so"
    }
    else{

        document.querySelector('#loi').innerText = ""
    }
});

document.querySelector('#tendn').addEventListener("blur", function(){
    temp = this.value.trim()
    if(temp.includes("@")){
        document.querySelector('#loiten').innerText = "ten dang nhap ko chua @"
    }
})

function submited(){
    if(tendn.value.trim() == ""||email.value.trim() == ""){
        alert("rong")
    }
}


console.log(pink)
console.log(violet)
console.log(a)
console.log(p)

