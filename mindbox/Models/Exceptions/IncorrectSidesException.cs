using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox.Models
{
    public class IncorrentSidesException : Exception
    {
        public IncorrentSidesException() : base("Некорректное количество сторон фигуры.")
        {
        }

        public IncorrentSidesException(Exception innerException) : base("Некорректное количество сторон фигуры.", innerException)
        {
        }
    }
}
