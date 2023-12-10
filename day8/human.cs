using System;
namespace day8
{
	 class Human
	{
		static int cnt;
		private int Id;
		public string Name;
		public string address;
		private string  email;
		public int age;

        public Human()
        {

        }

        public Human( string Name , string address , string email, int age)
		{
			cnt += 1;
			 Id =cnt;
			this.Name = Name;
            this.address = address;
			this.email = email;
			this.age = age;
		}
  
        public string greetingbyhuman() => $"{this.Name} \n your email address is :{this.email} \n your age is {this.age}";
		public static bool ValidateAge(int age)
		{
			if (age <= 0 || age >= 100)
			{
				return false;
			}
			return true;
		}
		public int GetId() => this.Id;

		public string Setemail(string newemail) => this.email = newemail;

		public string Getemail() => this.email;
	}
}


