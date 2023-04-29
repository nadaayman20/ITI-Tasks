
//Displat Cookie 
var userPhoto = document.getElementById("photo");
getAllCookies();
userPhoto.src=cookieArr.gender;

var date = new Date();
date.setMonth(date.getMonth() + 1);
setCookie("visit", +cookieArr.visit+1, date);
var Massege= document.getElementById("Massege");

Massege.innerHTML = "Welcome <span style='color:"+cookieArr.UserColor+"'>"+cookieArr.UserName+" "+
 "" +"</span> you visited the website <span style='color:"+cookieArr.UserColor+"'>"+(++cookieArr.visit)+"</span> times" ;

