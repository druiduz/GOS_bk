﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GOS
{
    class Produit : IComparable
    {
        private int _ID;
        private String name;
        private int quantite;
        private float prix;

        public Produit()
        {
            this.ID = -1;
            this.name = "undefined";
            this.quantite = 0;
            this.prix = 0.0f;
        }

        public Produit(int id, String name, int quantite, float prix)
        {
            this._ID = id;
            this.name = name;
            this.quantite = quantite;
            this.prix = prix;
        }

        public int ID
        {
            get { return _ID; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        public float Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public override String ToString()
        {
            String s = "";

            s += "--Object 'Produit'--'\n";
            s += "name: "+name+"\nquantite: "+quantite+"\nprix: "+prix;

            return s;
        }


        public void update()
        {
            #region TODO: Connexion bdd

            #endregion
        }

        public static Produit getProduit(int id)
        {
            int ID = -1;
            string name = "";
            int quantite = 0;
            float prix = 0.0f;


            #region TODO: Connexion bdd
            
            #endregion


            Produit p = new Produit(ID, name, quantite, prix);
            return p;
        }

        public static bool addProduit(Produit p)
        {
            #region TODO: Connexion bdd

            #endregion

            return true;
        }

        public int CompareTo(object o)
        {
            Produit p = (Produit)o;
            return (int)(this.quantite - p.quantite);
        }
    }
}
