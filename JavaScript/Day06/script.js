var allData;

var index=0;
var req=new XMLHttpRequest()
req.open("GET","./rockbands.json")
req.onreadystatechange=function(){
    // console.log(req.readyState)
    if(req.readyState==4 && req.status==200){
        
        allData=JSON.parse(req.responseText)
       console.log(allData)

        var band="";
        for(var data in allData){
            console.log(data)
            band += "<option value='"+data+"'>"+ data +"</option>"
    }
    document.getElementById("band").innerHTML=band;
}
    else{
        return "Faild"
    }
}

req.send('')

var artists 
function getAllArtistw(element) {
    var artist="";
     artists=allData[element.value];
    for(var i =0;i<artists.length;i++){
        index=i
        artist += "<option value='"+artists[i].name +"'>"+ artists[i].name +"</option>"     
    }
    document.getElementById("artist").innerHTML=artist;
}
function openSite(element) {
    open(artists[index].value , "", "width=700,height=700,left=300px,top=50px");
  }
