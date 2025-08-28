using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_BaiTapWinForm
{
    public class TinhToan
    {
        public void CongHaiSo(int a, int b,ref int s)
        {
            s = a + b;
        }
        public int TongDaySo(int n)
        {
            int total = 0;
            for (int i=1; i<=n;i++)
                total+=i;
            return total;
        }
        
    }
}
