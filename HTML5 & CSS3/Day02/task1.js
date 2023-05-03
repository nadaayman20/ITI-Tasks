if (
  typeof window.localStorage == "undefined" ||
  typeof window.sessionStorage == "undefined"
)
  (function () {
    var Storage = function (type) {
      function createCookie(cookieName, cookieValue, expireDate = "") {
        document.cookie =
          cookieName +
          "=" +
          cookieValue +
          (expireDate != "" ? ";expires=" + expireDate : ";");
      }
      function readCookie(cookieName) {
        if (hasCookie(cookieName)) {
          var cookieStr = document.cookie.slice(
            document.cookie.indexOf(cookieName)
          );
          var startSplitIndex = cookieStr.search("=");
          var endSplitIndex =
            cookieStr.search(";") > 0
              ? cookieStr.search(";")
              : cookieStr.length;
          var cookieValue = cookieStr.substring(
            startSplitIndex + 1,
            endSplitIndex
          );
          return cookieValue;
        } else return "";
      }
      function deleteCookie(cookieName) {
        if (hasCookie(cookieName)) {
          var date = new Date();
          date.setMonth(date.getMonth() - 1);
          document.cookie = cookieName + "=;expires=" + date.toUTCString();
          return true;
        }
      }
      function setData(data) {
        data = JSON.stringify(data);
        if (type == "session") {
          window.name = data;
        } else {
          createCookie("localStorage", data, 365);
        }
      }
      function clearData() {
        if (type == "session") {
          window.name = "";
        } else {
          createCookie("localStorage", "", 365);
        }
      }
      function getData() {
        var data = type == "session" ? window.name : readCookie("localStorage");
        return data ? JSON.parse(data) : {};
      }

      var data = getData();
      return {
        length: 0,
        clear: function () {
          data = {};
          this.length = 0;
          clearData();
        },
        getItem: function (key) {
          return data[key] === undefined ? null : data[key];
        },
        removeCookie: function (cookieName) {
          deleteCookie(cookieName);
        },
        ReadCookie: function (cookieName) {
          readCookie(cookieName);
        },
        CreateCookie: function (cookieName, value, expire) {
          createCookie(cookieName, value, expire);
        },
        key: function (i) {
          // not perfect, but works
          var ctr = 0;
          for (var k in data) {
            if (ctr == i) return k;
            else ctr++;
          }
          return null;
        },
        removeItem: function (key) {
          delete data[key];
          this.length--;
          setData(data);
        },
        setItem: function (key, value) {
          data[key] = value + ""; // forces the value to a string
          this.length++;
          setData(data);
        },
      };
    };

    if (typeof window.localStorage == "undefined")
      window.localStorage = new Storage("local");
    if (typeof window.sessionStorage == "undefined")
      window.sessionStorage = new Storage("session");
  })();

    conditionizr.add("NoLocalStorage", function () {
        return !window.localStorage;
      });
      
      conditionizr.add("NoSessionStorage", function () {
        return !window.sessionStorage;
      });
      
      conditionizr.polyfill("conditionizr.js",["!cookie"]);
      conditionizr.on("cookie",function(){
        console.log("succeeded")
      })
    