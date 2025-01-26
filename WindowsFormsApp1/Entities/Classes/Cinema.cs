using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities.Interfaces;

namespace WindowsFormsApp1.Entities
{
    public class Cinema : ICinema
    {
        public string Address { get; private set; } 
        public string PhoneNumber { get; private set; }
        public string Director { get; private set; }
        public string Owner { get; private set; }
        public string Bank { get; private set; }
        public string BankNumber { get; private set; }
        public string ITN { get; private set; }
        public int Seats { get; private set; }


        public Cinema(string address, string phoneNumber, string director, string owner, string bank, string bankNumber, string itn, int seats) 
        {
            if (string.IsNullOrWhiteSpace(address)) throw new ArgumentException(nameof(address), "Адресс кинотеатра не может быть пустым");
            if (string.IsNullOrWhiteSpace(phoneNumber)) throw new ArgumentException(nameof(phoneNumber), "Номер кинотеатра не может быть пустым");
            if (string.IsNullOrWhiteSpace(director)) throw new ArgumentException(nameof(director), "У кинотеатра должен быть директор (поле пустое)");
            if (string.IsNullOrWhiteSpace(owner)) throw new ArgumentException(nameof(owner), "У кинотеатра должен быть владелец (поле пустое)");
            if (string.IsNullOrWhiteSpace(bank)) throw new ArgumentException(nameof(bank), "У кинотеатра должен быть банк (поле пустое)");
            if (string.IsNullOrWhiteSpace(bankNumber)) throw new ArgumentException(nameof(bankNumber), "У кинотеатра должен быть счет в банке (поле пустое)");
            if (string.IsNullOrWhiteSpace(itn)) throw new ArgumentException(nameof(itn), "У кинотеатра должен быть ИНН (поле пустое)");
            if (seats <= 0) throw new ArgumentException(nameof(seats), "Количество посадочных мест в кинотеатре должно быть больше чем 0");
            address = Address;
            phoneNumber = PhoneNumber;
            director = Director;
            owner = Owner;
            bank = Bank;
            bankNumber = BankNumber;
            itn = ITN;
            seats = Seats;
        }
        
        public void Update(string address, string phoneNumber, string director, string owner, string bank, string bankNumber, string itn, int seats) 
        {
            address = Address;
            phoneNumber = PhoneNumber;
            director = Director;
            owner = Owner;
            bank = Bank;
            bankNumber = BankNumber;
            itn = ITN;
            seats = Seats;
        }
    }
}
