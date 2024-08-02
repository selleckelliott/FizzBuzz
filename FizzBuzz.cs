FizzBuzz
// Write a public method that accepts a number
// when the number is divisible by 3 return the word fizz

// when the number is divisible by 5 return the word buzz

// when the number is divisible by both, return the word fizzbuzz

public string FizzBuzz (int num)
{
    //divisible by 3 and 5
    if (num % 3 == 0 && num % 5 == 0)
    {
        return "fizzbuzz";
    }
    //divisible by 3
    else if (num % 3 == 0)
    {
        return "fizz";
    }
    //divisible by 5
    else if (num % 5 == 0)
    {
        return "buzz"
    }
    else
    {
        return num;
    }
}