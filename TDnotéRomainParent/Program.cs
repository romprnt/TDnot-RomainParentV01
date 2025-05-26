// See https://aka.ms/new-console-template for more information
int saisieSexes()
{
    string sexeSaisie ;

    do
    {
        // récupération de la saisie de l'utilisateur
        Console.WriteLine("Saisissez votre sexe au format Sk/Yo/Hu ");
        sexeSaisie = Console.ReadLine();

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
        saisieAge = Convert.ToInt32(Console.ReadLine());
    // controle des saisie positives  
     if (saisieAge < 0)
        throw new ArgumentException("Age invalide car inférieure à zéro");


    

   return saisieAge;

}








