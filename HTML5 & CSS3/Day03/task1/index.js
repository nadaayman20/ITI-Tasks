let canv=document.getElementById("canvas");
let ctx=canv.getContext("2d");
let grad=ctx.createLinearGradient(0,0,0,500);
grad.addColorStop(0,"#2196F3");
grad.addColorStop(.5,"#2196f300");
grad.addColorStop(.5,"#4CAF50");
grad.addColorStop(1,"white");
ctx.fillStyle=grad;
ctx.fillRect(0,0,500,500)
ctx.moveTo(175,300)
ctx.lineTo(175,200)
ctx.lineTo(325,200)
ctx.lineTo(325,300)
ctx.lineWidth=4
ctx.stroke()
ctx.beginPath()
