using System;
namespace calculator
{

public class Calculator
{
    public int Add(int x, int y)
    {
        int answer = x + y;
        return answer;
    }

    public int Mod (int x, int y)
    {
        int answer = x%y; 
        return answer;
    }
}

}