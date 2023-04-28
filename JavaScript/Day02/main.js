////////////  Task 1 ///////////////////////

// var str = prompt('Enter a string: ');
// var letter = prompt('Enter a letter : ');
// var count = 0;

// function countNumber(str, letter) {
//     for (var i = 0; i < str.length; i++) {
//         if (str.charAt(i) == letter) {
//             count += 1;
//         }
//     }
//     return count;
// }
// if(confirm("You Want to Case Senestive ?")){
//     var result = countNumber(str, letter);
// }
// else{
    
//     result = countNumber(str.toLowerCase(), letter.toLowerCase());
// }
// console.log(result);

// //////////////////// Task 2//////////////////

// var str = prompt('Enter a string: ');

// function Palindrome(str) {
       
//     for (var i = 0; i < str.length / 2; i++) {

//         if (str[i] !== str[str.length  - 1 - i]) {

//             return str + " "+ 'It is not a palindrome';
//         }
//     }
//     return str +" "+ 'It is a palindrome';
// }
// if(confirm("You Want to Case Senestive ?")){
//     var value = Palindrome(str);
// }
// else{
    
//     var value = Palindrome(str.toLowerCase());
// }
// console.log(value);

/////////////// Task 3 ///////////////////////

// function largestWord(str) {
//     var strSplit = str.split(' ');
//     var largestSize= 0;
//     var Word;
//     for(var i = 0; i < strSplit.length; i++){
//       if(strSplit[i].length > largestSize){
//         largestSize = strSplit[i].length;
//         Word=strSplit[i]
//        }
//     }
//     return Word;
//   }

// console.log(largestWord("this is a javascript string demo"));

////////////////// Task 4 //////////////////////
// var userName , phoneNum, mobileNum, email, color;
// do{
//    userName=prompt("Enter Your Name ");

// }while(userName.match(/[A-Za-z]/gi) === null);

// do{
//     phoneNum=prompt("Enter Your Phone ");
 
// }while(phoneNum.match(/^[0-9]{8}$/g) === null);
// do{
//    mobileNum=prompt("Enter Your Mobile ");

// }while(mobileNum.match(/^01[0125][0-9]{8}$/g) === null);

// do{
//    email=prompt("Enter Your Email ");

// }while(email.match(/[a-z0-9]@[a-z].[a-z]{2,3}/g) === null);

// color = Number(window.prompt("Enter a Color"));
// switch(color){
//    case 1:    
//       document.write(`<p style="color:red"> Welcome dear guest  ${userName} </p>`);
//       document.write(`<p style="color:red"> Your Telephone number is  ${phoneNum} </p>`);
//       document.write(`<p style="color:red"> Your Mobile number is${mobileNum} </p>`);
//       document.write(`<p style="color:red"> Your Email address is  ${email} </p>`);
//       break;

//    case 2:
//       document.write(`<p style="color:green"> Welcome dear guest  ${userName} </p>`);
//       document.write(`<p style="color:green"> Your Telephone number is  ${phoneNum} </p>`);
//       document.write(`<p style="color:green"> Your Mobile number is${mobileNum} </p>`);
//       document.write(`<p style="color:green"> Your Email address is  ${email} </p>`);
//       break;

//    case 3:
//       document.write(`<p style="color:blue"> Welcome dear guest  ${userName} </p>`);
//       document.write(`<p style="color:blue"> Your Telephone number is  ${phoneNum} </p>`);
//       document.write(`<p style="color:blue"> Your Mobile number is${mobileNum} </p>`);
//       document.write(`<p style="color:blue"> Your Email address is  ${email} </p>`);
//       break;

//       default:
//          document.write(`<p > Welcome dear guest  ${userName} </p>`);
//          document.write(`<p > Your Telephone number is  ${phoneNum} </p>`);
//          document.write(`<p > Your Mobile number is${mobileNum} </p>`);
//          document.write(`<p > Your Email address is  ${email} </p>`);
//          break;

// }

///////////////////////// Task 5 /////////////////
// function dispVal(object,key){
//    return object[key];
// }
//    var obj={
//       name:"ali",
//       age:10
//     }

// console.log(dispVal(obj,"age"));

/////////////////////  Task 6 //////////////////


// var arr= [];
// for(var i =0; i< 5; i ++){
//    arr[i]=Number(prompt("enter element of array"));
// }
// document.write("<p style='color:red'>u've entered the value of " +  arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "</p>");

// arr.sort(function(a, b){
//    return a-b
// });
// document.write("<p style='color:red'>u've entered the value of " +  arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "</p>");

// arr.sort(function(a, b){
//    return b-a
// });

// document.write("<p style='color:red'>u've entered the value of " +  arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4] + "</p>");

/////////////////////// Task 7 /////////////////////
// var radius;
// do {
//   radius = Number(prompt("What is the value of your circle radius"));
// } while (radius == null);
// confirm("Total area of circle is " + Math.PI * radius * radius);

// var num;
// do {
//   num = Number(prompt("What is the value you want to calculate  its square root"));
// } while (num == null);
// confirm("Square root of " + num + " is " + Math.sqrt(num)); 

// var angle;
// do {
//   angle = Number(prompt("What is the value you want to calculate its cos value"));
// } while (angle == null);
// var rad = Math.PI;
// confirm("cos(" + angle + ") is " + Math.cos((angle / 180) * rad));
