var searchData = location.search;
searchData = searchData.replace("?", "").replace("%40", "@").split("&");

var data =document.getElementById("data");
var email = document.getElementById("email");
var gender =document.getElementById("gender");
var mobile =document.getElementById("mobile");
var address =document.getElementById("address");
var browser =document.getElementById("browser");
var employe = {};

for (var i = 0; i < searchData.length; i++) {
  var userData = searchData[i].split("=");
  var k = userData[0];
  var v = userData[1];
  employe[k] = v;
}

data.innerHTML ="<h2> Welcome " + employe.title + " "+ employe.name +"</h2>";
email.innerHTML ="<p> Email : "+ employe.email + "</p>";
gender.innerHTML ="<p> Gender : " + employe.gender + "</p>";
mobile.innerHTML ="<p> Mobile : "+ employe.mobile +"</p>";
address.innerHTML = "<p>Address: "+ employe.address+"</p>";

if (navigator.userAgent.match(/chrome|chromium/i)) {
    employe.browser = "Chrome";
    browser.innerHTML = "You are using "+ employe.browser ;
  } 
 else if (navigator.userAgent.match(/opr/i)) {
    employe.browser = "Opera";
    browser.innerHTML = "You are using "+ employe.browser  ;
  } 
  else if (navigator.userAgent.match(/firefox|fxios/i)) {
    employe.browser = "FireFox";
    browser.innerHTML = "You are using "+ employe.browser  ;
  } 
  else{
    employe.browser ="Other Browser"
    browser.innerHTML = "You are using " + employe.browser  ;
  }
