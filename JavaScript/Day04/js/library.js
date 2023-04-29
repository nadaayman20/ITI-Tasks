var genderImg = {
    female: "/images/2.jpg",
    male: "/images/1.jpg",
    
  };
  var cookieArr = [];
  
  if (document.forms.length > 0) {
    document.forms[0].onsubmit = function () {
      var username = document.getElementById("name");
      var age = document.getElementById("age");
      var gender = document.querySelector('input[name="gender"]');
      var list = document.getElementById("list");
  
      var date = new Date();
      date.setMonth(date.getMonth() + 1);
      var profilePic = gender.value == "female" ? genderImg.female : genderImg.male;
  
      setCookie(username.name, username.value, date);
      setCookie(age.name, age.value, date);
      setCookie(gender.name, profilePic, date);
      setCookie(list.name, list.value, date);
      setCookie("visit", "0", date);
    };
  }
  function setCookie(name, value, expires) {
    document.cookie = name + "=" + value + ";expires=" + expires.toUTCString();
  }
  function getCookie(name) {
      return cookieArr[name];
  }
  function getAllCookies(){
      var data = document.cookie.split('; ')
  
      for(var counter = 0;counter<data.length;counter++){
          var key = data[counter].split('=')
          cookieArr[key[0]] = key[1]
      }
  }
  function deleteCookie(name) {
      var date = new Date();
      date.setMonth(date.getMonth() - 1);
    document.cookie = name + '=;expires='+date.toUTCString();
  }
    function clearAllCookies() {
      document.cookie = '';
    }
