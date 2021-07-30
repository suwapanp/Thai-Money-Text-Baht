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
                money.Add(new MoneyModel() { Money = _num.ToString("#,###,##0.00"), MoneyText = ChangeText(_num.ToString()) });
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

        string[] TextCount = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
        string[] TextPost = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
        string ChangeText(string _money, bool IsMillion = false)
        {
            string _baht = "";
            string _million = "";

            decimal money = 0;
            decimal.TryParse(_money, out money);

            if (money == 0)
            {
                return "ศูนย์บาทถ้วน";
            }

            string[] _number
                = money.ToString("0.00").Split('.');

            string _int = _number[0];
            string _satang = _number[1];

            if (_int.Length > 13)
            {
                return "ลองรับตัวเลข 13 หลัก หรือ ล้านล้านบาท เท่านั้น";
            }

            bool _IsMillion = _int.Length > 7;

            if (_IsMillion)
            {
                _million = _int.Substring(0, _int.Length - 6);
                _baht = ChangeText(_million, true);
                _int = _int.Substring(_million.Length);
            }

            int _length = _int.Length;

            for (int i = 0; i < _length; i++)
            {
                string _subnumber = _int.Substring(i, 1);
                if (_subnumber != "0")
                {
                    if (i == _length - 1 && _subnumber == "1" && _length != 1)
                    {
                        _baht += "เอ็ด";
                    }
                    else if (i == _length - 2 && _subnumber == "2" && _length != 2)
                    {
                        _baht += "ยี่";
                    }
                    else if (i != _length - 2 || _subnumber != "1")
                    {
                        _baht += TextPost[int.Parse(_subnumber)];
                    }

                    _baht += TextPost[((_length - i) - 1)];

                }

            }

            if (_IsMillion)
            {
                return _baht += "ล้าน";
            }

            if (_int != "0")
            {
                _baht += "บาท";
            }

            if (_satang == "00")
            {
                _baht += "ถ้วน";
            }
            else
            {
                _length = _satang.Length;

                for (int i = 0; i < _length; i++)
                {
                    string _subnumber = _int.Substring(i, 1);
                    if (_subnumber != "0")
                    {
                        if (i == _length - 1 && _subnumber == "1" && _length != 1)
                        {
                            _baht += "เอ็ด";
                        }
                        else if (i == _length - 2 && _subnumber == "2" && _length != 2)
                        {
                            _baht += "ยี่";
                        }
                        else if (i != _length - 2 || _subnumber != "1")
                        {
                            _baht += TextPost[int.Parse(_subnumber)];
                        }

                        _baht += TextPost[((_length - i) - 1)];

                    }

                }

            }

            return _baht;
        }
    }
}
