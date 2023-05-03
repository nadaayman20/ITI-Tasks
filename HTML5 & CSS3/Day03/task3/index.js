let canv=document.getElementById("canvas")
let ctx=canv.getContext("2d");
let img=new Image()
img.src="./img.png"
img.onload=()=>{
    ctx.drawImage(img,0,0,500,500)
    ctx.font="50px sans-serif";
    ctx.shadowColor="white";
    ctx.shadowBlur=10;
    ctx.lineWidth=3;
    ctx.shadowOffsetX=1
    ctx.shadowOffsety=1
    ctx.strokeText("Its gonna be okay",50,450)
}

