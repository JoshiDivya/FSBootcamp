let random_number = Math.floor(Math.random() * 21);

console.log(random_number);

let ele_msg = document.getElementById("message");
let ele = document.getElementById("guessNumber");
let count = 1;

function askUserForGuess() {
  if(count<4)
  alert("Try Again you have more attempts");
  else
  alert("You lost");
}

function checknumber() {
  let guess_number = ele.value;
  if (guess_number === random_number) {
    ele_msg.innerHTML = "Congratulations! You won";
  } else if (random_number > guess_number) {
    ele_msg.innerHTML = "Number is larger than you guess";
  } else if (random_number < guess_number)  {
    ele_msg.innerHTML = "Number is smaller than you guess";
  }
  count++;
}

// function isCorrect(){
//     if(guess === random_number)
//     return true;
//     else
//     return false;
// }
// isCorrect();
