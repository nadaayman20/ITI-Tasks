var selectSong = document.getElementById("selectSong");
var Song = document.getElementById("Song");
var image = document.getElementById("Image");

selectSong.addEventListener("change", function () {
  Song.src = "Songs/" + this.value + ".mp3";
  image.src = "images/" + this.value + ".jpg";
});