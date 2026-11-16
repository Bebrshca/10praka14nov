using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Комарова.Classes
{
    public class Passport
    {
        /// <summary> Имя </summary>
        public string Name { get; set; }

        /// <summary> Фамилия </summary>
        public string FirstName { get; set; }

        /// <summary> Отчество </summary>
        public string LastName { get; set; }

        /// <summary> Паспорт выдан </summary>
        public string Issued { get; set; }

        /// <summary> Дата выдачи </summary>
        public string DateOfIssued { get; set; }

        /// <summary> Код подразделения </summary>
        public string DepartmentCode { get; set; }

        /// <summary> Серия и номер </summary>
        public string SeriesAndNumber { get; set; }

        /// <summary> Дата рождения </summary>
        public string DateOfBirth { get; set; }

        /// <summary> Место рождения </summary>
        public string PlaceOfBirth { get; set; }
    }
}
