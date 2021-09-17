(function () {
	fetch("stores/list")
		.then(res => res.json())
		.then(data => {
			console.log(data)
			const stores = document.querySelector('.listofstores');

			for (let x = 0; x < data.length; x++) {
				//const p = document.createElement('p');
				//var btn = document.createElement("BUTTON");
				//btn.innerText = "Check the store";
				
				//p.innerText = `Location - ${data[x].storeName}`;
				//stores.appendChild(p);
				//stores.appendChild(btn);
				stores.innerHTML += `<p>The store is <b>${data[x].storeName}</b> <button class="seeprods" value=${x}>Chck the store</button></p>`;
			}
		});
})();

const seeprosds = document.querySelector('.listofstores');

seeprosds.addEventListener("click", function () {
	fetch("product/lists")
		.then(res => res.json())
		.then(data => {
			console.log(data);
			const lists = document.querySelector('.plists');
			const h2 = document.createElement('h2');
			h2.innerText = "Lists of Products";
			lists.append(h2);
			console.log(lists);
			
			for (let x = 0; x < data.length; x++) {
				lists.innerHTML += `<p> ${data[x].productName} - Description: ${data[x].productDescription} - Price: ${data[x].productPrice}</p>`;
            }
			
		})
})
