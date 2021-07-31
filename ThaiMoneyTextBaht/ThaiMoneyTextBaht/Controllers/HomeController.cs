using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ThaiMoneyTextBaht.Models;

namespace ThaiMoneyTextBaht.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Random _random = new Random();

            List<MoneyModel> money = new List<MoneyModel>();

            for (int i = 0; i < 10; i++)
            {
                decimal _num = _random.Next(0, 999999999);
                money.Add(new MoneyModel() { Money = _num.ToString("#,###,##0.00"), MoneyText = MoneyRead(_num.ToString()) });
            }

            ViewData["Money"] = money.ToList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string MoneyRead(string _money, bool IsTrillion = false)
        {
            string MoneyText = "";
            string Trillion = "";

            string[] _text = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
            string[] _read = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };

            decimal _number = 0;
            decimal.TryParse(_money, out _number);

            if (_number == 0)
            {
                return "ศูนย์บาทถ้วน";
            }

            _money = _number.ToString("0.00");
            string _integer = _money.Split('.')[0];
            string _satang = _money.Split('.')[1];

            if (_integer.Length > 13)
                throw new Exception("รองรับตัวเลขได้เพียง ล้านล้าน เท่านั้น!");

            bool _IsTrillion = _integer.Length > 7;
            if (_IsTrillion)
            {
                Trillion = _integer.Substring(0, _integer.Length - 6);
                MoneyText = MoneyRead(Trillion, _IsTrillion);

                _integer = _integer.Substring(Trillion.Length);
            }

            int _length = _integer.Length;
            for (int i = 0; i < _integer.Length; i++)
            {
                string number = _integer.Substring(i, 1);
                if (number != "0")
                {
                    if (i == _length - 1 && number == "1" && _length != 1)
                    {
                        MoneyText += "เอ็ด";
                    }
                    else if (i == _length - 2 && number == "2" && _length != 1)
                    {
                        MoneyText += "ยี่";
                    }
                    else if (i != _length - 2 || number != "1")
                    {
                        MoneyText += _text[int.Parse(number)];
                    }

                    MoneyText += _read[(_length - i) - 1];
                }
            }

            if (IsTrillion)
            {
                return MoneyText + "ล้าน";
            }

            if (_integer != "0")
            {
                MoneyText += "บาท";
            }

            if (_satang == "00")
            {
                MoneyText += "ถ้วน";
            }
            else
            {
                _length = _satang.Length;
                for (int i = 0; i < _satang.Length; i++)
                {
                    string number = _satang.Substring(i, 1);
                    if (number != "0")
                    {
                        if (i == _length - 1 && number == "1" && _satang[0].ToString() != "0")
                        {
                            MoneyText += "เอ็ด";
                        }
                        else if (i == _length - 2 && number == "2" && _satang[0].ToString() != "0")
                        {
                            MoneyText += "ยี่";
                        }
                        else if (i != _length - 2 || number != "1")
                        {
                            MoneyText += _text[int.Parse(number)];
                        }

                        MoneyText += _read[(_length - i) - 1];
                    }
                }

                MoneyText += "สตางค์";
            }

            return MoneyText;
        }
    }
}
