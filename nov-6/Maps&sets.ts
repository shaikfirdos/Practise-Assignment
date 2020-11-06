let mySet = Object.create(null);//It check the value exist or not
//mySet.id = true;
//mySet.id = 1;
mySet.id = 0;

if (mySet.id) {
    console.log("Id is present");
}

let myMap = Object.create(null);
myMap.name = "Sachin";
let val = myMap.name;
console.log(val);

myMap[100] = 123;
console.log(myMap[100]);

myMap[100] = "GoodNight";
console.log(myMap[100]);

console.log('Hello world');