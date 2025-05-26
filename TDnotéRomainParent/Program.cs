
int saisieSexes()
{
    string sexeSaisie;

    do
    {
        // récupération de la saisie de l'utilisateur
        Console.WriteLine("Saisissez votre sexe au format Sk/Yo/Hu ");
        var input = Console.ReadLine();
        sexeSaisie = input ?? ""; // Gère le cas où la saisie est nulle

        // controle de saisie 
        if (sexeSaisie != "Yo" && sexeSaisie != "Hu" && sexeSaisie != "Sk")
        {
            Console.WriteLine("Erreur: le sexe doit être Yo, Hu ou Sk");
        }
    }
    while (sexeSaisie != "Yo" && sexeSaisie != "Hu" && sexeSaisie != "Sk");
    // retour du sexe récupéré différent selon le sexe

    if (sexeSaisie == "Yo") return 1;
    if (sexeSaisie == "Hu") return 2;
    return 3;
}

int saisieAge()
{
    int saisieAge;

    Console.WriteLine("Saisissez un age ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out saisieAge))
        throw new ArgumentException("Veuillez saisir un nombre entier valide pour l'âge.");
    // controle des saisie positives  
    if (saisieAge < 0)
        throw new ArgumentException("Age invalide car inférieure à zéro");

    return saisieAge;
}

// démarrage
int sexeValeur;
int age;

// appel des méthodes 
sexeValeur = saisieSexes();
try
{
    age = saisieAge();
    Console.WriteLine(age);
}
catch (Exception e)
{
    Console.WriteLine(e.Message); // gère les erreurs
    return;
}

if (sexeValeur == 1 || age > 20)
{
    Console.WriteLine("Cet Oxien paie l'impot ");
}
if (sexeValeur == 1 || age > 20)
{
    Console.WriteLine("Cet Oxien paie l'impot ");
}
if (sexeValeur == 1 || age > 20)
{
    Console.WriteLine("Cet Oxien paie l'impot ");
}

else
{
    Console.WriteLine("Cet Oxien ne paie pas l'impot ");
}








