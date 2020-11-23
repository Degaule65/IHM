using System;
using System.Collections.Generic;
using System.Text;

namespace IHM.Control
{
    class InintialisationController
    {
        public void Control()
        {
            IHM.Model.Sauvegarde sauvegarde = new Model.Sauvegarde();

            IHM.View.InintialisationView InintialisationView = new View.InintialisationView();
            IHM.View.MessageDErreurView messageDErreur = new View.MessageDErreurView();

            IHM.Control.SauvegardeController sauvegardeController = new Control.SauvegardeController();
            IHM.Control.FinController finController = new Control.FinController();


            InintialisationView.Bienvenue();
            InintialisationView.Service();

            ConsoleKeyInfo decision = Console.ReadKey(false);

            switch(decision.Key)
            {
                case ConsoleKey.D1: 
                case ConsoleKey.NumPad1:

                    sauvegardeController.Tache();
                    finController.Finish();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:



                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:

                    finController.ThisEnd();

                    break;

                default:
                    messageDErreur.Erreur();
                    break;
            }
            Control();
        }
    }
}
