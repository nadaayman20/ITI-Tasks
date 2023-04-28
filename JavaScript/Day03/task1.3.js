var advWindow;
function openAdvertisement(){
    advWindow=open("./advertising.html","_blank","width=450, height=450 , top=50");

    var scrollAdvertising =setInterval(function(){
        if(advWindow.scrollY <= innerHeight){
            advWindow.scrollBy(0,30);
        }
        else{
            clearInterval(scrollAdvertising);
            advWindow.close();
        }
          

    },200)
}