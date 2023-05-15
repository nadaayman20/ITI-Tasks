class polygon{
    constructor(w,h){
        this.width=w;
        this.height=h;    
    }
}
class Rectangle extends polygon{
    constructor(w,h){
        super(w, h);
        
    }
    toString() {
        return `Area Of Rectangle: ${this.height * this.width} `
     }
     draw() {
        let ctx = document.getElementById("canvas").getContext("2d");
        ctx.fillStyle = "#f00";
        ctx.fillRect(380, 200, this.width, this.height);
      }}

class Square extends Rectangle{
    constructor(w){
        super(w,w);  
    }
    toString() {
        return `Area Of Square: ${this.height * this.width} `
     }
     draw() {
        let ctx = document.getElementById("canvas").getContext("2d");
        ctx.fillStyle = "#0f0";
        ctx.fillRect(280, 100, this.width, this.height);
      }}

class Circle extends polygon{
    constructor(w){
        super(w);  
    }
    toString() {
        return `Area Of Circle: ${Math.PI * this.width ** 2} `
     }
     draw() {
        let ctx = document.getElementById("canvas").getContext("2d");
        ctx.fillStyle = "#00f";
        ctx.beginPath();
        ctx.arc(200, 300, this.width, 0, 2 * Math.PI);
        ctx.fill();
      }}

class Triangle extends polygon{
    constructor(w,h){
        super(w,h);  
    }
    toString() {
        return `Area Of Triangle: ${0.5 * this.width * this.height} `
     }
     draw() {
        let ctx = document.getElementById("canvas").getContext("2d");
        ctx.fillStyle = "#000";
        ctx.beginPath();
        ctx.moveTo(this.height, this.height);
        ctx.lineTo(this.height, this.width);
        ctx.lineTo(this.width, this.width);
        ctx.fill();  
}}

var R = new Rectangle(100,70);
console.log(R.toString());
R.draw()

var S = new Square(80);
console.log(S.toString());
S.draw()

var C = new Circle(50);
console.log(C.toString());
C.draw();

var T = new Triangle(200,100);
console.log(T.toString());
T.draw()