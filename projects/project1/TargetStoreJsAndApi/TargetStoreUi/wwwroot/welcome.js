const welcomespan = document.querySelector(".welcome");

if (!sessionStorage.user) {
    location.href = "index.html";
}
else {
    let user = JSON.parse(sessionStorage.getItem('user'));
    console.log(user);
    welcomespan.innerHTML = `${user.fname}`;
}

// offer choices to navigate 

// choose a store to shop from 

// log out