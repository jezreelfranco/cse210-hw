using System;
using System.Net.Quic;
using System.Runtime.InteropServices.Marshalling;

class Program
{ 
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.Reference_and_word();
        scripture.HideWords();

        // Scripture scripture2 = new Scripture();
        // scripture2.Reference_and_word2();
    
    }
}
        