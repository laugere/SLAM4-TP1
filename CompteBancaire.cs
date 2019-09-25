using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAM4_TP1_Martin_laugere
{
    public abstract class CompteBancaire
    {
        private string titulaire;
        private double solde;
        private string devise;

        // CONSTRUCTEUR
        public CompteBancaire(string LeTitulaire, double LeSolde, string LaDevise)
        {
            this.titulaire = LeTitulaire;
            this.solde = LeSolde;
            this.devise = LaDevise;
        }

        public string get_titulaire() { return (titulaire); } //ACCESSEUR

        public void set_titulaire(string LeTitulaire) { titulaire = LeTitulaire; } //MUTATEUR

        public double get_solde() { return (solde); } //ACCESSEUR
        protected void set_solde(double LeSolde) { solde = LeSolde; } //MUTATEUR

        public string get_devise() { return (devise); } //ACCESSEUR
        public void set_devise(string LaDevise) { devise = LaDevise; } //MUTATEUR

        public void Affiche_Compte()
        {
            Console.WriteLine("Le titulaire : " + this.titulaire + ", le solde : " + this.solde + ", la devise du compte bancaire : " + this.devise);
        }

        public void Crediter(double UnMontant)
        {
            this.solde = solde + UnMontant;
        }

        public abstract void Debiter(double Montant);

        public virtual string Decrire()
        {
            return ("Le solde du compte de " + this.titulaire + " est de " + this.solde + " " + this.devise);
        }
    }
}
