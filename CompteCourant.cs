using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM4_TP1_Martin_laugere
{
    public class CompteCourant : CompteBancaire
    {
        private string numeroCB;
        private double decouvertMaxi;

        public CompteCourant(string LeTitulaire, double LeSoldeInititial, string LaDevise, string LeNumeroCB, double LeDecouvertMaxi)
            : base (LeTitulaire, LeSoldeInititial, LaDevise)
        {
            this.numeroCB = LeNumeroCB;
            this.decouvertMaxi = LeDecouvertMaxi;
        }

        public override void Debiter(double Montant)
        {
            if (this.get_solde() - Montant > this.decouvertMaxi) set_solde(this.get_solde() - Montant);
        }

        public override string Decrire()
        {
            return base.Decrire() + " Num CB : " + this.numeroCB + " Découvert autorisé : " + this.decouvertMaxi;
        }
    }
}
