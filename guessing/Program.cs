using System;
main();
void ISay( string message){
    Console.WriteLine($@"



       .--'''''''''--.
     .'      .---.      '.
    /    .-----------.    \
   /        .-----.        \
   |       .-.   .-.       |
   |      /   \ /   \      |
    \    | .-. | .-. |    /
     '-._| | | | | | |_.-'
         | '-' | '-' |
          \___/ \___/
       _.-'  /   \  `-._
     .' _.--|     |--._ '.  {message}
     ' _...-|     |-..._ '
            |     |
            '.___.'
              | |
    ");
}

void main () {
Random rnd = new Random();
int secretNumber =rnd.Next(1,101);
    ISay("choose a difficulty: cheater, easy, medium or hard");
string choice =Console.ReadLine();
    if(choice == "easy"){
 ISay("Guess the Secret Number(1-100), you have 8 Guesses ");
for(int i =0; i<8; i++){
string guess =Console.ReadLine();
int guessInt = int.Parse(guess);

if(guessInt == secretNumber){
ISay("You got it");
break;
}

else if(i<7 && guessInt> secretNumber){
    ISay($"Your guess is too high, you have used {i + 1} out of 8 guesses");
}
else if(i<7 && guessInt < secretNumber){
    ISay($"Your guess is too low, you have used {i + 1} out of 8 guesses");
}
else{
    ISay("You lose, You have run out of guesses");
    break;
}
}
    }
    else if(choice == "medium"){
        ISay("Guess the Secret Number(1-100), you have 6 Guesses ");
for(int i =0; i<6; i++){
string guess =Console.ReadLine();
int guessInt = int.Parse(guess);

if(guessInt == secretNumber){
ISay("You got it");
break;
}

else if(i<5 && guessInt> secretNumber){
    ISay($"Your guess is too high, you have used {i + 1} out of 6 guesses");
}
else if(i<5 && guessInt < secretNumber){
    ISay($"Your guess is too low, you have used {i + 1} out of 6 guesses");
}
else{
    ISay("You lose, Maybe try on Easy ");
    break;
}
}
    }
    else if(choice == "hard"){
 ISay("Guess the Secret Number(1-100), you have 4 Guesses ");
for(int i =0; i<4; i++){
string guess =Console.ReadLine();
int guessInt = int.Parse(guess);

if(guessInt == secretNumber){
ISay("You got it");
break;
}

else if(i<3 && guessInt> secretNumber){
    ISay($"Your guess is too high, you have used {i + 1} out of 4 guesses");
}
else if(i<3 && guessInt < secretNumber){
    ISay($"Your guess is too low, you have used {i + 1} out of 4 guesses");
}
else{
    ISay("You lose, Maybe try on Medium");
    break;
}
}
    }
    else if(choice == "cheater"){
        ISay("Guess the Secret Number(1-100), you have 100000 Guesses ");
for(int i =0; i<100000; i++){
string guess =Console.ReadLine();
int guessInt = int.Parse(guess);

if(guessInt == secretNumber){
ISay("You got it");
break;
}

else if(i<100000 && guessInt> secretNumber){
    ISay($"Your guess is too high, you have used {i + 1} out of 100000 guesses");
}
else if(i<100000 && guessInt < secretNumber){
    ISay($"Your guess is too low, you have used {i + 1} out of 1000000 guesses");
}
else{
    ISay("You lose, Maybe give up");
    break;
}
}
    }

}

