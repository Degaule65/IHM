using System;
using System.Collections.Generic;
using System.Text;

namespace IHM.Model
{
    public class Sauvegarde
    {
        public string[] service = new string[] { "Démarrer une tâche", "Créer une tâche", "Supprimer une tâche","Quitter le logiciel" };
        public string[] tache = new string[] { "Sauvegarde complète", "sauvegarde partielle" };
        public string[,,,] Description = new string[,,,] { { { { "coucou", "D:\\dex", "C:\\dex", "complete" }, { "deux", "D:\\", "C:\\", "partielle" } } } };
        public int j;
    }
}
