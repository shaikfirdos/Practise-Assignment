function Logger(constructor: Function) {
    console.log('logging the data');
    console.log(constructor);
}

@Logger//decorator
class Person {
 
    name = 'Firdos';
    constructor()
    {
        console.log('object creation');
    }
}
const person = new Person();
console.log(person);
console.log('Hello world');


function onlineAttendance(data: Function) {
    console.log("your are present");

}

@onlineAttendance//decorator- the decorator funcction will cal firstly. 
class employee {
    id = 1092;
    public data() {
        console.log("ur registered successfully");
    }
}
var checked = new employee();
console.log(checked);

