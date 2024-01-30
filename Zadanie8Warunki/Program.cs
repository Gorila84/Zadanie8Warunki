Console.WriteLine("Podaj swój wynik z matematyki: ");
var enteredMathResult = Console.ReadLine();
Int32.TryParse(enteredMathResult, out int mathCandidateResult);

Console.WriteLine("Podaj swój wynik z chemii: ");
var enteredChemResult = Console.ReadLine();
Int32.TryParse(enteredChemResult, out int chemCandidateResult);

Console.WriteLine("Podaj swój wynik z fizyki: ");
var enteredPhisicsResult = Console.ReadLine();
Int32.TryParse(enteredPhisicsResult, out int physicsCandidateResult);

int sumOfPointCandidate = mathCandidateResult + physicsCandidateResult + chemCandidateResult;
int sumMathResultAndChemResult = mathCandidateResult + chemCandidateResult;
int sumMathResultAndPhisicsResult = mathCandidateResult + physicsCandidateResult;

int minMathResult = 70;
int minChemResult = 55;
int minPhysicsResult = 45;

if ((mathCandidateResult > minMathResult && 
   chemCandidateResult > minChemResult &&
   minPhysicsResult > minPhysicsResult &&
   sumOfPointCandidate > 180) ||  
   sumMathResultAndChemResult > 150 || 
   sumMathResultAndPhisicsResult > 150)
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}