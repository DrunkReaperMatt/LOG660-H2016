using LOG660.DATA;
using LOG660.FACADE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOG660.UI
{
    public partial class FormMovieLocationCounter : Form
    {
        WebFlixFacade _facade = WebFlixFacade.getInstance;
        USAGER user = null;
        login login = null;
        public FormMovieLocationCounter(USAGER user, login login)
        {
            InitializeComponent();
            this.login = login;
            this.user = user;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");

            InitiliazeListBoxAgeRange();
            InitiliazeListBoxProvince();
            InitiliazeListBoxWeekDay();
            InitiliazeListBoxMonths();
        }

        private void InitiliazeListBoxAgeRange()
        {
            lBoxAgeRange.Items.Add("Tous");

            var _maxAgeInDb = _facade.getEntity.USAGERs.Max(u => (DateTime.Now.Year - u.DATENAISSANCE.Year));

            for (int i = 0; i < _maxAgeInDb; i += 5)
            {
                lBoxAgeRange.Items.Add(i + "-" + (i + 5));
            }
        }
        private void InitiliazeListBoxProvince()
        {
            lBoxProvince.Items.Add("Tous");

            var availablesProvinceInDB = _facade.getEntity.ADRESSEs.Select(u=>u).Distinct().OrderBy(a => a.PROVINCE).Select(a => a.PROVINCE);

            foreach (var province in availablesProvinceInDB.Distinct())
                lBoxProvince.Items.Add(province);
        }
        private void InitiliazeListBoxWeekDay()
        {
            lBoxDay.Items.Add("Tous");

            foreach (string day in Enum.GetNames(typeof(DayOfWeek)))
            {
                lBoxDay.Items.Add(day);
            }
        }
        private void InitiliazeListBoxMonths()
        {
            lBoxMonth.Items.Add("Tous");
            foreach (string monthName in DateTimeFormatInfo.InvariantInfo.MonthNames)
            {
                if (!String.IsNullOrEmpty(monthName))
                    lBoxMonth.Items.Add(monthName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Menu(user, login).Show();
        }
    }
}
