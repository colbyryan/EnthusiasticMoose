using System;
Main();

void Main()
{

    //These three lines write the text inside the () out to the console

    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine();


    //Creates a fucntion MooseSays that takes in a string argument and sets is equal to message
    void MooseSays(string message)
    {
        Console.WriteLine($@"
                                           _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }

    //Runs the MooseSays function and takes in the string that is then stored in 'message' 
    MooseSays("Hi, I am a moose");

    //Creates a true or false variable called MooseAsks that takes in a string argument and sets it equal to question. 
    bool MooseAsks(string question)
    {
        //Writes whatever question you pass into MooseAsks and adds (Y/N): to the end of the question
        Console.Write($"{question} (Y/N): ");
        //Creates a string variable called answer and sets it equal to whatever the user puts on 
        //input line that is populated because of ReadLine() then it takes whatever the enter and makes it lower case
        string answer = Console.ReadLine().ToLower();
        //saying while answer is not equal to y or n rewrite the question and ReadLine()
        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }
        //Now its saying if the user enters y return the boolean true 
        if (answer == "y")
        {
            return true;
        }
        //Any other answer return false, but since we said if answer is not equal to y or n return the question again it will only
        //return false if the user enters n 
        else
        {
            return false;
        }
    }
    //Calls the MooseAsks function and passes it a string to set equal to question
    MooseAsks("Are you happy?");

    void CanadaQuestion()
    {
        bool isTrue = MooseAsks("Is Canada real?");
        if (isTrue)
        {
            MooseSays("Really? It seems very unlikely");
        }
        else
        {
            MooseSays("I knew it!");
        }
    }

    void EnthusiasticQuestion()
    {
        bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
        if (isEnthusiastic)
        {
            MooseSays("Yay!");
        }
        else
        {
            MooseSays("You should try it");
        }
    }

    void LoveCSharpQuestion()
    {
        bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
        if (doesLoveCSharp)
        {
            MooseSays("Good job sucking up to your instructor!");
        }
        else
        {
            MooseSays("You will...oh, yes, you will!");
        }
    }

    void SecretQuestion()
    {
        bool wantsSecret = MooseAsks("Do you want to know a secret?");
        if (wantsSecret)
        {
            MooseSays("Me Too!! I love secrets.. tell me one!");
        }
        else
        {
            MooseSays("Oh, no... secrets are the best, I love to share them!");
        }
    }

    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
}