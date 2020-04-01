using ENI_Xamarin_30032020.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENI_Xamarin_30032020.Services
{
    public class TwitterServiceImpl : ITwitterService
    {
        public List<Tweet> Tweets
        {
            get
            {
                User user = new User() {Login="test", Password="password", Pseudo="antoine" };
                return new List<Tweet>()
                {
                    new Tweet() { Identifier = user.Pseudo, User = user, CreationDate = DateTime.Now, Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam." },
                    new Tweet() { Identifier = user.Pseudo, User = user, CreationDate = DateTime.Now, Content = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur"},
                    new Tweet() { Identifier = user.Pseudo, User = user, CreationDate = DateTime.Now, Content = "Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?"},
                    new Tweet() { Identifier = user.Pseudo, User = user, CreationDate = DateTime.Now, Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
                    new Tweet() { Identifier = user.Pseudo, User = user, CreationDate = DateTime.Now, Content = "Non numquam eius modi tempora incidunt ut labore et."},
                    new Tweet() { Identifier = user.Pseudo, User = user, CreationDate = DateTime.Now, Content = "Sed ut perspiciatis unde omnis iste natus error."}
                };
            }
        }

        public String Authenticate(User user)
        {
            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(user.Login) || user.Login.Length < 3)
            {
                stringBuilder.Append("L'identifiant ne peut pas être null et doit posséder au moins 3 caractères.");
                haveError = true;
            }

            if (String.IsNullOrEmpty(user.Password) || user.Password.Length < 6)
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("Le mot de passe ne peut pas être null et doit posséder au moins 6 caractères.");
            }

            if (!Tweets.Select( x => x.User).Contains(user))
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("L'utilisateur n'existe pas.");
            }

            return stringBuilder.ToString();
        }
    }
}
