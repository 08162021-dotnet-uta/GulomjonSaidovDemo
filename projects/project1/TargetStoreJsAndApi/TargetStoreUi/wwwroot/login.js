﻿
const loginform = document.querySelector(".loginform");

loginform.addEventListener('submit', (e) => {
	e.preventDefault();
	const fname = loginform.fname.value;
	const lname = loginform.lname.value;

	//GET fetch request
	fetch(`customer/login/${fname}/${lname}`)
		.then(res => {
			if (!res.ok) {
				console.log('unable to login the user')
				throw new Error(`Network response was not ok (${res.status})`);
			}
			return res.json();
		})
		.then(res => {
			console.log(res);
			sessionStorage.setItem('user', JSON.stringify(res));
			let user = sessionStorage.getItem('user');
			console.log(JSON.parse(user));

			location.href = 'welcome.html';
		})
		.catch(err => console.log(`There was an error ${err}`));
});