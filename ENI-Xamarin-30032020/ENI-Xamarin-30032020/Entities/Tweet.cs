using System;
using System.Collections.Generic;
using System.Text;

namespace ENI_Xamarin_30032020.Entities
{
    public class Tweet
    {
		private String identifier;
		private DateTime creationDate;
		private User user;
		private String content;

		public String Identifier
		{
			get { return identifier; }
			set { identifier = value; }
		}
		public DateTime CreationDate
		{
			get { return creationDate; }
			set { creationDate = value; }
		}
		public String Content
		{
			get { return content; }
			set { content = value; }
		}


		public User User
		{
			get { return user; }
			set { user = value; }
		}
	}
}
