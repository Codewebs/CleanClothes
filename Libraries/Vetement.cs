using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    class Vetement
    {
        String libelle;
        String code;
        String couleur;
        int matiere;

        public Vetement(String libelle, String code, String couleur, int matiere)
        { //Constructeur de la classe vetement
            this.code = code;
            this.couleur = couleur;
            this.libelle = libelle;
            this.matiere = matiere;
        }


        // Accesseurs
        public String getCode()
        {
            return code;
        }
        public String getCouleur()
        {
            return couleur;
        }
        public int getMatiere()
        {
            // A faire evoluer avec une fonction dans la classe qui retrouve directement le nom de la matiere dans les enymeration de type de matiere
            return matiere;
        }
         
    }
}
