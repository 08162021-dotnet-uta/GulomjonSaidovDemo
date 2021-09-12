// const numOfJokes = document.getElementsByTagName("five");
// // console.log(numOfJokes.value);
// for (let i = 0; i < numOfJokes.length; i++) {
//   numOfJokes[i].addEventListener("click", callback(i));
// }


fetch(`http://api.icndb.com/jokes/random/5`,)
  .then(res => res.json())
  .then(res => {
    console.log(res)
    return res;
  })
  .then(res => {


    const pTags = document.getElementsByTagName('p');

    for (let i = 0; i < pTags.length; i++) {
      pTags[i].innerHTML = res.value[i].joke;
    }
  });

