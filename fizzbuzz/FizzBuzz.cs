using System;

namespace fizzbuzz
{
    public class FizzBuzz
    {
        public string Execute(int input){
            string result = "";
            if(IsDivisibleBy3(input)){
                result += "Fizz";
            }
            if(IsDivisibleBy5(input)) {
                result += "Buzz";
            }
            if(result == String.Empty){
                result = input.ToString();
            }
            return result;
        }

        private bool IsDivisibleBy3(int input) {
            return input % 3 == 0;
        }
        
        private bool IsDivisibleBy5(int input) {
            return input % 5 == 0;
        }
    }
}
