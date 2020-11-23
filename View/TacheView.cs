using System;
using System.Collections.Generic;
using System.Text;

namespace IHM.View
{
    class TacheView
    {
        public void Texte()
        {
            Console.WriteLine("\n" + "Vous venez de choisir l'option 1, Voici la liste de toute les tâches");
        }
        public void liste()
        {
            IHM.Model.Sauvegarde sauvegarde = new Model.Sauvegarde();
            for (int i = 0; i < sauvegarde.tache.Length; i++)
            {
                sauvegarde.j = i + 1;
                Console.WriteLine(sauvegarde.j + "-" + sauvegarde.tache[i]);
            }
        }
        public void Description(int i)
        {
            Model.Sauvegarde sauvegarde = new Model.Sauvegarde();
            Console.WriteLine("\nVoici une description de la sauvegarde");
            Console.Out.WriteLine(sauvegarde.Description[i-1,0,0,0]);
            Console.Out.WriteLine(sauvegarde.Description[i-1,0,0,i]);
            
        }
    }
}
