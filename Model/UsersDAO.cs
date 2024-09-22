using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class UsersDAO
    {
        public async Task<bool> checkLogin(string json)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync("http://91.107.198.165:5000/api/User/Authenticate", content);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    if (responseContent.Contains("validate"))
                    {
                        Console.WriteLine("Conectado");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Error de lectura");
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        public async Task<List<Users>> getAllUsers()
        {
            try
            {
                Console.WriteLine("Error de lectura");
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync("http://91.107.198.165:5000/api/User/GetAll");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Users>>(responseBody);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}