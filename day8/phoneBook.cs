using System;
namespace day8
{
	 public class phoneBook
	{
		string[] Names;
		long[] numbers;
		int size;
		int cnt;


		public phoneBook()
		{
		}
		public phoneBook (int size)
		{
			this.size = size;
			this.Names = new string[size];
			this.numbers = new long[size];
		}
		public int GetNumbers()
		{
			for (int i = 0; i<size; i++)
			{
				if (numbers[i] != null) ;
			}
			return this.size; 
		}
		public long GetNum(string name)
		{
			for (int i = 0; i<size; i++)
			{
				if (Names[i] == name )
				{
					return this.numbers[i];
				}
				
			}
            return -1;

        }
		public long  this[string  name]
		{
			get {

				for(int i = 0; i< this.size; i++)
				{
					if (Names  [i] == name   )
					{
						return numbers[i];
					}
				}
                return 0;


            }
            set {
				Names[cnt] = name;
				numbers[cnt] = value;
				cnt += 1;
			}
		}
	}
}

