using System;

namespace ConsoleApp8
{
    class Program
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach(char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce (string halfDNASequence)
        {
            string result = "";
            foreach(char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string ans;
            do
            {
                string halfDNASequence = Console.ReadLine();
                IsValidSequence(halfDNASequence);
                if (IsValidSequence(halfDNASequence) == true)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", halfDNASequence);
                    do
                    {
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        ans = Console.ReadLine();
                        switch (ans)
                        {
                            case "Y":
                                ReplicateSeqeunce(halfDNASequence);
                                Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(halfDNASequence));
                                break;
                            case "N":
                                break;
                            default:
                                Console.WriteLine("Please input Y or N.");
                                break;

                        }
                    } while (ans != "Y" && ans != "N");
                }
                else
                    Console.WriteLine("That half DNA sequence is invalid.");
                do
                {
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    ans = Console.ReadLine();
                    if (ans != "Y" && ans != "N")
                    {
                        Console.WriteLine("Please input Y or N.");
                    }
                } while (ans != "Y" && ans != "N");
            } while (ans == "Y");

        }
    }
}
