using System;

/// <summary>
/// 
/// 
/// 
/// </summary>

namespace DesignPatterns.Behavioral.Interpreter
{
    class Context
    {
    }

    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
