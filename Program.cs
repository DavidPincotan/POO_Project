namespace Appptteme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optiune,flag,auxint,sum=0;
            string aux1, aux2,aux;
            List<string> intrebari = new List<string>(), raspunsuri=new List<string>();
            List<int> raspunsuri_corecte_pozitie = new List<int>();
            DateTime aux3, aux4;
            Prof prof = new Prof();
            Student student = new Student();
            Tema taux;
            List<Tema> temaList = new List<Tema>();
            while (true)
            {
                

                Console.WriteLine("1. Conectati-va ca PROFESOR \n2. Conectati-va ca STUDENT");
                optiune = int.Parse(Console.ReadLine());
                if (optiune == 3)
                {

                }
                else if (optiune == 1)
                {
                    flag = 1;
                    Console.WriteLine("introduceti parola");
                    if (prof.PassCheck(Console.ReadLine()))
                    {
                        while (flag == 1)
                        {
                            Console.WriteLine("1. Creati tema/modificati tema \n2. Vizualizare teme \n3.Evaluare assigment \n0. exit");
                            optiune = int.Parse(Console.ReadLine());
                            switch (optiune)
                            {
                                case 1:
                                    Console.WriteLine("Introduceti titlu: ");
                                    aux1 = Console.ReadLine();
                                    Console.WriteLine("Introduceti descreirea: ");
                                    aux2 = Console.ReadLine();

                                    Console.WriteLine("Introduceti Data de Start: ");
                                    aux3 = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Introduceti Deadline: ");
                                    aux4 = DateTime.Parse(Console.ReadLine());
                                    taux = new Tema(aux1, aux2, aux3, aux4);

                                    Console.WriteLine("Este Quiz? y/n ");
                                    aux = Console.ReadLine();
                                    if (aux == "y")
                                    {
                                        Console.WriteLine("Cate intrebari?");
                                        auxint = int.Parse(Console.ReadLine());
                                        for (int i = 0; i < auxint; i++)
                                        {
                                            Console.WriteLine("Intrebarea " + (i + 1) + ": ");
                                            intrebari.Add(Console.ReadLine());
                                        }
                                        for (int i = 0; i < auxint; i++)
                                        {
                                            Console.WriteLine("Raspuns " + 1 + ": ");
                                            raspunsuri.Add(Console.ReadLine());
                                            Console.WriteLine("Raspuns " + 2 + ": ");
                                            raspunsuri.Add(Console.ReadLine());
                                            Console.WriteLine("Raspuns " + 3 + ": ");
                                            raspunsuri.Add(Console.ReadLine());
                                            Console.WriteLine("Pozitie raspuns corect 1,2 sau 3");
                                            raspunsuri_corecte_pozitie.Add(int.Parse(Console.ReadLine()));
                                        }
                                        taux.create_quiz(intrebari, raspunsuri,raspunsuri_corecte_pozitie);
                                    }
                                    temaList.Add(taux);
                                    break;
                                case 2:
                                    for (int i = 0; i < temaList.Count; i++)
                                    {
                                        temaList[i].display_pt_prof();
                                    }
                                    break;
                                case 3:
                                    for (int i = 0; i < temaList.Count; i++)
                                    {
                                        if (temaList[i].get_status() == "neevaluat" && temaList[i].get_tip() == "assignment")
                                        {
                                            temaList[i].revierw_assigment();
                                        }
                                    }
                                    break;
                                case 0:
                                    flag = 0;
                                    break;
                                default:
                                    Console.WriteLine("optiune invalida");
                                    break;
                            }
                        }
                    }
                }
                else if (optiune == 2)
                {
                    flag = 1;
                    Console.WriteLine("introduceti parola");
                    if (student.PassCheck(Console.ReadLine()))
                    {
                        while (flag == 1)
                        {
                            Console.WriteLine("1. Afisare lista teme evaluate/neevaluate \n2. Vizualizare teme \n3.Afisare medie \n4. Preda tema \n0. exit");
                            optiune = int.Parse(Console.ReadLine());
                            switch (optiune)
                            {
                                case 1:
                                    for (int i = 0; i < temaList.Count; i++)
                                    {
                                        Console.WriteLine(temaList[i].get_status());
                                        Console.WriteLine(temaList[i].get_grade());
                                        Console.WriteLine(temaList[i].get_comment());
                                    }
                                    break;
                                case 2:
                                    for (int i = 0; i < temaList.Count; i++)
                                    {
                                        Console.WriteLine(temaList[i]);
                                    }
                                    break;
                                case 3:
                                    sum = 0;
                                    for (int j = 0; j < temaList.Count; j++)
                                    {
                                        sum += temaList[j].get_grade();
                                    }
                                    Console.WriteLine("Media este: " + sum / temaList.Count);
                                    break;
                                case 4:
                                    for (int i = 0; i < temaList.Count; i++)
                                    {
                                        if (temaList[i].get_status() == "neevaluat" && temaList[i].get_tip() == "quiz")
                                        {
                                            temaList[i].take_quiz();

                                        }
                                        else if (temaList[i].get_status() == "neevaluat")
                                        {
                                            temaList[i].assigment();
                                        }

                                    }
                                    break;
                                case 0:
                                    flag = 0;
                                    break;
                                default:
                                    Console.WriteLine("nu exista optiunea");
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Optiune incorecta");
                }
            }

        }
    }
}
