using System;
using System.Collections.Generic;
using System.Text;

namespace IHM.View
{
    class InintialisationView
    {
        public void Bienvenue()
        {
            Console.WriteLine("Bonjour,vous venez de lancer le logiciel de sauvegarder\nQuelle action souhaitez-vous faire: ");
        }
        public void Service()
        {
            IHM.Model.Sauvegarde sauvegarde = new Model.Sauvegarde();

            for (int i = 0; i < sauvegarde.service.Length; i++)
            {
                sauvegarde.j = i + 1;
                Console.WriteLine(sauvegarde.j + "-" + sauvegarde.service[i]);
            }
        }

    }
}
