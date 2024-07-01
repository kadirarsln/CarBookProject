﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.BlogDtos;
using CarBook.Dto.TagCloudDtos;


namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsTagCloudComponentPartial : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public _BlogDetailsTagCloudComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.blogid = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7203/api/TagClouds/GetTagClodByBlogId/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetByBlogIdTagCloudDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
