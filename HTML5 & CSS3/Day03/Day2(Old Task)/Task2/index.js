let canv=document.getElementById("canvas");
let ctx = canv.getContext("2d");
ctx.beginPath()
ctx.moveTo(0,0)
ctx.lineWidth=4;
let x=10
let y=10
 let inte=setInterval(() => {
    if(x<=ctx.canvas.width||y<=ctx.canvas.height){
        ctx.lineTo(x,y)
        ctx.stroke()
        x+=10
        y+=10
    }
    else {
        clearInterval(inte); 
        alert("Animation End")
    }
}, 100);
