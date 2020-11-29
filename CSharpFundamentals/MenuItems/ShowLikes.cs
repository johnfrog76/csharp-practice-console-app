using System;
using System.Collections.Generic;

namespace CSharpFundamentals {
    class ShowLikes : MenuItem {
        public override string Title => "Show Likes";
        public override string Instructions => "Type a name and hit enter, repeat again to see " +
                "who gave like this post. Type 'exit' when done.";

        public override bool Execute()
        {
            Messages.Warn(Instructions);

            var input = "";
            var likes = new List<string>();
            var numLikes = likes.Count;

            while (true)
            {
                input = Console.ReadLine();
                try
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        if (input.ToUpper() == "EXIT")
                        {
                            MenuApp.SubMenu();
                            break;
                        }

                        likes.Add(input);
                        numLikes = likes.Count;
                        var success = "";

                        if (numLikes == 0)
                        {
                            success = "Your post has zero likes";
                        }
                        else if (numLikes == 1)
                        {
                            var friend1 = likes[0];
                            success = String.Format("{0} likes your post", friend1);
                        }
                        else if (numLikes == 2)
                        {
                            var friend1 = likes[0];
                            var friend2 = likes[1];

                            success = String.Format(
                                "{0} and {1} like your post",
                                friend1,
                                friend2
                            );
                        }
                        else if (numLikes > 2)
                        {
                            var friend1 = likes[0];
                            var friend2 = likes[1];
                            success = String.Format(
                                "{0}, {1}, and {2} others like your post",
                                friend1,
                                friend2,
                                (numLikes - 2)
                            );

                        }
                        Messages.Success(success);
                        continue;
                    }
                    break;

                }
                catch (Exception)
                {

                    Messages.Error();
                    continue;
                }

            }
            return true;
        }
    }
}