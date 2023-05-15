async function FetchData(url) {
    return new Promise(function (success, fail) {
      var xhr = new XMLHttpRequest();
      xhr.open("GET", url);
      xhr.onreadystatechange = function () {
        if (xhr.readyState == 4 ) {
          if (xhr.status == 200) {
            var req = JSON.parse(xhr.responseText);
            success(req);
          } else {
            fail("Bad request");
          }
        }
      };
      xhr.send();
    });
  }
  var tb = document.getElementById("tbody");
  var Data ="";
  FetchData("https://jsonplaceholder.typicode.com/users").then((d) => {
      d.forEach((user) => {
        Data += `<tr>
        <th >${user.id}</th>
        <td>${user.name}</td>
        <td>${user.username}</td>
        <td>${user.email}</td>
        <td>${user.address.suite}, ${user.address.street}, ${user.address.city} </td>
        <td>${user.phone}</td>
        <td><a href="http://${user.website}">${user.website}</a></td>
        <td>${user.company.name}</td>
      </tr>`;
      })
      tb.innerHTML=Data;
      
    })
 