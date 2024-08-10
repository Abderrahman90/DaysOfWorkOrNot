internal class Program
{
    private static void Main(string[] args)
    {
        // lors d'un appel de méthode je peux avoir cette erreur :
        //Impossible de convertir le groupe de méthodes 'Identifier' en type non-délégué 'type'. 
        //Souhaitiez-vous appeler la méthode ? Cette erreur se produit lors de la conversion d'un groupe de méthodes en un type non délégué, 
        //ou de la tentative d'appel d'une méthode sans utiliser de parenthèses.

        //ici on va donc utilisé nos if else imbriqué vu on a plusieurs sous cas
        if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
        {
            AfficheBonWeekEnd();
        }
        else
        {
            if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 9)
            {
                AfficheBonWeekEnd();
            }

            else
            {
                AfficheBonjour();
            }

            if (DateTime.Now.Hour >= 18)
            {

                AfficheBonsoir();
            }
            
        }
    }

    //je crée mes 3 méthodes simples en dehors du main = clean code
    public static void AfficheBonjour() {     
       Console.WriteLine("Bonjour " + Environment.UserName);
    }
    public static void AfficheBonsoir() {
        Console.WriteLine("Bonsoir " + Environment.UserName);
    }

    public static void AfficheBonWeekEnd()  //si je ne mets pas static :Un membre qui n’accède pas aux données d’instance n’est pas marqué comme static
    {
        Console.WriteLine("Bon Week-end à toi " + Environment.UserName);
    }
}