using System;
using System.Collections.Generic;
using System.Text;

namespace ENI_Xamarin_30032020.Entities
{
    public class User : SQLiteEntity
	{
		private String login;
		private String password;
		private String pseudo;

		public String Login
		{
			get { return login; }
			set { login = value; }
		}

		public String Password
		{
			get { return password; }
			set { password = value; }
		}

		public String Pseudo
		{
			get { return pseudo; }
			set { pseudo = value; }
		}

	}
}
