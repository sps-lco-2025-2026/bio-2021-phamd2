using System.Diagnostics;

// Q1 - create a class based on the data given 

DownPat dp = new DownPat("DE", "C");

dp.Calculate();

// test the output 
Debug.Assert(dp.First == "NO");
Debug.Assert(dp.Second == "YES");
Debug.Assert(dp.First == "YES");


public class DownPat
{
    
}

