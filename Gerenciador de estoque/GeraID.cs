using System;
using System.Collections.Generic;

namespace Gerenciador_de_estoque
{
  
    public class GeraID
    {
        private HashSet<int> usedIDs;
        private Random rand;
        private int idLength;

        public HashSet<int> UsedIDs
        {
            set { usedIDs = value; }
            get { return usedIDs; }
        }

        public GeraID()
        {
            usedIDs = new HashSet<int>();
            rand = new Random();
            idLength = 6;
        }

        public int GerarIDUnico()
        {
            while (true)
            {
                int newID = rand.Next((int)Math.Pow(10, idLength));

                if (!usedIDs.Contains(newID))
                {
                    usedIDs.Add(newID);
                    return newID;
                }
            }
        }

        public bool DeletarID(int id)
        {
            if (usedIDs.Contains(id))
            {
                usedIDs.Remove(id);
                return true;
            }

            return false;
        }

        public bool VerificarID(int id)
        {
            return usedIDs.Contains(id);
        }
    }
}