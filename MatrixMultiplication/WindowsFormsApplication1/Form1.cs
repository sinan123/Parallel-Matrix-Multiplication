using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnMatrixMultiply_Click(object sender, EventArgs e)
        {

            #region Fields
            MyThread[] TreadDizisi = new MyThread[2];
            Thread[] threadArray = new Thread[5];
            Multiplication crp = new Multiplication(Convert.ToInt32(txtMatrixSize.Text));
            String endPointName = "ServerService1";
            String endPointName2 = "ServerService1";
            MyThread _server;
            #endregion

            #region MyThreadPool
            for (int i = 0; i < threadArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    _server = new MyThread(endPointName);
                }

                else
                {
                    _server = new MyThread(endPointName2);
                }


                threadArray[i] = new Thread(new ThreadStart(_server.ConnectToServer));
                threadArray[i].Start();
                threadArray[i].Join();
            }

            #endregion



            Test test = new Test();

            if (test.VerificationMatrix(Multiplication._matrix1, Multiplication._matrix2, Multiplication.resultMatrix, Multiplication._size) == true)
            {

                MessageBox.Show("Dağıtık Çarpma İşlemi Doğru Olarak Tamamlandı...");
            }
            if (test.VerificationMatrix(Multiplication._matrix1, Multiplication._matrix2, Multiplication.resultMatrix, Multiplication._size) == false)
            {

                MessageBox.Show("Dağıtık Çarpma İşlemi Yanlış...");
            }
        }


    }
}
