var obj={
    name:"Nada",
    address:"Cairo",
    age:23
}
var handler = {
    set(target, prop, value) {
      if ( target.hasOwnProperty(prop) && prop == "age" && typeof value === "number") 
      {
        if (value <= 60 && value >= 25) target[prop] = value;
        else throw `invalid range of age`;
      } 
      else if ( target.hasOwnProperty(prop) && prop == "address" && typeof value === "string" && value instanceof String ) {
        if (typeof value === "string") target[prop] = value;
        else throw `invalid type`;
      } 
      else if (target.hasOwnProperty(prop) && prop == "name" && typeof value === "string")
        if (typeof value === "string" && value.length === 7) target[prop] = value;
        else throw `invalid range of name`;
      
       
    },
    get(target, prop) {
      if (target.hasOwnProperty(prop))
      {
        return target[prop];
      } 
      else {
        throw  `${prop} is not a valid property`;
      }
    },
  };
  
  var myProxy = new Proxy(obj, handler);
  myProxy.Age = 60; 
  myProxy.Address = "Cairo"; 
  myProxy.Name = "abcdefg"; 

