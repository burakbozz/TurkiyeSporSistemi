using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkiyeSporSistemi.ConsoleUI.Model.ReturnModels;

public class ReturnModel<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }

    public override string ToString()
    {
        return $"Başarılı Mı : {Success} \n Mesaj : {Message} \n Veri : {Data}";
    }
}
