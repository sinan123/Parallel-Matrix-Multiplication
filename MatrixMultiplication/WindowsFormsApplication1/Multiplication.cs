using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Multiplication
    {
        #region Fields
        public static int[,] _matrix1, _matrix2, resultMatrix;
        public static int _row = 0, _column = 0, _size = 0, counter = 0;
        public int[,] sendRowAndColumn, _randomMatrix;
        #endregion

        #region Constructor
        public Multiplication()
        {

        }

        public Multiplication(int N)
        {
            _size = N;
            resultMatrix = new int[_size, _size];
            _matrix1 = RandomMatrixCreate();
            _matrix2 = RandomMatrixCreate();

        }
        #endregion

        #region RandomMatrixCreate
        public int[,] RandomMatrixCreate()
        {

            _randomMatrix = new int[_size, _size];
            Random rd = new Random();

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    _randomMatrix[i, j] = rd.Next(1, 5);
                }
            }
            return _randomMatrix;
        }
        #endregion

        #region GetRowAndColumn
        public int[,] GetRowAndColumn()
        {

            counter++;

            if (counter <= (_size * _size))
            {

                sendRowAndColumn = new int[2, _size];
                for (int i = 0; i < _size; i++)
                {
                    sendRowAndColumn[0, i] = _matrix1[_row, i];
                    sendRowAndColumn[1, i] = _matrix2[i, _column];
                }


                _column += 1;

                if (_column >= _size)
                {
                    _column = 0;
                    _row += 1;
                }
            }
            return sendRowAndColumn;
        }

        #endregion

    }
}
