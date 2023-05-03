function changeColor(){
    var textColor=document.getElementById("text");
    var red =document.getElementById("red").value;
    var green =document.getElementById("green").value;
    var blue =document.getElementById("blue").value;
            
  
    textColor.style.color=`rgb(${red},${green},${blue})`;
    document.getElementById("redValue").innerHTML=Math.round(red);
    document.getElementById("greenValue").innerHTML=Math.round(green);
    document.getElementById("blueValue").innerHTML=Math.round(blue);
 
}
document.getElementById("red").addEventListener("input",changeColor)
document.getElementById("green").addEventListener("input",changeColor)
document.getElementById("blue").addEventListener("input",changeColor)