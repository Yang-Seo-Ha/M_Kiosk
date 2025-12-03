using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;


namespace 키오스크.Models
{
    public class MenuRepository
    {
        public List<MenuItem> AllMenus { get; } = new();

        public MenuRepository()
        {
            // 파일마다 카테고리 강제 지정
            LoadFromJson("mc-burgers.json", "burgers");      // 버거/세트
            LoadFromJson("mc-lunch.json", "lunch");        // 맥런치
            LoadFromJson("mc-morning.json", "mc-morning");   // 맥모닝
            LoadFromJson("mc-cafe.json", "mc-cafe");      // 맥카페
            LoadFromJson("mc-sides.json", "sides");        // 사이드
            LoadFromJson("mc-happy-meal.json", "happy-meal");   // 해피밀
            LoadFromJson("mc-happy-snack.json", "happy-snack");  // 해피스낵
        }

        private void LoadFromJson(string fileName, string? defaultCategory = null)
        {
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Data",
                fileName);

            if (!File.Exists(path))
                return;

            string json = File.ReadAllText(path);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var items = JsonSerializer.Deserialize<List<MenuItem>>(json, options);
            if (items == null) return;

            foreach (var item in items)
            {
                // 파일 기준 카테고리 강제 세팅
                if (!string.IsNullOrEmpty(defaultCategory))
                {
                    item.category = defaultCategory;
                }

                AllMenus.Add(item);
            }
        }
    }



}
