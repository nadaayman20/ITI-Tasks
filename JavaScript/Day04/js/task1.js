var image = document.querySelector('img');
var index=1;
var timer;
function nextImages(){
    if(index==6){
          index=1;
    }
    image.src="./images/work-"+ ++index +".jpg";
}
function previousImages(){
    if(index==1){
          index=6;
    }
    image.src="./images/work-"+ --index +".jpg";
}
function slideShow(){
    
    if(index < 6){
        
        image.src="./images/work-"+ ++index +".jpg";
    } else {
        index = 1;
    }
    timer = setTimeout(slideShow, 500);

}
function stop(){
    clearInterval(timer)
}