using System;
using System.Collections.Generic;
using System.Text;

namespace IHM.Control
{
    class FinController
    {
        public void Finish()
        {
            IHM.View.FinView finView = new View.FinView();
            finView.RetourMenu();
            Console.ReadLine();
            Console.Clear();

        }
        public void ThisEnd()
        {
            IHM.View.FinView finView = new View.FinView();
            finView.Final();
            Environment.Exit(0);

        }
    }
}
