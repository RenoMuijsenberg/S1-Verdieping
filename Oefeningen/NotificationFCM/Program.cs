using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NotificationFCM
{
    class Program
    {
        private readonly static HttpClientHandler clientHandler = new HttpClientHandler();
        private readonly static HttpClient client = new HttpClient(clientHandler); 
        
        static void Main(string[] args)
        {
            clientHandler.ServerCertificateCustomValidationCallback = (o, cert, chain, sslPolicyErrors) => { return true; };
            client.BaseAddress = new Uri("https://localhost:5001");

            List<User> users = new List<User>();

            //your MySQL connection string
            string connStr = "server=localhost;user=root;database=datereminder;port=3306;password=";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //Get user id
                string sql = "select * from aspnetusers;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    users.Add(new User(rdr[0].ToString()));
                }
                rdr.Close();

                foreach (var user in users) 
                {
                    List<string> notificationList = new List<string>();
                    string sql2 = $"select FcmToken from fcmusertokens where userid='{user.UserId}';";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();

                    while (rdr2.Read())
                    {
                        user.FcmToken = rdr2[0].ToString();
                    }
                    rdr2.Close();

                    string sql3 = $"select * from lists where userid='{user.UserId}';";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                    MySqlDataReader rdr3 = cmd3.ExecuteReader();

                    while (rdr3.Read())
                    {
                        user.AddListToUser(rdr3[3].ToString(), Convert.ToInt32(rdr3[4]));
                    }
                    rdr3.Close();

                    foreach (var list in user.Lists)
                    {
                        string sql4 = $"select * from products where listId='{list.ListId}';";
                        MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
                        MySqlDataReader rdr4 = cmd4.ExecuteReader();

                        while (rdr4.Read())
                        {
                            list.AddProduct(rdr4[2].ToString(), Convert.ToDateTime(rdr4[4]));
                        }
                        rdr4.Close();

                        int NotifTime = (list.NoitificationTime * -1);

                        foreach (var product in list.Products)
                        {
                            if ((product.ProductDate.AddDays(NotifTime)) == DateTime.Today)
                            {
                                notificationList.Add(product.ProductName);
                            }
                        }
                    }

                    if (!String.IsNullOrEmpty(user.FcmToken))
                    {
                        string body = "";

                        foreach (var item in notificationList)
                        {
                            body += item.ToString() + "\r\n";
                        }

                        var message = new
                        {
                            deviceId = user.FcmToken,
                            isAndroiodDevice = true,
                            title = "Items will spoil soon!",
                            body = body
                        };

                        string json = JsonConvert.SerializeObject(message);

                        Console.WriteLine(json);

                        SendMessage(json);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            conn.Close();
            Console.WriteLine("Connection Closed. Press any key to exit...");
            Console.Read();
        }

        static async void SendMessage(string json)
        {
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //Send data to api endpoint
            HttpResponseMessage response = await client.PostAsync("/api/notification/send", content);
        }
    }
}
