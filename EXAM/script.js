hoisted();
notHoisted();

function hoisted() {
    console.log("foo");
}

const notHoisted = () => {
    console.log("bar");
}






let a = {
    a: 1,
}

let b = {
    a: 1,
}

console.log(a === b);

