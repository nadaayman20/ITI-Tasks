var video=document.getElementById('video');
var progres=document.getElementById("progres")
var playBtn=document.getElementById("play");
var stopBtn=document.getElementById("stop");
var startBtn=document.getElementById("start");
var backBtn=document.getElementById("back");
var forwardBtn=document.getElementById("forward");
var endBtn=document.getElementById("end");
var muteBtn=document.getElementById("Muted");
var currTime=document.getElementById("curTime")
var endTime=document.getElementById("endTime")

progres.addEventListener("click",(e)=>{
    let pos=
    (e.pageX-progres.offsetLeft - progres.offsetParent.offsetLeft) /
    progres.offsetWidth;
    video.currentTime = pos * video.duration;
});
setInterval(function(){
    progres.value=Math.round(
        (video.currentTime / video.duration) * 100  
    );
    currTime.innerHTML=( video.currentTime).toFixed();
    endTime.innerHTML=( video.duration).toFixed();
},100)

playBtn.addEventListener("click",function(){
    video.play();
})
stopBtn.addEventListener("click",function(){
    video.pause();
})
startBtn.addEventListener("click",function(){
   video.currentTime=0;
})
backBtn.addEventListener("click",function(){
    video.currentTime -= 5;
 })
 forwardBtn.addEventListener("click",function(){
    video.currentTime += 5;
 })
endBtn.addEventListener("click",function(){
    video.currentTime=video.duration;
 })
muteBtn.addEventListener("click",function(){
    if(muteBtn.innerHTML=="Mute"){
        muteBtn.innerHTML="Unmite"
        video.volume=0;
        document.getElementById("vol").innerHTML=0
        document.getElementById("vol-control").value=0
    }
    else{
        muteBtn.innerHTML="Mute"
        video.volume=0.5;
        document.getElementById("vol").innerHTML=50
        document.getElementById("vol-control").value=50

    }
})
function thisVolume(volume_value)
    {   
        document.getElementById("vol").innerHTML=volume_value;
        video.volume = volume_value / 100;        
    }

function outputUpdate(speedDisplay) {

    document.querySelector('#playbackrate').value = speedDisplay;
    
}
function outputSpeed() { 
    
    video.playbackRate = document.querySelector('#playbackrate').value;
    
}