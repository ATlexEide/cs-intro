using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
	public static void Main()
	{
// 		Grunnleggende oppsett
// Oppgave 2
// Variabler
// Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
int myVar = 10;
// Lag en variabel av datatypen string og tilden en vilkårlig tekst
string myString = "Hello World!";
// Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
double myDouble = 13.37;
// Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
char myChar = 'A';
// Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
int[] myIntArray = [1,2,3,4,5,6,7,8,9,10];
for(int i = 0; i < myIntArray.Length; i++){
	Console.WriteLine(i);
};
// Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
string[] myStringArray = ["Hello","World","from","a","foreach","loop"];
foreach(string word in myStringArray){
	Console.WriteLine(word);
};
// Lag en List av datatypen string og tildel verdier ved hjelp av List sin innebygde metode "Add()"
List<string> myList = new List<string>();
myList.Add("a tiny little string");
Console.WriteLine($"list item at index 0: {myList[0]}");
// myExampleList.Add("min string");
// Legg til flere strings i listen deres
myList.Add("another tiny little string");
myList.Add("a BEEFY little string");
myList.Add("a *fragile* little string");

// Skriv ut verdiene i listen ved hjelp av en foreach-løkke
foreach(string item in myList){
	Console.WriteLine($"myList index: {myList.IndexOf(item)} = {item}");
};
// Leverering: lenke til github-repositoriet deres.
 

// Oppgave 3: Ekstraoppgaver
// Ekstraoppgave(valgfritt)
// Disse oppgavene er valgfrie, men kan være lurt å forsøke å gjøre om man ønsker å begynne litt tidligere på de neste temaene i faget.

// Lag en Dictionary med integer-nøkkel og string-verdi slik
Dictionary<string, string> myDict= new Dictionary<string, string>();
try
{
	myDict.Add("my key","a valuable value");
	myDict.Add("my second key","a valuable value");
	myDict.Add("my third key","a valuable value");
	myDict.Add("my fourth key","a valuable value");
	// myDict.Add("my key","a valuable value");
}
catch (ArgumentException)
{
	Console.WriteLine("Item already exists whithing the dictionary");
	throw;
}
Console.WriteLine($"element at 0 in myDict: {myDict.ElementAt(0)}");
// Dictionary<int, string> myDictionary = new Dictionary<int, string>();
// Skriv ut verdiene i Dictionary ved å anvende en foreach-løkke ved hjelp av datatypen var
foreach(var elem in myDict){
	Console.WriteLine(elem);
};
// Lag en metode av typen integer som legger sammen to tall, int a og int b
static int add(int num,int num2){
	int sum = num + num2;
 	Console.WriteLine(sum);
	return sum;
};
add(2,4);
// Lag en metode av typen string som skrive ut en liten hilsen til brukeren ved å bruke en parametervariabel.
static string hilsen(string name){
	string hilsen = $"Hei {name}";
	Console.WriteLine(hilsen);
	return hilsen;
};
hilsen("Alex");
    }    
};