var Marble = document.querySelectorAll('img');
var index=0;
var move=true;
var timer;

function start(){

   timer = setInterval(function(){
        if(index <Marble.length -1 && move == true){
            move =true
            Marble[index].src="./images/marble1.jpg"  
            Marble[++index].src="./images/marble3.jpg"
        }
        else{
            move=false;
            if(!move){
                Marble[index].src="./images/marble1.jpg" 
                Marble[--index].src="./images/marble3.jpg"
            }if(index==0){
                move=true;
            }      
        }
 
    },300)

}

function stop(){
    clearInterval(timer)
}
