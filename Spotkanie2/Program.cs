// See https://aka.ms/new-console-template for more information


int wiek1 = 0; //deklaracja z inicjalizacją, póki zmienna nie ma żadnej wartości nie jest zainicjalizowana

//nadpisanie zmiennej - literał to kawałek danych - liczba, litera, słowo
//literały są łączone w wyrażenie poprzez operatory np. +
//dobrą praktyką jest uruchamianie kodu co kilkanaście linijek (aby znaleźć błąd)
wiek1 = 10+20; 


// 2. Typy danych
// pascal case = alaMaKota; konwencja pisania w C#; Java 
// Typy proste (primitive) - tylko dane np. liczba, pojednynczy znak 

int age = 25; //ważne
long duzaliczba = 4475493;

double temp = 25.5; //ważne

char znak = 'A'; //pojedynczy znak

bool czyPadaDescz = true; 

// Typy złożone (complex) - dane + zachowanie (metody)

string zdanie = "Ala ma kota";

string noweZdanie = zdanie.ToUpper(); // wywołanie metody dedykowanej dla typu danych string. Metoda ToUpper dostaje na wejście zmienną zdanie


// 3.  Pułapki
double d1 = 0.1;
double d2 = 0.2;

double wynik = d1 + d2; //0,30000000000000004

// Można przekonwertowac na liczbe całkowitą i później przeskalować
// Albo wykorzystac specjalną bibliotekę 


// 3.2 
int l1 = 10;
double l2 = 10.5;
//int wynik2 = l1 + l2; //błąd, bo zmienna wynikowa int + double = double
int wynik2 = (int)(l1 + l2); // rzutowanie (casting) - zamiana jednego typu danych na drugi, analogia do CAST w sql
//int wynik2 = l1 + (int)l2; // rzutowanie (casting) - zamiana jednego typu danych na drugi

// Parsowanie (parse) - zamiana string -> inny typ
// Proces złożony, może powodowac błędy
// "43.4" -> 43.4

string liczba = "450";
int liczba2 = int.Parse(liczba);

//Console.WriteLine(liczba2+10);

// Konkatenacja
string imie1 = "Ala";
int liczbaKotow = 15;
string zwierze = "kota";
string zdanie2 = imie1+" ma "+liczbaKotow+" "+zwierze; 

//Console.WriteLine(zdanie2);


double malaLiczba = 10.34467532;
double zaokraglona = Math.Round(malaLiczba, 3);
//Console.WriteLine(zaokraglona);


//Program 1
// Zapytaj o imie i wiek , nastepnie wypisz je na konsole

// Console.WriteLine("Podaj swoje imie:");
// string imieUzytkownika = Console.ReadLine();
//
// Console.WriteLine("Podaj swój wiek:");
// int wiekUzytkownika = int.Parse(Console.ReadLine());
//
// int rokUrodzenia = DateTime.UtcNow.Year - wiekUzytkownika;
//
// Console.WriteLine("Imie użytkownika to " + imieUzytkownika + "\nUrodziłaś się w roku " + rokUrodzenia );


//Program 2 - instrukcje warunkowe
//Wpisz dwie liczby - ile punktów z testu otrzymano; ile było maksymalnie do zdobycia
//Wypisz uzyskaną ocenę
//>=50% - 3.0 itd

Console.WriteLine("Podaj liczbe zdoytych punktów:");
double zdobytePunkty = double.Parse(Console.ReadLine());

Console.WriteLine("Podaj maksymalną liczbę punktów do zdobycia:");
int  maksymalnePunkty = int.Parse(Console.ReadLine());

double wynikProcentowy = zdobytePunkty/maksymalnePunkty*100;
wynikProcentowy = Math.Round(wynikProcentowy, 2);


double ocena;

if (wynikProcentowy < 50)
{
   ocena = 2.0;
}
else if (wynikProcentowy <60)
{
   ocena = 3.0;
}
else if (wynikProcentowy <70)
{
   ocena = 3.5;
}
else if (wynikProcentowy <80)
{
   ocena = 4.0;
}
else if (wynikProcentowy <80)
{
   ocena = 4.5;
}
else
{
   ocena = 5.0;
}


Console.WriteLine("Ocena końcowa:" + ocena);
