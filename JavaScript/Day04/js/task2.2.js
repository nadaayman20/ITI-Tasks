var Marble = document.querySelectorAll("img");
var counter=1;
var timer;
  function start(){
      timer = setInterval(() => {
        switch(counter){
            case 1:
                for (var i = 0; i < Marble.length; i++) {
                   switch(i){
                      case 3:
                        Marble[i].src = "./images/marble1.jpg";
                        break;
                        default:
                            Marble[i].src = "./images/marble2.jpg";
                        break;
                   } }
                  counter++;
            break;
            case 2:
                for (var i = 0; i < Marble.length; i++) {
                    switch(i){
                       case 3:
                         Marble[i].src = "./images/marble3.jpg";
                         break;
                         default:
                             Marble[i].src = "./images/marble1.jpg";
                         break;
                    }}
                   counter++;
            break;
            case 3:
                for (var i = 0; i < Marble.length; i++) {
                    switch(i){
                       case 3:
                         Marble[i].src = "./images/marble1.jpg";
                         break;
                         default:
                             Marble[i].src = "./images/marble3.jpg";
                         break;
                    }}
                   counter=1;
            break;           
        }       
    }, 400); }
function stop(){
    clearInterval(timer);
}
