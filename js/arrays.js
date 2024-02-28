//let daysOfWeek = [
//  "Sunday",
//  "Mondey",
//  "Tuesday",
//  "Wednesday",
//  "Thursday",
//  "Friday",
//  "Saturda",
//];
//
//for (let i = 0; i < daysOfWeek.length; i++) {
//  console.log(daysOfWeek[i]);
//}
//
//const fibonacci = [];
//fibonacci[1] = 1;
//fibonacci[2] = 1;
//
//for (let i = 3; i < 20; i++) {
//  fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
//}
//
//for (let i = 1; i < fibonacci.length; i++) {
//  console.log(fibonacci[i]);
//}

//inserindo elemento ao final do array
let numbers = [0, 1, 2, 3];

//inserindo um elemento na primeira posição
Array.prototype.insertFirstPosition = function (value) {
  for (let i = this.length; i >= 0; i--) {
    this[i] = this[i - 1];
  }
  this[0] = value;
};

Array.prototype.reIndex = function (array) {
  const newArray = [];
  for (let i = 0; i < array.length; i++) {
    if (array[i] !== undefined) {
      newArray.push(array[i]);
    }
  }

  return newArray;
};

Array.prototype.removeFirstPosition = function () {
  for (let i = 0; i < this.length; i++) {
    this[i] = this[i + 1];
  }
  return this.reIndex(this);
};

numbers = numbers.removeFirstPosition();

for (let i = 0; i < numbers.length; i++) {
  console.log(numbers[i]);
}
