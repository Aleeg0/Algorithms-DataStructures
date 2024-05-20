namespace Algorithm_DataStructures.Algorithms.Stack;

public class EvaluateReversePolishNotationTask
{
    public int EvalRPN(string[] tokens)
    {
        HashSet<string> operators = ["+", "-", "*", "/"];
        Stack<string> answer = new Stack<string>();
        for (int i = 0; i < tokens.Length; i++)
        {
            string curSymbol = tokens[i];
            if (operators.Contains(curSymbol))
            {
                int number1 = int.Parse(answer.Pop());
                int number2 = int.Parse(answer.Pop());
                switch (curSymbol)
                {
                    case "+":
                        answer.Push((number2 + number1).ToString());
                        break;
                    case "-":
                        answer.Push((number2 - number1).ToString());
                        break;
                    case "*":
                        answer.Push((number2 * number1).ToString());
                        break;
                    case "/":
                        answer.Push((number2 / number1).ToString());
                        break;
                }
            }
            else
                answer.Push(curSymbol);
        }

        return int.Parse(answer.Pop());
    }
}