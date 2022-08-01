using System;
using System.Configuration;
using System.Text;
using System.Data;

namespace HRMS.Common
{
	/// <summary>
	/// Assistant 的摘要说明。
	/// </summary>
	public sealed class Assistant
	{		
			
		#region

		/// <summary>
		/// 从字符串里随机得到，规定个数的字符串.
		/// </summary>
		/// <param name="allChar"></param>
		/// <param name="CodeCount"></param>
		/// <returns></returns>
        public string GetRandomCode(string allChar, int CodeCount) 
		{ 
			string[] allCharArray = allChar.Split(','); 
			string RandomCode = ""; 
			int temp = -1; 
			Random rand = new Random(); 
			for (int i=0;i<CodeCount;i++) 
			{ 
				if (temp != -1) 
				{ 
					rand = new Random(temp*i*((int) DateTime.Now.Ticks)); 
				} 

				int t = rand.Next(allCharArray.Length-1); 

				while (temp == t) 
				{ 
					t = rand.Next(allCharArray.Length-1); 
				} 
		
				temp = t; 
				RandomCode += allCharArray[t]; 
			} 
			return RandomCode; 
		}


        /// <summary>
        /// 从字符串里随机得到，规定个数的字符串.
        /// </summary>
        /// <returns></returns>
        public string GetRandomCode(int CodeCount)
        {
            string allChar = "1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,_";
            string[] allCharArray = allChar.Split(',');
            string RandomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < CodeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(temp * i * ((int)DateTime.Now.Ticks));
                }

                int t = rand.Next(allCharArray.Length - 1);

                while (temp == t)
                {
                    t = rand.Next(allCharArray.Length - 1);
                }

                temp = t;
                RandomCode += allCharArray[t];
            }
            return RandomCode;
        }

        /// <summary>
        /// 从字符串里随机得到，规定个数的字符串.
        /// </summary>
        /// <param name="CodeCount">取几个</param>
        /// <param name="type">0为数字，1大小写24个字母和下滑线，2大写字母下滑线，3小写字母下滑线</param>
        /// <returns></returns>
        public string Bpwen_GetRandomCode(int CodeCount,int type)
        {
            string allChar = null;
            if (type == 0)
            {
                allChar = "1,2,3,4,5,6,7,8,9";
            }
            else if (type == 1)
            {
                allChar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,_";
            }
            else if (type == 2)
            {
                allChar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,_";
            }
            else if (type == 3)
            {
                allChar = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,_";
            }
            string[] allCharArray = allChar.Split(',');
            string RandomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < CodeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(temp * i * ((int)DateTime.Now.Ticks));
                }

                int t = rand.Next(allCharArray.Length - 1);

                while (temp == t)
                {
                    t = rand.Next(allCharArray.Length - 1);
                }

                temp = t;
                RandomCode += allCharArray[t];
            }
            return RandomCode;
        }
        #endregion
    }
}
