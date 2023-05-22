let nums = [1, 2, 3, 4, 5];
let iterator = nums[Symbol.iterator]();

for (i in nums) {
    console.log(i);
}

console.log(iterator.next());
console.log(iterator.next());
console.log(iterator.next());
console.log(iterator.next());
console.log(iterator.next());
console.log(iterator.next());




