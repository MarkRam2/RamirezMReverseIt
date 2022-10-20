// mark ramirez 
// 10/19/2022 
// mini challenge 7# reverse it
// it will ask you for a number ir a word and then give that word or number back words

Console.Clear();
string no;
int wrong = 0;
//---

bool number;
bool Number = false;
long WrongI = 0;
bool wNumber = true;

// idk why wNumber is named this but like i don't know how to change all of them at the same time so i'm not going to
bool playing = true;
while(playing == true)
{
playing = true;

bool yessir = true;
Console.WriteLine($"choose \"word\" or \"number\" ");
string userinput = Console.ReadLine();
while(yessir == true)
{
userinput.ToLower();
if(userinput == "word" ){
yessir = false;
}else if(userinput == "number" ){
yessir = false;
}else{
Console.WriteLine($"no \"word\" or \"number\" not this \"{userinput}\" ");
userinput = Console.ReadLine();
}
}




switch(userinput)
{
case "word":
Console.WriteLine("now please enter a word");
string userinputI = Console.ReadLine();
while(wNumber == true){
    number = Int32.TryParse(userinputI, out wrong);
    if (number == true)
    {
    Console.WriteLine("now please enter a word");
userinputI = Console.ReadLine();
        
wNumber = true;
    }
    else
    {
        Console.WriteLine($"Thank you {userinputI} is in fact a word");
        wNumber = false;
    }
}
    //---------------
    char[] userinputII = userinputI.ToCharArray();
    Console.WriteLine("this is what you gave me");
    for (int i = 0; i < userinputII.Length; i++)
    {
        Console.Write(userinputII[i]);
    }
    // /\ spit's the input back
    Console.WriteLine(" ");
    Console.WriteLine("This is what i see");
    // \/ gives it to you back words
    for (int i = userinputII.Length - 1; i >= 0; i--)
    {
        Console.Write(userinputII[i]);
    }
        Console.WriteLine(" ");
    break;
//------------------------------------
case "number" :
Console.WriteLine("enter a number");
        string IntInput = Console.ReadLine();
while(wNumber == true ){
    Console.WriteLine("enter a number");
     IntInput = Console.ReadLine();
        Number = Int64.TryParse(IntInput, out WrongI);
        if (Number == true)
        {
            Console.WriteLine($"{IntInput} is a number");
         wNumber = false;
        }else
        {
           
        wNumber = true;
        }
}

char[] IntInputII = IntInput.ToCharArray();
    Console.WriteLine("this is what you gave me");
    for (int i = 0; i < IntInputII.Length; i++)
    {
        Console.Write(IntInputII[i]);
    }
    // /\ spit's the input back
    Console.WriteLine(" ");
    Console.WriteLine("This is what i see");
    // \/ gives it to you backwords
    for (int i = IntInputII.Length - 1; i >= 0; i--)
    {
        Console.Write(IntInputII[i]);
    }
        Console.WriteLine(" ");


    break;
}
    bool Yessir = true;
Console.WriteLine($"want to play again");
string responce = Console.ReadLine();
while(Yessir == true)
{
responce.ToLower();
if(responce == "yes" ){
Yessir = false;
playing = true;
}else if(responce == "no" ){
Yessir = false;
playing = false;
}else{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
}
}
}