using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MyThread
    {
        #region Fields
        private string _endpoint;
        private int _x = 0, _y = 0;
        private int[] sendRow = new int[Multiplication._size];
        private int[] sendColumn = new int[Multiplication._size];
        private int[,] gelencarpım = new int[2, Multiplication._size];
        #endregion

        #region Constructor
        public MyThread(string endpoint)
        {

            _endpoint = endpoint;
        }
        #endregion

        #region ConnectToServer
        public void ConnectToServer()
        {

            while (Multiplication.counter < (Multiplication._size * Multiplication._size))
            {

                try
                {

                    Monitor.Enter(this);

                    _x = Multiplication._row;
                    _y = Multiplication._column;
                    gelencarpım = new Multiplication().GetRowAndColumn();
                    //System.Windows.Forms.MessageBox.Show(_x.ToString()+_y.ToString());
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < Multiplication._size; j++)
                        {
                            if (i == 0)
                            {
                                sendRow[j] = gelencarpım[i, j];
                            }
                            if (i == 1)
                            {
                                sendColumn[j] = gelencarpım[i, j];
                            }

                        }
                    }
                    Monitor.Pulse(this);
                   ServerService.ServerServiceClient serverService = new ServerService.ServerServiceClient(_endpoint);

                   Multiplication.resultMatrix[_x, _y] = serverService.Multiplication(sendRow, sendColumn);
                   
                   
                }
                finally
                {

                    Monitor.Exit(this);

                }                

            }
        }
        #endregion

    }
}
