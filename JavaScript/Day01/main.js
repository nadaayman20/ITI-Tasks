/////////////// Task 1//////////////
var message = window.prompt("Enter a Message");
for (i=1 ; i<=6 ; i++){
    document.write("<h"+i+">" + "Message" + "</h"+i+">");
}



/////////////// Task 2 //////////////
var sum =0
do{
    var num =Number(window.prompt("Enter a Number"));
    sum +=num;

}while(num != 0 && sum < 100)
console.log("The Sum is ",sum);

/////////////// Task 3 //////////////

var min =0,max=0;
var num1 =Number(window.prompt("Enter a First Number"));
var num2 =Number(window.prompt("Enter a Second Number"));

while(num1== num2){
    var num2 =Number(window.prompt("Enter a Second Number"));
}
if (num1<num2){
    min=num1;
    max=num2;
}
else{
   min=num2;
   max= num1
}
for(var i=min ; i <=max; i++){
    if(i % 2==0){
         console.log("%c Even Number", "color:red;", i);
    }
    else{
         console.log("%c Odd Number", "color:blue;", i);
    }
}


   

