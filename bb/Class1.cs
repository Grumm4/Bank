using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bb
{
    public delegate void AccountHandler(Class1 sender, AccountEventArgs e);
    public class Class1
    {
        public event AccountHandler Notify;

        public int Sum { get; private set; }



        // Создаем переменную делегата
        public Class1(int sum) => Sum = sum;
        public Class1() { }
        // Регистрируем делегат
        //public void RegisterHandler(AccountHandler del)
        //{
        //    taken = del;
        //}
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило: {sum}", sum));
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Со счета снято: {sum}", sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счету", sum));
            }
        }

    }
    public class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }
        // Сумма, на которую изменился счет
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}
