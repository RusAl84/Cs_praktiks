using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var83WF
{
    // var83 матрица инцидентности
    // строки это дуги
    // столбцы это вершины

    internal class ATDGraphClass
    {
        private int n = 10;
        private int m = 6;
        private int[,] data = new int[6,10];

        public ATDGraphClass() {

        }

        public void dataToString()
        {
            string textData = "";
            string line = "";
            for (int i=0; i <n; i++)
            {
                for(int j = 0; j < m-1; j++) { 
                    line += String.Format("{0},", data[i,j]);
                }
                line += String.Format("{0},", data[i, m-1]);
            }
            textData += line + "\n";
        }
        //public void ADD_V(<имя>, <метка, mark>)
    }
}
