int minMathResult;
int minChemResult;
int minPhysicsResult;
int mathCandidateResult;
int chemCandidateResult;
int physicsCandidateResult;
int sumOfPointCandidate;
int sumMathResultAndChemResult;
int sumMathResultAndPhisicsResult;

minMathResult = 70;
minPhysicsResult = 55;
minChemResult = 45;

Console.WriteLine("Podaj swój wynik z matematyki: ");
var enteredMathResult = Console.ReadLine();
Int32.TryParse(enteredMathResult, out mathCandidateResult);

Console.WriteLine("Podaj swój wynik z chemii: ");
var enteredChemResult = Console.ReadLine();
Int32.TryParse(enteredChemResult, out chemCandidateResult);

Console.WriteLine("Podaj swój wynik z fizyki: ");
var enteredPhisicsResult = Console.ReadLine();
Int32.TryParse(enteredPhisicsResult, out physicsCandidateResult);

sumOfPointCandidate = mathCandidateResult + physicsCandidateResult + chemCandidateResult;

sumMathResultAndChemResult = mathCandidateResult + chemCandidateResult;
sumMathResultAndPhisicsResult = mathCandidateResult + physicsCandidateResult;

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