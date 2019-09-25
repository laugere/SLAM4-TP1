using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM4_TP1_Martin_laugere
{
    public class CompteEpargne : CompteBancaire
    {
        private double tauxInteret;

        public CompteEpargne(string LeTitulaire, double SoldeInitial, string LaDevise, double LeTauxInteret)
            : base(LeTitulaire, SoldeInitial, LaDevise)
        {
            this.tauxInteret = LeTauxInteret;
        }

        public void ajouterInteret()
        {
            double solde = this.get_solde();
            this.set_solde(solde + (solde * tauxInteret));
        }

        public override void Debiter(double Montant)
        {
            double solde = this.get_solde();
            this.set_solde(solde - Montant);
        }

        public override string Decrire()
        {
            return base.Decrire() + " taux du compte : " + this.tauxInteret;
        }
    }
}
