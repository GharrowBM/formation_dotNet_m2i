using System;
namespace CaisseEnregistreuse.Interfaces
{
    public interface IPaiement
    {
        DateTime DatePaiement { get; }
        int Reference { get; }
        bool Payer(decimal montant);
    }
}
