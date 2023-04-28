
var dataTyping =document.getElementById("dataTyping");
var cWin;
var index=0;
var message ="Your Message is : Welcome in javaScript"

function showMessage(){
    cWin= open("./child.html","_blank","width=300, height=300 , top=250");
   cWin.resizeTo(300,300);

   var typing = setInterval(function () {
    if (index < message.length) {
      cWin.dataTyping.innerHTML += message[index++];
    } else {
      clearInterval(typing);
      cWin.close();
    }
  }, 200);
  
}

