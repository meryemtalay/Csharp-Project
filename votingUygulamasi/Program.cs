using System;
using System.Collections.Generic;

namespace votingUygulamasi
{
    class Program
    {
        static List<Category> categories = new List<Category>();

        static void Main(string[] args)
        {
            InitializeCategories();

            Console.Write("Kullanıcı adınız: ");
            string username = Console.ReadLine();

            User user = User.GetUserByUsername(username);
            if (user == null)
            {
                user = new User(username);
                User.Users.Add(user);
                Console.WriteLine("Yeni kullanıcı kaydedildi.");
            }

            ShowCategories();
            int choice = GetCategoryChoice();

            if (choice != -1)
            {
                categories[choice].Votes++;
                Console.WriteLine($"Teşekkürler, {username}. Oyunuz kaydedildi.");
            }
            else
            {
                Console.WriteLine("Hatalı giriş. Lütfen geçerli bir kategori seçin.");
            }

            PrintResults();
            Console.WriteLine("Program sonlandı. Çıkmak için ENTER tuşuna basın.");
            Console.ReadLine();
        }

        static void InitializeCategories()
        {
            categories.Add(new Category("Film Kategorileri"));
            categories.Add(new Category("Tech Stack Kategorileri"));
            categories.Add(new Category("Spor Kategorileri"));
        }

        static void ShowCategories()
        {
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i].Name}");
            }
        }

        static int GetCategoryChoice()
        {
            Console.Write("Yukarıdaki kategorilerden birini seçin (1,2,3): ");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 3)
                {
                    return choice - 1;
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        static void PrintResults()
        {
            int totalVotes = 0;
            foreach (Category category in categories)
            {
                totalVotes += category.Votes;
            }

            Console.WriteLine("KATEGORI\t\t\t\t OY SAYISI\t     OY ORANI");
            foreach (Category category in categories)
            {
                double votePercentage = (double)category.Votes / totalVotes * 100;
                // category.Name değerini alır ve en fazla 40 karakter uzunluğunda bir alana yerleştirir. Eğer isim 40 karakterden kısa ise, eksik kalan kısmı boşlukla doldurur.
                //  Burada N2 format belirleyicisi, ondalık sayıyı iki basamakla sınırlar. % sembolü, sayının yüzde olarak gösterilmesini sağlar. {votePercentage,5:N2}% ifadesi, en fazla 5 karakter uzunluğunda bir alana yerleştirir. Eğer oy oranı 5 karakterden kısa ise, eksik kalan kısmı boşlukla doldurur.
                // -olması karakteri sola yaslar. {votePercentage,5:N2}% ifadesinde - olmadığı için sonucu sağda gösterilir.
                Console.WriteLine($"{category.Name,-40} {category.Votes,-20} {votePercentage,5:N2}%");
            }
        }
    }

    class Category
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        // yapıcı metod (Constructor)
        public Category(string name)
        {
            Name = name;
            Votes = 0;
        }
    }

    class User
    {
        public static List<User> Users = new List<User>();

        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
        }

        public static User GetUserByUsername(string username)
        {
            foreach (User user in Users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
