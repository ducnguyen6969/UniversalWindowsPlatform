﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MusicApp.Config;
using MusicApp.Entity;
using Newtonsoft.Json;
using Windows.UI.Xaml.Controls;

namespace MusicApp.Service
{
    class SongService
    {
        public void create()
        {

        }

        public async Task<List<Song>> GetListAsync() {
            List<Song> listSong = new List<Song>();
            using (HttpClient httpClient = new HttpClient())
            {
              
                var result = await httpClient.GetAsync($"{ApiConfig.ApiDomain}{ApiConfig.SongPath}");
                var content = await result.Content.ReadAsStringAsync();
                Debug.WriteLine($"Response {content} - {result.StatusCode}");
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                   
                    listSong= JsonConvert.DeserializeObject<List<Song>>(content);
                }
                else
                {
                    Debug.WriteLine("Error 500");
                }

            }
            return listSong;
        }

        public async Task<bool> Createsong(Song song)
        {
            var jsonString = JsonConvert.SerializeObject(song);
            HttpClient httpClient = new HttpClient();
            Debug.WriteLine(App.currentCredential.access_token);

            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {App.currentCredential.access_token}");
            HttpContent contentToSend = new StringContent(jsonString, Encoding.UTF8, ApiConfig.MediaType);
            var result = await httpClient.PostAsync($"{ApiConfig.ApiDomain}{ApiConfig.MySongPath}", contentToSend);
            var content = await result.Content.ReadAsStringAsync();
            Debug.WriteLine($"Response {content} - {result.StatusCode}");
            if (result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return true;
            }
            else
            {
                Debug.WriteLine(content);
                return false;
            }

        }
    }
}
