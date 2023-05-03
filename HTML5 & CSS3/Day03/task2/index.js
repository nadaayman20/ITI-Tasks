let canv=document.getElementById("canvas")
let ctx=canv.getContext("2d");
let Grad1=ctx.createLinearGradient(0,50,200,50);
Grad1.addColorStop(0,"#000fa1")
Grad1.addColorStop(.5,"#8d94b5")
Grad1.addColorStop(1,"#a3a7bf")
ctx.fillStyle=Grad1;
ctx.fillRect(0,0,200,200)
let Grad2=ctx.createLinearGradient(20,20,180,180);
Grad2.addColorStop(0,"#000fa1")
Grad2.addColorStop(1,"#FFFFFF")
ctx.arc(100,100,80,0,2*Math.PI)
ctx.fillStyle=Grad2;
ctx.fill()

ctx.beginPath()
ctx.moveTo(70,60)
ctx.lineTo(70,160)
ctx.lineWidth=15
ctx.strokeStyle="white"
ctx.stroke()
ctx.fill();
ctx.beginPath()
ctx.moveTo(67,60)
ctx.lineTo(137,160)
ctx.lineWidth=15
ctx.strokeStyle="white"
ctx.stroke()
ctx.fill();
ctx.beginPath()
ctx.moveTo(130,60)
ctx.lineTo(130,160)
ctx.lineWidth=15
ctx.strokeStyle="white"
ctx.stroke()
ctx.fill();

