﻿using _19_07_2023_task1.Models;
using _19_07_2023_task1.Services.Interfaces;
using _19_07_2023_task1.ViewModels;

namespace _19_07_2023_task1.Services
{
    public class TaxSubjectApiCaller : ITaxSubjectsApiCaller
	{

		private static HttpClient _httpClient = new HttpClient() { BaseAddress = new Uri("https://wl-test.mf.gov.pl/api/search/nip/") };

        public async Task<string> GetStringResponseByTINAsync(SearchViewModel model)
		{
			try
			{
				var currentDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
				_httpClient.DefaultRequestHeaders.Clear();
				var response = await _httpClient.GetStringAsync($"{_httpClient.BaseAddress}{model.Nip}?date={currentDate}");
				return response;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unhandled exception: " + ex.Message);
			}
			return string.Empty;
		}

		public async Task<SearchViewModel> GetTaxSubjectByTINAsync(SearchViewModel model)
		{
			try
			{
				var currentDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
				_httpClient.DefaultRequestHeaders.Clear();
				var response = await _httpClient.GetFromJsonAsync<Root>($"{_httpClient.BaseAddress}{model.Nip}?date={currentDate}");
				model.Root = response;
			}
			catch(Exception ex)
			{
				Console.WriteLine("Unhandled exception during API call: " + ex.Message);
			}
			return Task.FromResult(model).Result;
		}
	}
}
