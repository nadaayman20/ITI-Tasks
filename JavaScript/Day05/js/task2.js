var moveBtn=document.getElementById("go");
var leftImage=document.getElementById("first");
var rightImage=document.getElementById("second");
var topImage=document.getElementById("third");
var timer;

var leftInterval=parseInt(getComputedStyle(leftImage).left);
var rightInterval=parseInt(getComputedStyle(rightImage).right);
var topInterval=parseInt(getComputedStyle(topImage).bottom)
var value=30;
var ltr=true,rtl=true,scrolUp=true;

function move(){
  if( moveBtn.innerHTML =="go"){
    
    timer =setInterval(function(){

      // Left Image

      if (!isNaN(parseInt(leftImage.style.left))) {
        if ( parseInt(leftImage.style.left) < 450 && ltr==true) {
          leftImage.style.left = parseInt(leftImage.style.left) + value +"px";}
           else {
          ltr = false;
          if (parseInt(leftImage.style.left) > 0 && ltr==false) {
            leftImage.style.left =parseInt(leftImage.style.left) - value +"px";
          } else ltr = true;
        }
      } else {
        leftImage.style.left =leftInterval + value + "px";
      }

    // Right Image
      if(!isNaN(parseInt(rightImage.style.right))){
        if(parseInt(rightImage.style.right)<450 && rtl==true){
          rightImage.style.right=parseInt(rightImage.style.right)+ value+"px";
        }
        else{
          rtl=false;
          if(parseInt(rightImage.style.right)>0 && rtl==false){
            rightImage.style.right=parseInt(rightImage.style.right)-value+"px";

          }
          else{
            rtl=true;
          }
        }

      }
      else{
        rightImage.style.right=rightInterval+ value+"px";
      }
     
      // Top Image
      if(!isNaN(parseInt(topImage.style.bottom))){
        if(parseInt(topImage.style.bottom)<450 && scrolUp==true){
          topImage.style.bottom=parseInt(topImage.style.bottom)+ value+"px";
        }
        else{
          scrolUp=false;
          if(parseInt(topImage.style.bottom)>0 && scrolUp==false){
            topImage.style.bottom=parseInt(topImage.style.bottom)-value+"px";

          }
          else{
            scrolUp=true;
          }
        }

      }
      else{
        topImage.style.bottom=topInterval+ value+"px";
      }
   
    
        moveBtn.innerHTML="stop"

        var src1= document.getElementById("src1");
        src1.innerHTML=`< img src = ${leftImage.getAttribute("src")} left = ${parseInt(leftImage.style.left) + value +"px"} >`;
        src1.style.color="blue"

        var src2= document.getElementById("src2");
        src2.innerHTML=`< img src = ${rightImage.getAttribute("src")} left = ${parseInt(rightImage.style.right) + value +"px"} >`;
        src2.style.color="blue"
    

    },200)

  }
  else{
    moveBtn.innerHTML="go"
    clearInterval(timer);
    
  }

}
function reset(){

    clearInterval(timer);
    moveBtn.innerHTML="go";
    leftImage.style.left=leftInterval;
    rightImage.style.right=rightInterval;
    topImage.style.bottom=topImage;
 
}



