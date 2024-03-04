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

// for (let i = 0; i < numbers.length; i++) {
//   console.log(numbers[i]);
// }

function printMatrix(myMatrix) {
  for (let i = 0; i < myMatrix.length; i++) {
    for (let j = 0; j < myMatrix[i].length; j++) {
      console.log(myMatrix[i][j]);
    }
  }
}

let averageTemp = [];
averageTemp[0] = [1, 2, 3];
averageTemp[1] = [4, 5, 6];

//printMatrix(averageTemp);

const matrix3x3x3 = [];
for (let i = 0; i < 3; i++) {
  matrix3x3x3[i] = [];
  for (let j = 0; j < 3; j++) {
    matrix3x3x3[i][j] = [];
    for (let z = 0; z < 3; z++) {
      matrix3x3x3[i][j][z] = i + j + z;
    }
  }
}

//percorrer matrix 3x3x3
for (let i = 0; i < matrix3x3x3.length; i++) {
  for (let j = 0; j < matrix3x3x3[i].length; j++) {
    for (let z = 0; z < matrix3x3x3[i][j].length; z++) {
      matrix3x3x3[i][j][z];
    }
  }
}
