using System;

namespace DesignPatterns.Behavioral.ChainOfResponsability.Sample
{
    public class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }

    public abstract class Approver
    {
        public EventHandler<LoanEventArgs> Loan;
        public abstract void LoanHandler(object sender, LoanEventArgs e);
        public Approver()
        {
            Loan += LoanHandler;
        }

        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs { Loan = loan });
        }

        public virtual void OnLoan(LoanEventArgs e)
        {
            if(Loan != null)
            {
                Loan(this, e);
            }
        }

        public Approver Successor { get; set; }
    }

    public class Clerk : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 25000.0)
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, e.Loan.Number);
            else if (Successor != null)
                Successor.LoanHandler(this, e);
        }
    }

    public class AssistantManager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 45000.0)
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, e.Loan.Number);
            else if (Successor != null)
                Successor.LoanHandler(this, e);
        }
    }

    public class Manager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 100000.0)
                Console.WriteLine("{0} approved request# {1}", sender.GetType().Name, e.Loan.Number);
            else if (Successor != null)
                Successor.LoanHandler(this, e);
            else
                Console.WriteLine("Request# {0} requires an executive meeting!", e.Loan.Number);
        }
    }

    public class Loan
    {
        public double Amount { get; set; }
        public string Purpose { get; set; }
        public int Number { get; set; }
    }
}
