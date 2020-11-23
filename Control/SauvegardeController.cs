using System;
using System.Collections.Generic;
using System.Text;

namespace IHM.Control
{
    public class SauvegardeController
    {
        public void Tache()
        {
            IHM.View.MessageDErreurView messageDErreur = new View.MessageDErreurView();
            IHM.View.TacheView tacheView = new View.TacheView();

            tacheView.Texte();
            tacheView.liste();

            ConsoleKeyInfo Choix = Console.ReadKey(false);
            int i=0;
            switch (Choix.Key)
            {
                
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    i = 1;
                    tacheView.Description(i);

                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:

                     i = 2;
                    tacheView.Description(i);

                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:

                    i = 3;
                    tacheView.Description(i);

                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:

                    i = 4;
                    tacheView.Description(i);

                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:

                    i = 5;
                    tacheView.Description(i);

                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:

                    i = 6;
                    tacheView.Description(i);

                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:

                    i = 7;
                    tacheView.Description(i);
                    break;
                default:
                    messageDErreur.Erreur();
                    break;
            }
               
        }
    }
}
