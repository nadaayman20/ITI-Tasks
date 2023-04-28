var win;
var timer;
var heightScrene = innerHeight;
var widthScrene = innerWidth;


function openChild(){
   win= open("./child.html","_blank","width=200, height=200");
   win.resizeTo(200,200);
}

function moveChild(){
   var scrollDown = true;
   timer = setInterval(function(){
      if(scrollDown && win.screenY + win.innerHeight < heightScrene){
         win.moveBy(100, 100);
         win.resizeTo(200,200);
         win.focus();
      } 
       else{
         scrollDown=false;
         if(win.screenY >= 0 && !scrollDown){
            win.moveBy(-100,-100);
            win.resizeTo(200,200);
            win.focus();       
            if(win.screenY == 0)
               scrollDown=true;
         }

      } }, 200);
     
   }
   
function closeChild(){
   win.close();
   clearInterval(timer);
}


