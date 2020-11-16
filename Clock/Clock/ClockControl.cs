using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class ClockControl : UserControl
    {
        public ClockControl()
        {
            InitializeComponent();
            setDefault();
        }

        private int _hour = 0, _minute = 0, _second = 0, _day = 1, _month = 1, _year = 2020;
        private string imgPath = @"C:\git\ClockApp\Resources\";

        private void setHour(int hour)
        {
            if (hour < 10)
            {
                hour1.Image = Image.FromFile(imgPath + "0.png");
                hour1.SizeMode = PictureBoxSizeMode.StretchImage;
                hour2.Image = Image.FromFile(imgPath + hour.ToString() + ".png");
                hour2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                hour1.Image = Image.FromFile(imgPath + (hour / 10).ToString() + ".png");
                hour1.SizeMode = PictureBoxSizeMode.StretchImage;
                hour2.Image = Image.FromFile(imgPath + (hour % 10).ToString() + ".png");
                hour2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void setMinute(int minute)
        {
            if (minute < 10)
            {
                minute1.Image = Image.FromFile(imgPath + "0.png");
                minute1.SizeMode = PictureBoxSizeMode.StretchImage;
                minute2.Image = Image.FromFile(imgPath + minute.ToString() + ".png");
                minute2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                minute1.Image = Image.FromFile(imgPath + (minute / 10).ToString() + ".png");
                minute1.SizeMode = PictureBoxSizeMode.StretchImage;
                minute2.Image = Image.FromFile(imgPath + (minute % 10).ToString() + ".png");
                minute2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void setSecond(int second)
        {
            if (second < 10)
            {
                second1.Image = Image.FromFile(imgPath + "0.png");
                second1.SizeMode = PictureBoxSizeMode.StretchImage;
                second2.Image = Image.FromFile(imgPath + second.ToString() + ".png");
                second2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                second1.Image = Image.FromFile(imgPath + (second / 10).ToString() + ".png");
                second1.SizeMode = PictureBoxSizeMode.StretchImage;
                second2.Image = Image.FromFile(imgPath + (second % 10).ToString() + ".png");
                second2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ClockControl_Load(object sender, EventArgs e)
        {

        }

        private void setDay(int day)
        {
            if (day < 10)
            {
                day1.Image = Image.FromFile(imgPath + "0.png");
                day1.SizeMode = PictureBoxSizeMode.StretchImage;
                day2.Image = Image.FromFile(imgPath + day.ToString() + ".png");
                day2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                day1.Image = Image.FromFile(imgPath + (day / 10).ToString() + ".png");
                day1.SizeMode = PictureBoxSizeMode.StretchImage;
                day2.Image = Image.FromFile(imgPath + (day % 10).ToString() + ".png");
                day2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void setMonth(int month)
        {
            if (month < 10)
            {
                month1.Image = Image.FromFile(imgPath + "0.png");
                month1.SizeMode = PictureBoxSizeMode.StretchImage;
                month2.Image = Image.FromFile(imgPath + month.ToString() + ".png");
                month2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                month1.Image = Image.FromFile(imgPath + (month / 10).ToString() + ".png");
                month1.SizeMode = PictureBoxSizeMode.StretchImage;
                month2.Image = Image.FromFile(imgPath + (month % 10).ToString() + ".png");
                month2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void setYear(int year)
        {
            year1.Image = Image.FromFile(imgPath + (year / 1000).ToString() + ".png");
            year1.SizeMode = PictureBoxSizeMode.StretchImage;
            year2.Image = Image.FromFile(imgPath + ((year / 100) % 10).ToString() + ".png");
            year2.SizeMode = PictureBoxSizeMode.StretchImage;
            year3.Image = Image.FromFile(imgPath + ((year / 10) % 10).ToString() + ".png");
            year3.SizeMode = PictureBoxSizeMode.StretchImage;
            year4.Image = Image.FromFile(imgPath + (year % 10).ToString() + ".png");
            year4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void setBar()
        {
            bar1.Image = Image.FromFile(imgPath + "-.png");
            bar1.SizeMode = PictureBoxSizeMode.StretchImage;
            bar2.Image = Image.FromFile(imgPath + "-.png");
            bar2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void setDefault()
        {
            _hour = _minute = _second = 0;
            _day = _month = 1;
            _year = 2020;
            setBar();
            setHour(_hour);
            setMinute(_minute);
            setSecond(_second);
            setDay(_day);
            setMonth(_month);
            setYear(_year);
        }

        public void setDateTime(int hour, int minute, int second, int day, int month, int year)
        {
            _hour = hour; setHour(hour);
            _minute = minute; setMinute(minute);
            _second = second; setSecond(second);
            _day = day; setDay(day);
            _month = month; setMonth(month);
            _year = year; setYear(year);
        }
    }
}
