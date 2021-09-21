
const register = document.querySelector(".registerform");

register.addEventListener('submit', (e) => {
	e.preventDefault();
	const fname = register.fname.value;
	const lname = register.lname.value;

	const userData = { CustomerId: -1, Fname: fname, Lname: lname }

	//POST fetch request
	fetch(`customer/register`, {
		method: 'POST',
		headers: {
			'Accept': 'application/json',
			'Content-Type': 'application/json'
		},
		body: JSON.stringify(userData)
	})
		.then(res => {
			if (!res.ok) {
				console.log('unable to login the user')
				throw new Error(`Network response was not ok (${res.status})`);
			}
			else {
				return res.json();
            }
		})
		.then(res => {
			console.log(res);
			//res.textContent = `Welcome, ${res.fname} ${res.lname}`;
			//let user = sessionStorage.getItem('user');
			//return res;
		})
		.catch(err => console.log(`There was an error ${err}`));
});