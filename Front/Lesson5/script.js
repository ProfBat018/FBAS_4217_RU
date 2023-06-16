async function fetchAsync () {
let res = await fetch('https://jsonplaceholder.typicode.com/todos/1')
    .then(response => response.json())
    // .then(json =>
    // {
    //     setTimeout(() => {
    //         console.log(json)
    //     }, 10);
    // })
    .then(json => console.log(json))
    .catch(error => console.log(error))
    .finally(() => console.log('finally'));
}

fetchAsync();


