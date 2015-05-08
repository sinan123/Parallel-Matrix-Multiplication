using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Test
    {
        public bool VerificationMatrix(int[,] Matrix1, int[,] Matrix2,int[,] ResultMatrix,int Size)
        {


              int[,] c = new int[Size,Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < Size; k++)
                    {
                        c[i, j] += Matrix1[i, k] * Matrix2[k, j];
                    }
                }
            }

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (ResultMatrix[i, j] != c[i, j])
                        return false;
                }
            }
            return true;
        }



    }
}
