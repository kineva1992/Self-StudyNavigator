using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Self_StudyNavigator
{
    class Task20
    {
        public void ReturnDataTimeTryParse()
        {
            string[] dataStrings =
            {
            "03/02/20",
            "3-02-2020",
            "03.02.2020 12:46:32",
            "03 февраля 20 10:15",
            "03.02.2020 12ч 46м"
            };

            DateTime dateValue;
            
            Console.WriteLine("Attempting to parse strings using {0} culture.", 
                CultureInfo.CurrentCulture.Name);

            foreach (var item in dataStrings)
            {
                if (DateTime.TryParse(item, out dateValue))
                    Console.WriteLine("Успешно преобразованно {0} в {1} ({2})",item, dateValue, dateValue.Kind);
                else
                    Console.WriteLine("Не удалось преобразовать {0}", item);
 
            }
        }
        /*
        1. Как получить текущую дату?
        DateTime.Now;
        2. Как вычесть из даты 2 дня?
        var toDayDate = DateTime.Now;
        var minusThreeDayOfDate = toDayDate.AddDate(-2);
        3. Можно ли преобразовать DateTime в строку?
        Да с помощью метода DateTime.ToString();

        4. Что вернет код:
        DateTime.Parse("01.01.2020").AddHours(-1); 31.12.2019 23:00:00
         */
    }
}
